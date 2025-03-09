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
    public partial class SelecaoTipo : Form
    {
        public static SelecaoTipo instance;
        internal List<CargaDados> dados = [];
        internal TipoMedicao tipoMedicao;
        public SelecaoTipo()
        {
            InitializeComponent();
            instance = this;

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Home.instance.Show();
            this.Close();
        }

        private void Venturi_Click(object sender, EventArgs e)
        {
            Venturi venturiForm = new Venturi();
            venturiForm.dados = dados;
            venturiForm.tipoMedicao = this.tipoMedicao;
            venturiForm.Show();

            this.Hide();
          

        }
    }
}
