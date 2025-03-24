namespace VisualMecFlu
{
    partial class SelecaoTipo
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
            button2 = new Button();
            PlacaOrificio = new Button();
            Venturi = new Button();
            voltar = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.HighlightText;
            Title.Location = new Point(82, 24);
            Title.Name = "Title";
            Title.Size = new Size(647, 50);
            Title.TabIndex = 0;
            Title.Text = "Selecione o Tipo de Medidor Utilizado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Controls.Add(PlacaOrificio, 1, 0);
            tableLayoutPanel1.Controls.Add(Venturi, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 114);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(776, 202);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(546, 30);
            button2.Margin = new Padding(30);
            button2.Name = "button2";
            button2.Size = new Size(200, 142);
            button2.TabIndex = 2;
            button2.Text = "Bocal";
            button2.UseVisualStyleBackColor = true;
            // 
            // PlacaOrificio
            // 
            PlacaOrificio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlacaOrificio.Location = new Point(288, 30);
            PlacaOrificio.Margin = new Padding(30);
            PlacaOrificio.Name = "PlacaOrificio";
            PlacaOrificio.Size = new Size(198, 142);
            PlacaOrificio.TabIndex = 1;
            PlacaOrificio.Text = "Placa de Orificio";
            PlacaOrificio.UseVisualStyleBackColor = true;
            PlacaOrificio.Click += button1_Click;
            // 
            // Venturi
            // 
            Venturi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Venturi.Location = new Point(30, 30);
            Venturi.Margin = new Padding(30);
            Venturi.Name = "Venturi";
            Venturi.Size = new Size(198, 142);
            Venturi.TabIndex = 0;
            Venturi.Text = "Tubo de Venturi";
            Venturi.UseVisualStyleBackColor = true;
            Venturi.Click += Venturi_Click;
            // 
            // voltar
            // 
            voltar.Location = new Point(12, 24);
            voltar.Name = "voltar";
            voltar.Size = new Size(54, 23);
            voltar.TabIndex = 2;
            voltar.Text = "Voltar";
            voltar.UseVisualStyleBackColor = true;
            voltar.Click += voltar_Click;
            // 
            // SelecaoTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(voltar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Title);
            Name = "SelecaoTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelecaoTipo";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Venturi;
        private Button button2;
        private Button PlacaOrificio;
        private Button voltar;
    }
}