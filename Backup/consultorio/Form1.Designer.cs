namespace consultorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTSINT = new System.Windows.Forms.TextBox();
            this.CBXPAC = new System.Windows.Forms.ComboBox();
            this.PBXPAC = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTCEDULA = new System.Windows.Forms.TextBox();
            this.TXTESP = new System.Windows.Forms.TextBox();
            this.CBXDR = new System.Windows.Forms.ComboBox();
            this.PBXDR = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TXTN2 = new System.Windows.Forms.TextBox();
            this.TXTN1 = new System.Windows.Forms.TextBox();
            this.CBXM3 = new System.Windows.Forms.ComboBox();
            this.CBM2 = new System.Windows.Forms.ComboBox();
            this.CBXM1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LBXREC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMDREC = new System.Windows.Forms.Button();
            this.CMDLIM = new System.Windows.Forms.Button();
            this.CMDIMP = new System.Windows.Forms.Button();
            this.CMDSALIR = new System.Windows.Forms.Button();
            this.RBN7D = new System.Windows.Forms.RadioButton();
            this.RBN15D = new System.Windows.Forms.RadioButton();
            this.RBN1M = new System.Windows.Forms.RadioButton();
            this.RBN1A = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DTPHORA = new System.Windows.Forms.DateTimePicker();
            this.DTPCITA = new System.Windows.Forms.DateTimePicker();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPAC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXDR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.TXTSINT);
            this.groupBox1.Controls.Add(this.CBXPAC);
            this.groupBox1.Controls.Add(this.PBXPAC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PACIENTES";
            // 
            // TXTSINT
            // 
            this.TXTSINT.Enabled = false;
            this.TXTSINT.Location = new System.Drawing.Point(24, 137);
            this.TXTSINT.Multiline = true;
            this.TXTSINT.Name = "TXTSINT";
            this.TXTSINT.Size = new System.Drawing.Size(121, 97);
            this.TXTSINT.TabIndex = 5;
            // 
            // CBXPAC
            // 
            this.CBXPAC.FormattingEnabled = true;
            this.CBXPAC.Items.AddRange(new object[] {
            "Clara",
            "Ivan",
            "Janeth",
            "Ronaldo"});
            this.CBXPAC.Location = new System.Drawing.Point(24, 47);
            this.CBXPAC.Name = "CBXPAC";
            this.CBXPAC.Size = new System.Drawing.Size(121, 21);
            this.CBXPAC.TabIndex = 4;
            this.CBXPAC.SelectedIndexChanged += new System.EventHandler(this.CBXPAC_SelectedIndexChanged);
            // 
            // PBXPAC
            // 
            this.PBXPAC.Location = new System.Drawing.Point(162, 91);
            this.PBXPAC.Name = "PBXPAC";
            this.PBXPAC.Size = new System.Drawing.Size(100, 104);
            this.PBXPAC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXPAC.TabIndex = 3;
            this.PBXPAC.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "SINTOMAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FOTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TXTCEDULA);
            this.groupBox2.Controls.Add(this.TXTESP);
            this.groupBox2.Controls.Add(this.CBXDR);
            this.groupBox2.Controls.Add(this.PBXDR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(375, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 278);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MEDICO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "CEDULA";
            // 
            // TXTCEDULA
            // 
            this.TXTCEDULA.Location = new System.Drawing.Point(29, 175);
            this.TXTCEDULA.Name = "TXTCEDULA";
            this.TXTCEDULA.Size = new System.Drawing.Size(100, 20);
            this.TXTCEDULA.TabIndex = 6;
            // 
            // TXTESP
            // 
            this.TXTESP.Location = new System.Drawing.Point(29, 117);
            this.TXTESP.Name = "TXTESP";
            this.TXTESP.Size = new System.Drawing.Size(100, 20);
            this.TXTESP.TabIndex = 5;
            // 
            // CBXDR
            // 
            this.CBXDR.FormattingEnabled = true;
            this.CBXDR.Items.AddRange(new object[] {
            "Dr.Silva",
            "Dr.Rivas",
            "Dr.Salas"});
            this.CBXDR.Location = new System.Drawing.Point(6, 36);
            this.CBXDR.Name = "CBXDR";
            this.CBXDR.Size = new System.Drawing.Size(121, 21);
            this.CBXDR.TabIndex = 4;
            this.CBXDR.SelectedIndexChanged += new System.EventHandler(this.CBXDR_SelectedIndexChanged);
            // 
            // PBXDR
            // 
            this.PBXDR.Location = new System.Drawing.Point(140, 47);
            this.PBXDR.Name = "PBXDR";
            this.PBXDR.Size = new System.Drawing.Size(91, 101);
            this.PBXDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBXDR.TabIndex = 3;
            this.PBXDR.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ESPECIALIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doctor";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.TXTN2);
            this.groupBox3.Controls.Add(this.TXTN1);
            this.groupBox3.Controls.Add(this.CBXM3);
            this.groupBox3.Controls.Add(this.CBM2);
            this.groupBox3.Controls.Add(this.CBXM1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(44, 384);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 169);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MEDICAMENTOS";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(185, 100);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            // 
            // TXTN2
            // 
            this.TXTN2.Location = new System.Drawing.Point(185, 73);
            this.TXTN2.Name = "TXTN2";
            this.TXTN2.Size = new System.Drawing.Size(100, 20);
            this.TXTN2.TabIndex = 6;
            // 
            // TXTN1
            // 
            this.TXTN1.Location = new System.Drawing.Point(185, 46);
            this.TXTN1.Name = "TXTN1";
            this.TXTN1.Size = new System.Drawing.Size(100, 20);
            this.TXTN1.TabIndex = 5;
            // 
            // CBXM3
            // 
            this.CBXM3.FormattingEnabled = true;
            this.CBXM3.Items.AddRange(new object[] {
            "JARABE"});
            this.CBXM3.Location = new System.Drawing.Point(13, 100);
            this.CBXM3.Name = "CBXM3";
            this.CBXM3.Size = new System.Drawing.Size(121, 21);
            this.CBXM3.TabIndex = 4;
            // 
            // CBM2
            // 
            this.CBM2.FormattingEnabled = true;
            this.CBM2.Items.AddRange(new object[] {
            "OMEPRASOL"});
            this.CBM2.Location = new System.Drawing.Point(13, 73);
            this.CBM2.Name = "CBM2";
            this.CBM2.Size = new System.Drawing.Size(121, 21);
            this.CBM2.TabIndex = 3;
            // 
            // CBXM1
            // 
            this.CBXM1.FormattingEnabled = true;
            this.CBXM1.Items.AddRange(new object[] {
            "PARACETAMOL"});
            this.CBXM1.Location = new System.Drawing.Point(10, 46);
            this.CBXM1.Name = "CBXM1";
            this.CBXM1.Size = new System.Drawing.Size(121, 21);
            this.CBXM1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(182, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "PRECIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "NOMBRE ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.LBXREC);
            this.groupBox4.Location = new System.Drawing.Point(395, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 171);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RECETA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "DETALLE";
            // 
            // LBXREC
            // 
            this.LBXREC.FormattingEnabled = true;
            this.LBXREC.Location = new System.Drawing.Point(126, 60);
            this.LBXREC.Name = "LBXREC";
            this.LBXREC.Size = new System.Drawing.Size(120, 95);
            this.LBXREC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONSULTARIO MDIVO DPEQUEÑUA";
            // 
            // CMDREC
            // 
            this.CMDREC.Location = new System.Drawing.Point(747, 88);
            this.CMDREC.Name = "CMDREC";
            this.CMDREC.Size = new System.Drawing.Size(75, 23);
            this.CMDREC.TabIndex = 5;
            this.CMDREC.Text = "RECETA";
            this.CMDREC.UseVisualStyleBackColor = true;
            // 
            // CMDLIM
            // 
            this.CMDLIM.Location = new System.Drawing.Point(747, 149);
            this.CMDLIM.Name = "CMDLIM";
            this.CMDLIM.Size = new System.Drawing.Size(75, 23);
            this.CMDLIM.TabIndex = 6;
            this.CMDLIM.Text = "LIMPIAR";
            this.CMDLIM.UseVisualStyleBackColor = true;
            // 
            // CMDIMP
            // 
            this.CMDIMP.Location = new System.Drawing.Point(747, 205);
            this.CMDIMP.Name = "CMDIMP";
            this.CMDIMP.Size = new System.Drawing.Size(75, 23);
            this.CMDIMP.TabIndex = 7;
            this.CMDIMP.Text = "IMPRIMIR";
            this.CMDIMP.UseVisualStyleBackColor = true;
            // 
            // CMDSALIR
            // 
            this.CMDSALIR.Location = new System.Drawing.Point(747, 260);
            this.CMDSALIR.Name = "CMDSALIR";
            this.CMDSALIR.Size = new System.Drawing.Size(75, 23);
            this.CMDSALIR.TabIndex = 8;
            this.CMDSALIR.Text = "SALIR";
            this.CMDSALIR.UseVisualStyleBackColor = true;
            this.CMDSALIR.Click += new System.EventHandler(this.CMDSALIR_Click);
            // 
            // RBN7D
            // 
            this.RBN7D.AutoSize = true;
            this.RBN7D.Location = new System.Drawing.Point(22, 31);
            this.RBN7D.Name = "RBN7D";
            this.RBN7D.Size = new System.Drawing.Size(56, 17);
            this.RBN7D.TabIndex = 9;
            this.RBN7D.TabStop = true;
            this.RBN7D.Text = "7 dias ";
            this.RBN7D.UseVisualStyleBackColor = true;
            this.RBN7D.CheckedChanged += new System.EventHandler(this.RBN7D_CheckedChanged);
            // 
            // RBN15D
            // 
            this.RBN15D.AutoSize = true;
            this.RBN15D.Location = new System.Drawing.Point(135, 29);
            this.RBN15D.Name = "RBN15D";
            this.RBN15D.Size = new System.Drawing.Size(59, 17);
            this.RBN15D.TabIndex = 10;
            this.RBN15D.TabStop = true;
            this.RBN15D.Text = "15 dias";
            this.RBN15D.UseVisualStyleBackColor = true;
            this.RBN15D.CheckedChanged += new System.EventHandler(this.RBN15D_CheckedChanged);
            // 
            // RBN1M
            // 
            this.RBN1M.AutoSize = true;
            this.RBN1M.Location = new System.Drawing.Point(22, 120);
            this.RBN1M.Name = "RBN1M";
            this.RBN1M.Size = new System.Drawing.Size(56, 17);
            this.RBN1M.TabIndex = 11;
            this.RBN1M.TabStop = true;
            this.RBN1M.Text = "1 mes ";
            this.RBN1M.UseVisualStyleBackColor = true;
            this.RBN1M.CheckedChanged += new System.EventHandler(this.RBN1M_CheckedChanged);
            // 
            // RBN1A
            // 
            this.RBN1A.AutoSize = true;
            this.RBN1A.Location = new System.Drawing.Point(135, 120);
            this.RBN1A.Name = "RBN1A";
            this.RBN1A.Size = new System.Drawing.Size(52, 17);
            this.RBN1A.TabIndex = 12;
            this.RBN1A.TabStop = true;
            this.RBN1A.Text = "1 año";
            this.RBN1A.UseVisualStyleBackColor = true;
            this.RBN1A.CheckedChanged += new System.EventHandler(this.RBN1A_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.DTPHORA);
            this.groupBox5.Controls.Add(this.RBN7D);
            this.groupBox5.Controls.Add(this.DTPCITA);
            this.groupBox5.Controls.Add(this.RBN1A);
            this.groupBox5.Controls.Add(this.RBN15D);
            this.groupBox5.Controls.Add(this.RBN1M);
            this.groupBox5.Location = new System.Drawing.Point(848, 51);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 280);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Hora";
            // 
            // DTPHORA
            // 
            this.DTPHORA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPHORA.Location = new System.Drawing.Point(82, 241);
            this.DTPHORA.Name = "DTPHORA";
            this.DTPHORA.Size = new System.Drawing.Size(130, 20);
            this.DTPHORA.TabIndex = 15;
            // 
            // DTPCITA
            // 
            this.DTPCITA.Location = new System.Drawing.Point(23, 185);
            this.DTPCITA.Name = "DTPCITA";
            this.DTPCITA.Size = new System.Drawing.Size(200, 20);
            this.DTPCITA.TabIndex = 14;
            this.DTPCITA.ValueChanged += new System.EventHandler(this.DTPCITA_ValueChanged);
            // 
            // DTP1
            // 
            this.DTP1.Location = new System.Drawing.Point(556, 33);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(200, 20);
            this.DTP1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1132, 571);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.CMDSALIR);
            this.Controls.Add(this.CMDIMP);
            this.Controls.Add(this.CMDLIM);
            this.Controls.Add(this.CMDREC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXPAC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBXDR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBXPAC;
        private System.Windows.Forms.PictureBox PBXPAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PBXDR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTSINT;
        private System.Windows.Forms.TextBox TXTCEDULA;
        private System.Windows.Forms.TextBox TXTESP;
        private System.Windows.Forms.ComboBox CBXDR;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox TXTN2;
        private System.Windows.Forms.TextBox TXTN1;
        private System.Windows.Forms.ComboBox CBXM3;
        private System.Windows.Forms.ComboBox CBM2;
        private System.Windows.Forms.ComboBox CBXM1;
        private System.Windows.Forms.Button CMDREC;
        private System.Windows.Forms.Button CMDLIM;
        private System.Windows.Forms.Button CMDIMP;
        private System.Windows.Forms.Button CMDSALIR;
        private System.Windows.Forms.ListBox LBXREC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton RBN7D;
        private System.Windows.Forms.RadioButton RBN15D;
        private System.Windows.Forms.RadioButton RBN1M;
        private System.Windows.Forms.RadioButton RBN1A;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker DTPHORA;
        private System.Windows.Forms.DateTimePicker DTPCITA;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label label10;
    }
}

