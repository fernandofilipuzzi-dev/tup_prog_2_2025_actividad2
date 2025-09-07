namespace Actividad2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnAltaComisaria = new Button();
            btnCerrar = new Button();
            btnListrarIncidentes = new Button();
            groupBox1 = new GroupBox();
            gbAdministracion = new GroupBox();
            groupBox5 = new GroupBox();
            label9 = new Label();
            cbxIncidente = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            label5 = new Label();
            tbMotivo = new TextBox();
            btnRegistrarIncidente = new Button();
            label6 = new Label();
            nupMIncidente = new NumericUpDown();
            nupHIncidente = new NumericUpDown();
            groupBox3 = new GroupBox();
            nupNumeroGuardia = new NumericUpDown();
            label4 = new Label();
            label2 = new Label();
            btnAginacionGuardias = new Button();
            nupMDuracion = new NumericUpDown();
            label3 = new Label();
            nupHGuardiaDesde = new NumericUpDown();
            nupMGuardiaDesde = new NumericUpDown();
            label1 = new Label();
            cmbNumeroPlaca = new ComboBox();
            groupBox1.SuspendLayout();
            gbAdministracion.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupMIncidente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupHIncidente).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumeroGuardia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupHGuardiaDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupMGuardiaDesde).BeginInit();
            SuspendLayout();
            // 
            // btnAltaComisaria
            // 
            btnAltaComisaria.Location = new Point(359, 25);
            btnAltaComisaria.Margin = new Padding(4, 5, 4, 5);
            btnAltaComisaria.Name = "btnAltaComisaria";
            btnAltaComisaria.Size = new Size(132, 52);
            btnAltaComisaria.TabIndex = 0;
            btnAltaComisaria.Text = "Creación comisaría(1)";
            btnAltaComisaria.UseVisualStyleBackColor = true;
            btnAltaComisaria.Click += btnAltaComisaria_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(264, 566);
            btnCerrar.Margin = new Padding(4, 5, 4, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(133, 52);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnListrarIncidentes
            // 
            btnListrarIncidentes.Enabled = false;
            btnListrarIncidentes.Location = new Point(499, 25);
            btnListrarIncidentes.Margin = new Padding(4, 5, 4, 5);
            btnListrarIncidentes.Name = "btnListrarIncidentes";
            btnListrarIncidentes.Size = new Size(132, 52);
            btnListrarIncidentes.TabIndex = 1;
            btnListrarIncidentes.Text = "Listar incidentes(4)";
            btnListrarIncidentes.UseVisualStyleBackColor = true;
            btnListrarIncidentes.Click += btnListrarIncidentes_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAltaComisaria);
            groupBox1.Controls.Add(btnListrarIncidentes);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(650, 85);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administracion comisaría";
            // 
            // gbAdministracion
            // 
            gbAdministracion.Controls.Add(groupBox5);
            gbAdministracion.Controls.Add(groupBox3);
            gbAdministracion.Controls.Add(label1);
            gbAdministracion.Controls.Add(cmbNumeroPlaca);
            gbAdministracion.Enabled = false;
            gbAdministracion.Location = new Point(12, 103);
            gbAdministracion.Name = "gbAdministracion";
            gbAdministracion.Size = new Size(650, 455);
            gbAdministracion.TabIndex = 8;
            gbAdministracion.TabStop = false;
            gbAdministracion.Text = "Operaciones sobre el agente";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(cbxIncidente);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(tbNombre);
            groupBox5.Controls.Add(tbDNI);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(tbMotivo);
            groupBox5.Controls.Add(btnRegistrarIncidente);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(nupMIncidente);
            groupBox5.Controls.Add(nupHIncidente);
            groupBox5.Location = new Point(21, 212);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(612, 233);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Administración de incidentes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 30);
            label9.Name = "label9";
            label9.Size = new Size(109, 20);
            label9.TabIndex = 18;
            label9.Text = "Tipo Incidente";
            // 
            // cbxIncidente
            // 
            cbxIncidente.FormattingEnabled = true;
            cbxIncidente.Items.AddRange(new object[] { "Denuncia", "Arresto" });
            cbxIncidente.Location = new Point(157, 27);
            cbxIncidente.Name = "cbxIncidente";
            cbxIncidente.Size = new Size(121, 28);
            cbxIncidente.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(321, 113);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 16;
            label8.Text = "DNI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 116);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 15;
            label7.Text = "Persona";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(157, 110);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(158, 26);
            tbNombre.TabIndex = 8;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(364, 110);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(96, 26);
            tbDNI.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 164);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Motivo:";
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(157, 145);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(303, 66);
            tbMotivo.TabIndex = 10;
            // 
            // btnRegistrarIncidente
            // 
            btnRegistrarIncidente.Location = new Point(478, 160);
            btnRegistrarIncidente.Margin = new Padding(4, 5, 4, 5);
            btnRegistrarIncidente.Name = "btnRegistrarIncidente";
            btnRegistrarIncidente.Size = new Size(106, 51);
            btnRegistrarIncidente.TabIndex = 11;
            btnRegistrarIncidente.Text = "Registrar Indicente(3)";
            btnRegistrarIncidente.UseVisualStyleBackColor = true;
            btnRegistrarIncidente.Click += btnRegistrarIncidente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 74);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 9;
            label6.Text = "Hora";
            // 
            // nupMIncidente
            // 
            nupMIncidente.Location = new Point(231, 72);
            nupMIncidente.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nupMIncidente.Name = "nupMIncidente";
            nupMIncidente.Size = new Size(59, 26);
            nupMIncidente.TabIndex = 7;
            // 
            // nupHIncidente
            // 
            nupHIncidente.Location = new Point(157, 72);
            nupHIncidente.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nupHIncidente.Name = "nupHIncidente";
            nupHIncidente.Size = new Size(62, 26);
            nupHIncidente.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nupNumeroGuardia);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnAginacionGuardias);
            groupBox3.Controls.Add(nupMDuracion);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(nupHGuardiaDesde);
            groupBox3.Controls.Add(nupMGuardiaDesde);
            groupBox3.Location = new Point(21, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(612, 132);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Administración de guardias";
            // 
            // nupNumeroGuardia
            // 
            nupNumeroGuardia.Location = new Point(157, 25);
            nupNumeroGuardia.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nupNumeroGuardia.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            nupNumeroGuardia.Name = "nupNumeroGuardia";
            nupNumeroGuardia.Size = new Size(133, 26);
            nupNumeroGuardia.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 91);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 10;
            label4.Text = "Duracion en M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 27);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 6;
            label2.Text = "Nro Guardia";
            // 
            // btnAginacionGuardias
            // 
            btnAginacionGuardias.Location = new Point(452, 43);
            btnAginacionGuardias.Margin = new Padding(4, 5, 4, 5);
            btnAginacionGuardias.Name = "btnAginacionGuardias";
            btnAginacionGuardias.Size = new Size(132, 52);
            btnAginacionGuardias.TabIndex = 5;
            btnAginacionGuardias.Text = "Asignación de las guardias(2)";
            btnAginacionGuardias.UseVisualStyleBackColor = true;
            btnAginacionGuardias.Click += btnAsignarGuardias_Click;
            // 
            // nupMDuracion
            // 
            nupMDuracion.Location = new Point(157, 91);
            nupMDuracion.Maximum = new decimal(new int[] { 1200, 0, 0, 0 });
            nupMDuracion.Name = "nupMDuracion";
            nupMDuracion.Size = new Size(133, 26);
            nupMDuracion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 57);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 9;
            label3.Text = "Desde";
            // 
            // nupHGuardiaDesde
            // 
            nupHGuardiaDesde.Location = new Point(157, 57);
            nupHGuardiaDesde.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            nupHGuardiaDesde.Name = "nupHGuardiaDesde";
            nupHGuardiaDesde.Size = new Size(62, 26);
            nupHGuardiaDesde.TabIndex = 2;
            // 
            // nupMGuardiaDesde
            // 
            nupMGuardiaDesde.Location = new Point(231, 57);
            nupMGuardiaDesde.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nupMGuardiaDesde.Name = "nupMGuardiaDesde";
            nupMGuardiaDesde.Size = new Size(59, 26);
            nupMGuardiaDesde.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 5;
            label1.Text = "Placa de Agente";
            // 
            // cmbNumeroPlaca
            // 
            cmbNumeroPlaca.FormattingEnabled = true;
            cmbNumeroPlaca.Location = new Point(149, 27);
            cmbNumeroPlaca.Name = "cmbNumeroPlaca";
            cmbNumeroPlaca.Size = new Size(133, 28);
            cmbNumeroPlaca.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 631);
            Controls.Add(gbAdministracion);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actividad 2 - \"Ana es policia!\"";
            groupBox1.ResumeLayout(false);
            gbAdministracion.ResumeLayout(false);
            gbAdministracion.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupMIncidente).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupHIncidente).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNumeroGuardia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupHGuardiaDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupMGuardiaDesde).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaComisaria;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListrarIncidentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAdministracion;
        private System.Windows.Forms.Button btnAginacionGuardias;
        private System.Windows.Forms.ComboBox cmbNumeroPlaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNumeroGuardia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupMGuardiaDesde;
        private System.Windows.Forms.NumericUpDown nupMDuracion;
        private System.Windows.Forms.NumericUpDown nupHGuardiaDesde;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMotivo;
        private System.Windows.Forms.Button btnRegistrarIncidente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupMIncidente;
        private System.Windows.Forms.NumericUpDown nupHIncidente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxIncidente;
    }
}

