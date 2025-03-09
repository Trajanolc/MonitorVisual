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
            button1 = new Button();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(203, 125);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(519, 301);
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
            // button1
            // 
            button1.Location = new Point(401, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Grafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 529);
            Controls.Add(button1);
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
        private Button button1;
    }
}