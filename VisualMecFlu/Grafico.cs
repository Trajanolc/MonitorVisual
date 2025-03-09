using ScottPlot.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public VenturiModel equipamento;
        public static Grafico instance;
        public TipoMedicao tipoMedicao;

        public Grafico()
        {
            InitializeComponent();

            instance = this;


        }

        public void run()
        {
            if (tipoMedicao == TipoMedicao.Planilha)
            {
                var lista = equipamento.CalculoArray();


                formsPlot1.Plot.Add.Scatter(lista.Select(e => e.Tempo).ToList(), lista.Select(e => e.Vazao).ToList());

                var tempoMax = lista.Select(e => e.Tempo).ToList().Max() + 2;
                var vazaoMax = lista.Select(e => e.Vazao).ToList().Max() + 2;


                formsPlot1.Plot.Axes.SetLimits(0, tempoMax, 0, vazaoMax);
                formsPlot1.Refresh();
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Venturi.instance.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            run();
        }
    }
}
