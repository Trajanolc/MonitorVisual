using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualMecFlu.Models;

namespace VisualMecFlu
{
    public partial class SelecaoTipo : Form
    {
        public static SelecaoTipo instance;
        public SerialPort serialPort;
        internal List<CargaDados> dados = [];
        internal TipoMedicao tipoMedicao;
        public SelecaoTipo()
        {
            InitializeComponent();
            instance = this;

        }

        private void voltar_Click(object sender, EventArgs e)
        {

            if (this.tipoMedicao == TipoMedicao.TempoReal) {
                SelecaoPorta.instance.Show();
                this.Close();
            }
            else{
                Home.instance.Show();
                this.Close();
            }
            
        }

        private void Venturi_Click(object sender, EventArgs e)
        {
            Venturi venturiForm = new Venturi();
            venturiForm.dados = dados;
            venturiForm.serialPort = serialPort;
            venturiForm.tipoMedicao = this.tipoMedicao;
            venturiForm.Show();

            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlacaOrificio placaOrificioForm = new PlacaOrificio();
            placaOrificioForm.dados = dados;
            placaOrificioForm.serialPort= serialPort;
            placaOrificioForm.tipoMedicao = this.tipoMedicao;
            placaOrificioForm.Show();

            this.Hide();
        }
    }
}
