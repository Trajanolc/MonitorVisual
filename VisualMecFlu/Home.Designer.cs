namespace VisualMecFlu
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            tempoReal = new Button();
            Planilha = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = SystemColors.HighlightText;
            Title.Location = new Point(270, 31);
            Title.Name = "Title";
            Title.Size = new Size(520, 62);
            Title.TabIndex = 0;
            Title.Text = "Monitor de Fluxo Visual";
            Title.Click += Title_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(tempoReal, 1, 0);
            tableLayoutPanel1.Controls.Add(Planilha, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 120);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4074059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5925941F));
            tableLayoutPanel1.Size = new Size(994, 428);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(520, 229);
            button3.Margin = new Padding(23, 27, 23, 27);
            button3.Name = "button3";
            button3.Size = new Size(451, 172);
            button3.TabIndex = 3;
            button3.Text = "Configurações";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(23, 229);
            button2.Margin = new Padding(23, 27, 23, 27);
            button2.Name = "button2";
            button2.Size = new Size(451, 172);
            button2.TabIndex = 2;
            button2.Text = "Histórico de Medições";
            button2.UseVisualStyleBackColor = true;
            // 
            // tempoReal
            // 
            tempoReal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tempoReal.AutoSize = true;
            tempoReal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tempoReal.Location = new Point(520, 27);
            tempoReal.Margin = new Padding(23, 27, 23, 27);
            tempoReal.Name = "tempoReal";
            tempoReal.Size = new Size(451, 148);
            tempoReal.TabIndex = 1;
            tempoReal.Text = "Medição Em Tempo Real";
            tempoReal.UseVisualStyleBackColor = true;
            tempoReal.Click += tempoReal_Click;
            // 
            // Planilha
            // 
            Planilha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha.AutoSize = true;
            Planilha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Planilha.Location = new Point(23, 27);
            Planilha.Margin = new Padding(23, 27, 23, 27);
            Planilha.Name = "Planilha";
            Planilha.Size = new Size(451, 148);
            Planilha.TabIndex = 0;
            Planilha.Text = "Medição Com Planilha";
            Planilha.TextImageRelation = TextImageRelation.ImageBeforeText;
            Planilha.UseMnemonic = false;
            Planilha.UseVisualStyleBackColor = true;
            Planilha.Click += Planilha_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1047, 681);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Title);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitor Visual";
            Load += Home_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private Button tempoReal;
        private Button Planilha;
    }
}
