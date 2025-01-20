namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            lstSalas = new ListBox();
            btnModificarSalas = new Button();
            txtSala = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 103);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Nueva Sala";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(31, 73);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(307, 244);
            lstSalas.TabIndex = 2;
            // 
            // btnModificarSalas
            // 
            btnModificarSalas.Location = new Point(410, 190);
            btnModificarSalas.Name = "btnModificarSalas";
            btnModificarSalas.Size = new Size(198, 41);
            btnModificarSalas.TabIndex = 3;
            btnModificarSalas.Text = "Modificar Salas";
            btnModificarSalas.UseVisualStyleBackColor = true;
            btnModificarSalas.Click += btnModificarSalas_Click;
            // 
            // txtSala
            // 
            txtSala.Location = new Point(410, 139);
            txtSala.Name = "txtSala";
            txtSala.Size = new Size(198, 27);
            txtSala.TabIndex = 4;
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 349);
            Controls.Add(txtSala);
            Controls.Add(btnModificarSalas);
            Controls.Add(lstSalas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lstSalas;
        private Button btnModificarSalas;
        private TextBox txtSala;
    }
}