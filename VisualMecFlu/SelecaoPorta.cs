using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace VisualMecFlu
{
    public partial class SelecaoPorta : Form
    {
        private string porta = "";
        private SerialPort portaConectada = new SerialPort();
        private bool iniciadaConexao;
        public static SelecaoPorta instance;
        private Timer timer;
        public SelecaoPorta()
        {
            InitializeComponent();
            instance = this;
        }


        public void loader() {
            // Initialize Timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            carregarPortas();
            conectarPorta();
        }


        public void carregarPortas()
        {

                var portaSelecionada = boxPorta.Text;
                string[] portas = SerialPort.GetPortNames();
                boxPorta.Items.Clear();
                boxPorta.Items.AddRange(portas);
                if (boxPorta.Items.Contains(portaSelecionada))
                {
                    boxPorta.SelectedItem = portaSelecionada;
                }


        }


        public void conectarPorta()
        {
                var portaSelecionada = boxPorta.Text;
                if (porta != portaSelecionada && boxPorta.Text != "")
                {
                    realizarConexaoPorta();
                }

                if (boxPorta.Text != "" && portaConectada.IsOpen)
                {
                    string leitura = portaConectada.ReadExisting();
                    if (leitura.Contains("DATA"))
                    {
                        leitura = leitura.Substring(leitura.IndexOf("DATA"));
                    }
                    
                    saidaPorta.Text = leitura;
                }

        }

        private void realizarConexaoPorta()
        {
            if (portaConectada.IsOpen)
            {
                portaConectada.Close();
            }
            

            portaConectada = new SerialPort(boxPorta.Text);

            portaConectada.BaudRate = 9600;
            portaConectada.Parity = Parity.None;
            portaConectada.StopBits = StopBits.One;
            portaConectada.DataBits = 8;
            portaConectada.Handshake = Handshake.None;
            try
            {
                portaConectada.Open();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                saidaPorta.Text = "Sem Conexão";
            }


            porta = boxPorta.Text;
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (!portaConectada.IsOpen) {
                MessageBox.Show("Porta de conexão não disponível", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            SelecaoTipo selecaoTipo = new SelecaoTipo();

            selecaoTipo.tipoMedicao = TipoMedicao.TempoReal;
            selecaoTipo.serialPort = portaConectada;
            selecaoTipo.Show();
            this.Hide();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Home.instance.Show();
            this.Close();
        }
    }
}
