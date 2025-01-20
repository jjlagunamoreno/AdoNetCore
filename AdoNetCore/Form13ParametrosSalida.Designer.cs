namespace AdoNetCore
{
    partial class Form13ParametrosSalida
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
            cmbDepartamentos = new ComboBox();
            txtMediaSalarial = new TextBox();
            txtPersonas = new TextBox();
            txtSumaSalarial = new TextBox();
            btnMostrarDatos = new Button();
            label1 = new Label();
            lblSumaSalarial = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(36, 65);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 0;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(36, 300);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(151, 27);
            txtMediaSalarial.TabIndex = 1;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(36, 382);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(151, 27);
            txtPersonas.TabIndex = 2;
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(36, 220);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(151, 27);
            txtSumaSalarial.TabIndex = 3;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(36, 130);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(151, 45);
            btnMostrarDatos.TabIndex = 4;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 5;
            label1.Text = "Departamentos";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(36, 197);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(99, 20);
            lblSumaSalarial.TabIndex = 6;
            lblSumaSalarial.Text = "Suma Salarial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 277);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 7;
            label3.Text = "Media Salarial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 359);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "Personas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 42);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(344, 65);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(341, 344);
            lstEmpleados.TabIndex = 10;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblSumaSalarial);
            Controls.Add(label1);
            Controls.Add(btnMostrarDatos);
            Controls.Add(txtSumaSalarial);
            Controls.Add(txtPersonas);
            Controls.Add(txtMediaSalarial);
            Controls.Add(cmbDepartamentos);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartamentos;
        private TextBox txtMediaSalarial;
        private TextBox txtPersonas;
        private TextBox txtSumaSalarial;
        private Button btnMostrarDatos;
        private Label label1;
        private Label lblSumaSalarial;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstEmpleados;
    }
}