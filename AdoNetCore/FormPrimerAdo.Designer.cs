namespace AdoNetCore
{
    partial class FormPrimerAdo
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
            btnConectar = new Button();
            btnDesconectar = new Button();
            btnLeerDatos = new Button();
            txtApellidos = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            txtColumnas = new Label();
            lstTiposDato = new ListBox();
            txtTiposDato = new Label();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(33, 31);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(181, 54);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(33, 111);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(181, 54);
            btnDesconectar.TabIndex = 1;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnLeerDatos
            // 
            btnLeerDatos.Location = new Point(33, 201);
            btnLeerDatos.Name = "btnLeerDatos";
            btnLeerDatos.Size = new Size(181, 54);
            btnLeerDatos.TabIndex = 2;
            btnLeerDatos.Text = "Leer Datos";
            btnLeerDatos.UseVisualStyleBackColor = true;
            btnLeerDatos.Click += btnLeerDatos_Click;
            // 
            // txtApellidos
            // 
            txtApellidos.AutoSize = true;
            txtApellidos.Location = new Point(260, 28);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(72, 20);
            txtApellidos.TabIndex = 3;
            txtApellidos.Text = "Apellidos";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(260, 51);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(182, 204);
            lstApellidos.TabIndex = 4;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(486, 51);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(182, 204);
            lstColumnas.TabIndex = 6;
            // 
            // txtColumnas
            // 
            txtColumnas.AutoSize = true;
            txtColumnas.Location = new Point(486, 28);
            txtColumnas.Name = "txtColumnas";
            txtColumnas.Size = new Size(74, 20);
            txtColumnas.TabIndex = 5;
            txtColumnas.Text = "Columnas";
            // 
            // lstTiposDato
            // 
            lstTiposDato.FormattingEnabled = true;
            lstTiposDato.Location = new Point(702, 51);
            lstTiposDato.Name = "lstTiposDato";
            lstTiposDato.Size = new Size(182, 204);
            lstTiposDato.TabIndex = 8;
            // 
            // txtTiposDato
            // 
            txtTiposDato.AutoSize = true;
            txtTiposDato.Location = new Point(702, 28);
            txtTiposDato.Name = "txtTiposDato";
            txtTiposDato.Size = new Size(82, 20);
            txtTiposDato.TabIndex = 7;
            txtTiposDato.Text = "Tipos Dato";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(33, 287);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(81, 20);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // FormPrimerAdo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 351);
            Controls.Add(lblMensaje);
            Controls.Add(lstTiposDato);
            Controls.Add(txtTiposDato);
            Controls.Add(lstColumnas);
            Controls.Add(txtColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(txtApellidos);
            Controls.Add(btnLeerDatos);
            Controls.Add(btnDesconectar);
            Controls.Add(btnConectar);
            Name = "FormPrimerAdo";
            Text = "FormPrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnDesconectar;
        private Button btnLeerDatos;
        private Label txtApellidos;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private Label txtColumnas;
        private ListBox lstTiposDato;
        private Label txtTiposDato;
        private Label lblMensaje;
    }
}