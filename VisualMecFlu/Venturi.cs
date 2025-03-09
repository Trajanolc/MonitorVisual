using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualMecFlu.Models;

namespace VisualMecFlu
{
    public partial class Venturi : Form
    {
        public List<CargaDados> dados = [];
        public TipoMedicao tipoMedicao;
        public static Venturi instance;
        public Venturi()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecaoTipo.instance.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VenturiModel model = new VenturiModel()
            {
                D1 = (double)this.D1Value.Value,
                D2 = (double)this.D2Value.Value,
                DensidadeLiquido = (double)this.DensidadeValue.Value,
                CoeficienteDescarga = (double)this.CoeficienteDescargaValue.Value
            };

            model.CalcularAreas();

            if(tipoMedicao == TipoMedicao.Planilha)
            {
                model.CargaDados = dados;
            }

            Grafico grafico = new Grafico();
            grafico.equipamento = model;
            grafico.tipoMedicao = tipoMedicao;
            grafico.Show();
            grafico.run();
            this.Hide();


        }
    }
}
