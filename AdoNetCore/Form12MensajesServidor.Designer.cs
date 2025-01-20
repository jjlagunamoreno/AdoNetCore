namespace AdoNetCore
{
    partial class Form12MensajesServidor
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
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtLocalidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnInsertar = new Button();
            lblMensaje = new Label();
            lstDepartamentos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(36, 71);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 134);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(36, 276);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(195, 27);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 235);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 30);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(36, 337);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(195, 29);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = SystemColors.MenuHighlight;
            lblMensaje.Location = new Point(36, 398);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(84, 20);
            lblMensaje.TabIndex = 8;
            lblMensaje.Text = "lblMensaje";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(328, 71);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(418, 244);
            lstDepartamentos.TabIndex = 9;
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDepartamentos);
            Controls.Add(lblMensaje);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLocalidad;
        private Label label3;
        private Label label4;
        private Button btnInsertar;
        private Label lblMensaje;
        private ListBox lstDepartamentos;
    }
}