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
            realTime = new Button();
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
            Title.Location = new Point(236, 23);
            Title.Name = "Title";
            Title.Size = new Size(405, 50);
            Title.TabIndex = 0;
            Title.Text = "Monitor de Fluxo visual";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(realTime, 1, 0);
            tableLayoutPanel1.Controls.Add(Planilha, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 90);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4074059F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5925941F));
            tableLayoutPanel1.Size = new Size(870, 321);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(455, 172);
            button3.Margin = new Padding(20);
            button3.Name = "button3";
            button3.Size = new Size(395, 129);
            button3.TabIndex = 3;
            button3.Text = "Configurações";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button2.Location = new Point(20, 172);
            button2.Margin = new Padding(20);
            button2.Name = "button2";
            button2.Size = new Size(395, 129);
            button2.TabIndex = 2;
            button2.Text = "Histórico de Medições";
            button2.UseVisualStyleBackColor = true;
            // 
            // realTime
            // 
            realTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            realTime.AutoSize = true;
            realTime.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            realTime.Location = new Point(455, 20);
            realTime.Margin = new Padding(20);
            realTime.Name = "realTime";
            realTime.Size = new Size(395, 112);
            realTime.TabIndex = 1;
            realTime.Text = "Medição Em Tempo Real";
            realTime.UseVisualStyleBackColor = true;
            // 
            // Planilha
            // 
            Planilha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Planilha.AutoSize = true;
            Planilha.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Planilha.Location = new Point(20, 20);
            Planilha.Margin = new Padding(20);
            Planilha.Name = "Planilha";
            Planilha.Size = new Size(395, 112);
            Planilha.TabIndex = 0;
            Planilha.Text = "Medição Com Planilha";
            Planilha.TextImageRelation = TextImageRelation.ImageBeforeText;
            Planilha.UseMnemonic = false;
            Planilha.UseVisualStyleBackColor = true;
            Planilha.Click += Planilha_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(916, 511);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Title);
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
        private Button realTime;
        private Button Planilha;
    }
}
