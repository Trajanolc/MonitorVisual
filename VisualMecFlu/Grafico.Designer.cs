namespace VisualMecFlu
{
    partial class Grafico
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            voltar = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(56, 101);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(856, 372);
            formsPlot1.TabIndex = 0;
            // 
            // voltar
            // 
            voltar.AutoSize = true;
            voltar.Location = new Point(41, 43);
            voltar.Name = "voltar";
            voltar.Size = new Size(75, 25);
            voltar.TabIndex = 1;
            voltar.Text = "Voltar";
            voltar.UseVisualStyleBackColor = true;
            voltar.Click += voltar_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.Control;
            Title.Location = new Point(375, 34);
            Title.Name = "Title";
            Title.Size = new Size(192, 45);
            Title.TabIndex = 2;
            Title.Text = "Visualização";
            // 
            // Grafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(954, 529);
            Controls.Add(Title);
            Controls.Add(voltar);
            Controls.Add(formsPlot1);
            Name = "Grafico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button voltar;
        private Label Title;
    }
}