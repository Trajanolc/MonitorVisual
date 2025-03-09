namespace VisualMecFlu
{
    partial class Venturi
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
            Title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CoeficienteDescargaValue = new NumericUpDown();
            DensidadeValue = new NumericUpDown();
            D2Value = new NumericUpDown();
            label6 = new Label();
            DensidadeLiquido = new Label();
            A2 = new Label();
            D1 = new Label();
            D1Value = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CoeficienteDescargaValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DensidadeValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D2Value).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D1Value).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.HighlightText;
            Title.Location = new Point(239, 26);
            Title.Name = "Title";
            Title.Size = new Size(290, 50);
            Title.TabIndex = 0;
            Title.Text = "Medição Venturi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CoeficienteDescargaValue, 1, 3);
            tableLayoutPanel1.Controls.Add(DensidadeValue, 1, 2);
            tableLayoutPanel1.Controls.Add(D2Value, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(DensidadeLiquido, 0, 2);
            tableLayoutPanel1.Controls.Add(A2, 0, 1);
            tableLayoutPanel1.Controls.Add(D1, 0, 0);
            tableLayoutPanel1.Controls.Add(D1Value, 1, 0);
            tableLayoutPanel1.Location = new Point(37, 126);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(740, 226);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // CoeficienteDescargaValue
            // 
            CoeficienteDescargaValue.DecimalPlaces = 3;
            CoeficienteDescargaValue.Dock = DockStyle.Fill;
            CoeficienteDescargaValue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoeficienteDescargaValue.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            CoeficienteDescargaValue.Location = new Point(373, 171);
            CoeficienteDescargaValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            CoeficienteDescargaValue.Name = "CoeficienteDescargaValue";
            CoeficienteDescargaValue.Size = new Size(364, 50);
            CoeficienteDescargaValue.TabIndex = 10;
            // 
            // DensidadeValue
            // 
            DensidadeValue.DecimalPlaces = 3;
            DensidadeValue.Dock = DockStyle.Fill;
            DensidadeValue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DensidadeValue.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            DensidadeValue.Location = new Point(373, 115);
            DensidadeValue.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            DensidadeValue.Name = "DensidadeValue";
            DensidadeValue.Size = new Size(364, 50);
            DensidadeValue.TabIndex = 9;
            // 
            // D2Value
            // 
            D2Value.DecimalPlaces = 3;
            D2Value.Dock = DockStyle.Fill;
            D2Value.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            D2Value.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            D2Value.Location = new Point(373, 59);
            D2Value.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            D2Value.Name = "D2Value";
            D2Value.Size = new Size(364, 50);
            D2Value.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(3, 168);
            label6.Name = "label6";
            label6.Size = new Size(364, 58);
            label6.TabIndex = 6;
            label6.Text = "Coeficiente de Descarga";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DensidadeLiquido
            // 
            DensidadeLiquido.AutoSize = true;
            DensidadeLiquido.Dock = DockStyle.Fill;
            DensidadeLiquido.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DensidadeLiquido.ForeColor = SystemColors.ButtonFace;
            DensidadeLiquido.Location = new Point(3, 112);
            DensidadeLiquido.Name = "DensidadeLiquido";
            DensidadeLiquido.Size = new Size(364, 56);
            DensidadeLiquido.TabIndex = 4;
            DensidadeLiquido.Text = "Densidade Liquido";
            DensidadeLiquido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // A2
            // 
            A2.AutoSize = true;
            A2.Dock = DockStyle.Fill;
            A2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            A2.ForeColor = SystemColors.ButtonFace;
            A2.Location = new Point(3, 56);
            A2.Name = "A2";
            A2.Size = new Size(364, 56);
            A2.TabIndex = 2;
            A2.Text = "Diâmetro Menor (cm)";
            A2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // D1
            // 
            D1.AutoSize = true;
            D1.Dock = DockStyle.Fill;
            D1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            D1.ForeColor = SystemColors.ButtonFace;
            D1.Location = new Point(3, 0);
            D1.Name = "D1";
            D1.Size = new Size(364, 56);
            D1.TabIndex = 0;
            D1.Text = "Diâmetro Maior (cm)";
            D1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // D1Value
            // 
            D1Value.DecimalPlaces = 3;
            D1Value.Dock = DockStyle.Fill;
            D1Value.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            D1Value.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            D1Value.Location = new Point(373, 3);
            D1Value.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            D1Value.Name = "D1Value";
            D1Value.Size = new Size(364, 50);
            D1Value.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(37, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(261, 376);
            button2.Name = "button2";
            button2.Size = new Size(293, 50);
            button2.TabIndex = 3;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Venturi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Title);
            Name = "Venturi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venturi";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CoeficienteDescargaValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)DensidadeValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)D2Value).EndInit();
            ((System.ComponentModel.ISupportInitialize)D1Value).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TableLayoutPanel tableLayoutPanel1;
        private Label D1;
        private Label label6;
        private Label DensidadeLiquido;
        private Label A2;
        private NumericUpDown D1Value;
        private NumericUpDown CoeficienteDescargaValue;
        private NumericUpDown DensidadeValue;
        private NumericUpDown D2Value;
        private Button button1;
        private Button button2;
    }
}