namespace AdoNetCore
{
    partial class Form07DepartamentosEmpleados
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
            btnEliminar = new Button();
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 29);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(442, 56);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 41);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(24, 61);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(150, 104);
            lstDepartamentos.TabIndex = 3;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(226, 61);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(150, 204);
            lstEmpleados.TabIndex = 4;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 289);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEliminar;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
    }
}