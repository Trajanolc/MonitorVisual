using GemBox.Spreadsheet;
using System.IO.Ports;
using System.Windows;
using VisualMecFlu.Models;
using VisualMecFlu.Services;
using MessageBox = System.Windows.Forms.MessageBox;

namespace VisualMecFlu
{
    public partial class Home : Form
    {
        public static Home instance;
        public Home()
        {
            InitializeComponent();
            instance = this;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }


        private void Planilha_Click(object sender, EventArgs e)
        {
            try
            {
                var dados = LeitorExcel.lerArquivo();
                if (dados == null)
                {
                    MessageBox.Show("Erro ao ler arquivo, certifique-se se é um arquivo válido com titulos 'LABEL, ID, Entrada 1, Entrada 2' e valores de ID, e entradas inteiros e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                SelecaoTipo selecaoTipo = new SelecaoTipo();

                selecaoTipo.dados = dados!;
                selecaoTipo.tipoMedicao = TipoMedicao.Planilha;

                selecaoTipo.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tempoReal_Click(object sender, EventArgs e)
        {
            SelecaoPorta selecaoPorta = new SelecaoPorta();
            selecaoPorta.loader();
            selecaoPorta.Show();
            this.Hide();

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }


    public enum TipoMedicao
    {
        Planilha = 1,
        TempoReal = 2
    }
}
