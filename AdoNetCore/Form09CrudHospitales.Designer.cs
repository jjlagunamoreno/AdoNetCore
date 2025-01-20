namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtHospitalesCod = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnInsertar = new Button();
            lstHospitales = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(563, 173);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(180, 27);
            txtDireccion.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(563, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 27);
            txtNombre.TabIndex = 19;
            // 
            // txtHospitalesCod
            // 
            txtHospitalesCod.Location = new Point(563, 44);
            txtHospitalesCod.Name = "txtHospitalesCod";
            txtHospitalesCod.Size = new Size(180, 27);
            txtHospitalesCod.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 176);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 111);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 47);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(461, 367);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(282, 44);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(461, 311);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(282, 44);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(461, 250);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(282, 44);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(12, 47);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(384, 364);
            lstHospitales.TabIndex = 11;
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 428);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtHospitalesCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtHospitalesCod;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnInsertar;
        private ListBox lstHospitales;
    }
}