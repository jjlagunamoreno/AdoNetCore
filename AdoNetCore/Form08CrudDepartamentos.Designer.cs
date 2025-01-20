namespace AdoNetCore
{
    partial class Form08CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            SuspendLayout();
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(27, 63);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(384, 364);
            lstDepartamentos.TabIndex = 0;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(476, 266);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(282, 44);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(476, 327);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(282, 44);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(476, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(282, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 4;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 63);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 127);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(476, 192);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "Localidad";
            // 
            // txtId
            // 
            txtId.Location = new Point(578, 60);
            txtId.Name = "txtId";
            txtId.Size = new Size(180, 27);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(578, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 27);
            txtNombre.TabIndex = 9;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(578, 189);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(180, 27);
            txtLocalidad.TabIndex = 10;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lstDepartamentos);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDepartamentos;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
    }
}