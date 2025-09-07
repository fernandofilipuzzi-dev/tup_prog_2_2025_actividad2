namespace Actividad2
{
    partial class FormVerInicidentes
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
            button1 = new Button();
            tbIncidentes = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(205, 491);
            button1.Name = "button1";
            button1.Size = new Size(143, 47);
            button1.TabIndex = 1;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbIncidentes
            // 
            tbIncidentes.Location = new Point(4, 34);
            tbIncidentes.Multiline = true;
            tbIncidentes.Name = "tbIncidentes";
            tbIncidentes.Size = new Size(541, 451);
            tbIncidentes.TabIndex = 2;
            // 
            // FormVerInicidentes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 542);
            Controls.Add(tbIncidentes);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormVerInicidentes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lista de incidentes";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbIncidentes;
    }
}