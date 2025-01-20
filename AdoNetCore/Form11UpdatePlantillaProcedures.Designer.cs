namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            btnModificarSalarios = new Button();
            cmbHospitales = new ComboBox();
            txtIncremento = new TextBox();
            lstPlantilla = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 36);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // btnModificarSalarios
            // 
            btnModificarSalarios.Location = new Point(292, 129);
            btnModificarSalarios.Name = "btnModificarSalarios";
            btnModificarSalarios.Size = new Size(174, 43);
            btnModificarSalarios.TabIndex = 3;
            btnModificarSalarios.Text = "Modificar Salarios";
            btnModificarSalarios.UseVisualStyleBackColor = true;
            btnModificarSalarios.Click += btnModificarSalarios_Click;
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(62, 72);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(203, 28);
            cmbHospitales.TabIndex = 4;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(492, 76);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(197, 27);
            txtIncremento.TabIndex = 5;
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(62, 234);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(680, 204);
            lstPlantilla.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 197);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Plantilla";
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lstPlantilla);
            Controls.Add(txtIncremento);
            Controls.Add(cmbHospitales);
            Controls.Add(btnModificarSalarios);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnModificarSalarios;
        private ComboBox cmbHospitales;
        private TextBox txtIncremento;
        private ListBox lstPlantilla;
        private Label label3;
    }
}