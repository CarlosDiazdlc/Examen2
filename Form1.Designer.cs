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
            pnlConversiones = new Panel();
            grbConversiones.SuspendLayout();
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
            grbConversiones.Controls.Add(pnlConversiones);
            grbConversiones.Location = new Point(12, 92);
            grbConversiones.Name = "grbConversiones";
            grbConversiones.Size = new Size(300, 175);
            grbConversiones.TabIndex = 5;
            grbConversiones.TabStop = false;
            grbConversiones.Text = "Conversiones";
            // 
            // pnlConversiones
            // 
            pnlConversiones.AutoScroll = true;
            pnlConversiones.Location = new Point(6, 22);
            pnlConversiones.Name = "pnlConversiones";
            pnlConversiones.Size = new Size(288, 147);
            pnlConversiones.TabIndex = 0;
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
        private Panel pnlConversiones;
    }
}
