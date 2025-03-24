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
    public partial class PlacaOrificio : Form
    {
        public List<CargaDados> dados = [];
        public TipoMedicao tipoMedicao;
        public SerialPort serialPort;
        public static PlacaOrificio instance;
        public PlacaOrificio()
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
            PlacaOrificioModel model = new PlacaOrificioModel()
            {
                D2 = (double)this.D2Value.Value,
                DensidadeLiquido = (double)this.DensidadeValue.Value,
                CoeficienteEscoamento = (double)this.CoeficienteEscoamentoValue.Value
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
            grafico.gerar();
            this.Hide();


        }
    }
}
