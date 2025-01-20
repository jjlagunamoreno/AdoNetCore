namespace AdoNetCore
{
    partial class Form04EliminarPlantilla
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
            txtPlantilla = new TextBox();
            btnEliminarPlantilla = new Button();
            label2 = new Label();
            lstPlantillas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Plantilla";
            // 
            // txtPlantilla
            // 
            txtPlantilla.Location = new Point(34, 73);
            txtPlantilla.Name = "txtPlantilla";
            txtPlantilla.Size = new Size(166, 27);
            txtPlantilla.TabIndex = 1;
            // 
            // btnEliminarPlantilla
            // 
            btnEliminarPlantilla.Location = new Point(37, 126);
            btnEliminarPlantilla.Name = "btnEliminarPlantilla";
            btnEliminarPlantilla.Size = new Size(163, 29);
            btnEliminarPlantilla.TabIndex = 2;
            btnEliminarPlantilla.Text = "Eliminar Plantilla";
            btnEliminarPlantilla.UseVisualStyleBackColor = true;
            btnEliminarPlantilla.Click += btnEliminarPlantilla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Plantillas";
            // 
            // lstPlantillas
            // 
            lstPlantillas.FormattingEnabled = true;
            lstPlantillas.Location = new Point(404, 73);
            lstPlantillas.Name = "lstPlantillas";
            lstPlantillas.Size = new Size(312, 244);
            lstPlantillas.TabIndex = 4;
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 335);
            Controls.Add(lstPlantillas);
            Controls.Add(label2);
            Controls.Add(btnEliminarPlantilla);
            Controls.Add(txtPlantilla);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlantilla;
        private Button btnEliminarPlantilla;
        private Label label2;
        private ListBox lstPlantillas;
    }
}