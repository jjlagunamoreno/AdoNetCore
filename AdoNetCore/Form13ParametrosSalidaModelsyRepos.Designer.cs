namespace AdoNetCore
{
    partial class Form13ParametrosSalidaModelsyRepos
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
            lstEmpleados = new ListBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblSumaSalarial = new Label();
            label1 = new Label();
            btnMostrarDatos = new Button();
            txtSumaSalarial = new TextBox();
            txtPersonas = new TextBox();
            txtMediaSalarial = new TextBox();
            cmbDepartamentos = new ComboBox();
            SuspendLayout();
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(384, 65);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(341, 344);
            lstEmpleados.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 42);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 20;
            label5.Text = "Empleados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 359);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 19;
            label4.Text = "Personas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 277);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 18;
            label3.Text = "Media Salarial";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(76, 197);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(99, 20);
            lblSumaSalarial.TabIndex = 17;
            lblSumaSalarial.Text = "Suma Salarial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 16;
            label1.Text = "Departamentos";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(76, 130);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(151, 45);
            btnMostrarDatos.TabIndex = 15;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(76, 220);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(151, 27);
            txtSumaSalarial.TabIndex = 14;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(76, 382);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(151, 27);
            txtPersonas.TabIndex = 13;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(76, 300);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(151, 27);
            txtMediaSalarial.TabIndex = 12;
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(76, 65);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(151, 28);
            cmbDepartamentos.TabIndex = 11;
            // 
            // Form13ParametrosSalidaModelsyRepos
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
            Name = "Form13ParametrosSalidaModelsyRepos";
            Text = "Form13ParametrosSalidaModelsyRepos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstEmpleados;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblSumaSalarial;
        private Label label1;
        private Button btnMostrarDatos;
        private TextBox txtSumaSalarial;
        private TextBox txtPersonas;
        private TextBox txtMediaSalarial;
        private ComboBox cmbDepartamentos;
    }
}