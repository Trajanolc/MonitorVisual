using System.IO.Ports;

namespace VisualMecFlu
{
    partial class SelecaoPorta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            boxPorta = new ComboBox();
            label3 = new Label();
            saidaPorta = new Label();
            continuar = new Button();
            voltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(29, 95);
            label1.Name = "label1";
            label1.Size = new Size(276, 41);
            label1.TabIndex = 0;
            label1.Text = "Selecione a Entrada";
            // 
            // boxPorta
            // 
            boxPorta.FormattingEnabled = true;
            boxPorta.Location = new Point(39, 159);
            boxPorta.Margin = new Padding(3, 4, 3, 4);
            boxPorta.Name = "boxPorta";
            boxPorta.Size = new Size(186, 28);
            boxPorta.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(470, 55);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 3;
            label3.Text = "Saída Atual";
            // 
            // saidaPorta
            // 
            saidaPorta.AutoSize = true;
            saidaPorta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saidaPorta.ForeColor = SystemColors.Control;
            saidaPorta.Location = new Point(470, 159);
            saidaPorta.Name = "saidaPorta";
            saidaPorta.Size = new Size(20, 28);
            saidaPorta.TabIndex = 4;
            saidaPorta.Text = "-";
            // 
            // continuar
            // 
            continuar.Location = new Point(65, 264);
            continuar.Margin = new Padding(3, 4, 3, 4);
            continuar.Name = "continuar";
            continuar.Size = new Size(134, 52);
            continuar.TabIndex = 5;
            continuar.Text = "Continuar";
            continuar.UseVisualStyleBackColor = true;
            continuar.Click += continuar_Click;
            // 
            // voltar
            // 
            voltar.Location = new Point(29, 29);
            voltar.Margin = new Padding(3, 4, 3, 4);
            voltar.Name = "voltar";
            voltar.Size = new Size(86, 31);
            voltar.TabIndex = 6;
            voltar.Text = "Voltar";
            voltar.UseVisualStyleBackColor = true;
            voltar.Click += voltar_Click;
            // 
            // SelecaoPorta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(741, 493);
            Controls.Add(voltar);
            Controls.Add(continuar);
            Controls.Add(saidaPorta);
            Controls.Add(label3);
            Controls.Add(boxPorta);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SelecaoPorta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelecaoPorta";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BoxPorta_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox boxPorta;
        private Label label3;
        private Label saidaPorta;
        private Button continuar;
        private Button voltar;
    }
}