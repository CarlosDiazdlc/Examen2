namespace Examen2
{
    partial class Form1
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
            cmbMoneda = new ComboBox();
            txtMonto = new TextBox();
            lblMoneda = new Label();
            lblMonto = new Label();
            btnCalcular = new Button();
            grbConversiones = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUSD = new Label();
            lblMXN = new Label();
            lblCAD = new Label();
            lblEUR = new Label();
            lblYen = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            grbConversiones.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMoneda
            // 
            cmbMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMoneda.FormattingEnabled = true;
            cmbMoneda.Location = new Point(12, 27);
            cmbMoneda.Name = "cmbMoneda";
            cmbMoneda.Size = new Size(150, 23);
            cmbMoneda.TabIndex = 0;
            cmbMoneda.SelectedIndexChanged += cmbMoneda_SelectedIndexChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(212, 27);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 1;
            // 
            // lblMoneda
            // 
            lblMoneda.AutoSize = true;
            lblMoneda.Location = new Point(12, 9);
            lblMoneda.Name = "lblMoneda";
            lblMoneda.Size = new Size(51, 15);
            lblMoneda.TabIndex = 2;
            lblMoneda.Text = "Moneda";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(214, 8);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(237, 56);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // grbConversiones
            // 
            grbConversiones.Controls.Add(tableLayoutPanel1);
            grbConversiones.Location = new Point(12, 92);
            grbConversiones.Name = "grbConversiones";
            grbConversiones.Size = new Size(300, 175);
            grbConversiones.TabIndex = 5;
            grbConversiones.TabStop = false;
            grbConversiones.Text = "Conversiones";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblUSD, 0, 0);
            tableLayoutPanel1.Controls.Add(lblMXN, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCAD, 0, 2);
            tableLayoutPanel1.Controls.Add(lblEUR, 0, 3);
            tableLayoutPanel1.Controls.Add(lblYen, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(288, 147);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // lblUSD
            // 
            lblUSD.AutoSize = true;
            lblUSD.Dock = DockStyle.Fill;
            lblUSD.Location = new Point(3, 0);
            lblUSD.Name = "lblUSD";
            lblUSD.Size = new Size(138, 29);
            lblUSD.TabIndex = 0;
            lblUSD.Text = "USD - Dólar estadounidense";
            lblUSD.TextAlign = ContentAlignment.MiddleCenter;
            lblUSD.Paint += lblUSD_Paint;
            // 
            // lblMXN
            // 
            lblMXN.Dock = DockStyle.Fill;
            lblMXN.Location = new Point(3, 29);
            lblMXN.Name = "lblMXN";
            lblMXN.Size = new Size(138, 29);
            lblMXN.TabIndex = 1;
            lblMXN.Text = "MXN - Peso mexicano";
            lblMXN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCAD
            // 
            lblCAD.Dock = DockStyle.Fill;
            lblCAD.Location = new Point(3, 58);
            lblCAD.Name = "lblCAD";
            lblCAD.Size = new Size(138, 29);
            lblCAD.TabIndex = 2;
            lblCAD.Text = "CAD - Dólar Canadiense";
            // 
            // lblEUR
            // 
            lblEUR.Dock = DockStyle.Fill;
            lblEUR.Location = new Point(3, 87);
            lblEUR.Name = "lblEUR";
            lblEUR.Size = new Size(138, 29);
            lblEUR.TabIndex = 3;
            lblEUR.Text = "EUR - Euro ";
            lblEUR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYen
            // 
            lblYen.Dock = DockStyle.Fill;
            lblYen.Location = new Point(3, 116);
            lblYen.Name = "lblYen";
            lblYen.Size = new Size(138, 31);
            lblYen.TabIndex = 4;
            lblYen.Text = "Yen japonés";
            lblYen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(147, 119);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 273);
            Controls.Add(grbConversiones);
            Controls.Add(btnCalcular);
            Controls.Add(lblMonto);
            Controls.Add(lblMoneda);
            Controls.Add(txtMonto);
            Controls.Add(cmbMoneda);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbConversiones.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMoneda;
        private TextBox txtMonto;
        private Label lblMoneda;
        private Label lblMonto;
        private Button btnCalcular;
        private GroupBox grbConversiones;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUSD;
        private Label lblMXN;
        private Label lblCAD;
        private Label lblEUR;
        private Label lblYen;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
