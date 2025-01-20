namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            label2 = new Label();
            btnBuscarEmpleados = new Button();
            txtSalario = new TextBox();
            lstEmpleados = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            btnBuscarOficio = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 31);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca salario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 198);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.Location = new Point(67, 112);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(224, 46);
            btnBuscarEmpleados.TabIndex = 2;
            btnBuscarEmpleados.Text = "Buscar empleados";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(65, 69);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(226, 27);
            txtSalario.TabIndex = 3;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(41, 230);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(351, 244);
            lstEmpleados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 31);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 5;
            label3.Text = "Introduzca Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(350, 69);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(226, 27);
            txtOficio.TabIndex = 6;
            // 
            // btnBuscarOficio
            // 
            btnBuscarOficio.Location = new Point(350, 112);
            btnBuscarOficio.Name = "btnBuscarOficio";
            btnBuscarOficio.Size = new Size(224, 46);
            btnBuscarOficio.TabIndex = 7;
            btnBuscarOficio.Text = "Buscar por Oficio";
            btnBuscarOficio.UseVisualStyleBackColor = true;
            btnBuscarOficio.Click += btnBuscarOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 502);
            Controls.Add(btnBuscarOficio);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(lstEmpleados);
            Controls.Add(txtSalario);
            Controls.Add(btnBuscarEmpleados);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnBuscarEmpleados;
        private TextBox txtSalario;
        private ListBox lstEmpleados;
        private Label label3;
        private TextBox txtOficio;
        private Button btnBuscarOficio;
    }
}