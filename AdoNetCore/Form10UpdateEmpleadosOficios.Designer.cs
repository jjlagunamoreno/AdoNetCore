namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            Incremento = new Label();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalarial = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            btnIncrementarSalarios = new Button();
            txtIncremento = new TextBox();
            txtOficio = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Oficios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 19);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // Incremento
            // 
            Incremento.AutoSize = true;
            Incremento.Location = new Point(451, 128);
            Incremento.Name = "Incremento";
            Incremento.Size = new Size(84, 20);
            Incremento.TabIndex = 2;
            Incremento.Text = "Incremento";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(19, 199);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(112, 20);
            lblSumaSalarial.TabIndex = 3;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(19, 245);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(117, 20);
            lblMediaSalarial.TabIndex = 4;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalarial
            // 
            lblMaximoSalarial.AutoSize = true;
            lblMaximoSalarial.Location = new Point(19, 288);
            lblMaximoSalarial.Name = "lblMaximoSalarial";
            lblMaximoSalarial.Size = new Size(129, 20);
            lblMaximoSalarial.TabIndex = 5;
            lblMaximoSalarial.Text = "lblMaximoSalarial";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(19, 53);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(150, 104);
            lstOficios.TabIndex = 6;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(239, 53);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(150, 164);
            lstEmpleados.TabIndex = 7;
            
            // 
            // btnIncrementarSalarios
            // 
            btnIncrementarSalarios.Location = new Point(451, 215);
            btnIncrementarSalarios.Name = "btnIncrementarSalarios";
            btnIncrementarSalarios.Size = new Size(186, 55);
            btnIncrementarSalarios.TabIndex = 8;
            btnIncrementarSalarios.Text = "Incrementar Salarios";
            btnIncrementarSalarios.UseVisualStyleBackColor = true;
            btnIncrementarSalarios.Click += btnIncrementarSalarios_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(451, 168);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(186, 27);
            txtIncremento.TabIndex = 9;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(451, 59);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(186, 27);
            txtOficio.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 10;
            label3.Text = "Oficio";
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 333);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(txtIncremento);
            Controls.Add(btnIncrementarSalarios);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(lblMaximoSalarial);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(Incremento);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Incremento;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalarial;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private Button btnIncrementarSalarios;
        private TextBox txtIncremento;
        private TextBox txtOficio;
        private Label label3;
    }
}