namespace Examen2
{
    partial class frmSeleccion
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
            chkMonedaSelec = new CheckedListBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // chkMonedaSelec
            // 
            chkMonedaSelec.FormattingEnabled = true;
            chkMonedaSelec.Location = new Point(12, 12);
            chkMonedaSelec.Name = "chkMonedaSelec";
            chkMonedaSelec.Size = new Size(211, 130);
            chkMonedaSelec.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(148, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmSeleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 214);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(chkMonedaSelec);
            Name = "frmSeleccion";
            Text = "Seleccion Divisa";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox chkMonedaSelec;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}