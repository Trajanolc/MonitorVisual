using ScottPlot.Colormaps;
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
using VisualMecFlu.Interfaces;
using VisualMecFlu.Models;

namespace VisualMecFlu
{
    public partial class Grafico : Form
    {
        public IEquipamentoMedicao equipamento;
        public static Grafico instance;
        public SerialPort serialPort;
        public TipoMedicao tipoMedicao;

        public Grafico()
        {
            InitializeComponent();

            instance = this;


        }

        public void gerar()
        {
            if (tipoMedicao == TipoMedicao.Planilha)
            {
                var lista = equipamento.CalculoArray();


                formsPlot1.Plot.Add.Scatter(lista.Select(e => e.Tempo).ToList(), lista.Select(e => e.Vazao).ToList());
            }

            if (tipoMedicao == TipoMedicao.TempoReal) { 
                //configurar refresh por timer.ticker
            }



            formsPlot1.Plot.Axes.AutoScaleExpand();
            formsPlot1.Plot.XLabel("Tempo (s)");
            formsPlot1.Plot.YLabel("Vazão (m³/s)");


            formsPlot1.Refresh();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Venturi.instance.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerar();
        }

        private void limparDados(SerialPort serialPort)
        {
            if (!serialPort.IsOpen) {
                return;
            }

            string leitura = serialPort.ReadExisting();
            leitura = leitura.Trim();
            leitura = leitura.Substring(leitura.IndexOf("DATA"));

        }
    }
}
