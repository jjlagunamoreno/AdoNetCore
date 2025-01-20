namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            txtNuevaSala = new TextBox();
            btnModificarSalas = new Button();
            lstSalas = new ListBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(491, 188);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(198, 27);
            txtNuevaSala.TabIndex = 9;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(491, 239);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(198, 41);
            btnModificarSalas.TabIndex = 8;
            btnModificarSalas.Text = "Modificar Salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(112, 122);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(307, 244);
            lstSalas.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 152);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Nueva Sala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 84);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 5;
            label1.Text = "Salas Clases";
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaSala);
            Controls.Add(btnModificarSalas);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNuevaSala;
        private Button btnModificarSalas;
        private ListBox lstSalas;
        private Label label2;
        private Label label1;
    }
}