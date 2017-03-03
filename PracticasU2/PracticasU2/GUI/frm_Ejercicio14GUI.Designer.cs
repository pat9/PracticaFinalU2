namespace PracticasU2.GUI
{
    partial class frm_Ejercicio14GUI
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
            this.grb_Alumno = new System.Windows.Forms.GroupBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.rtb_Info = new System.Windows.Forms.RichTextBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Movil = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_ApePat = new System.Windows.Forms.TextBox();
            this.lbl_ApePat = new System.Windows.Forms.Label();
            this.lbl_NumeroFijo = new System.Windows.Forms.Label();
            this.txt_Barrio = new System.Windows.Forms.TextBox();
            this.dtp_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.lbl_Barrio = new System.Windows.Forms.Label();
            this.lbl_Nacimiento = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.rbt_Mujer = new System.Windows.Forms.RadioButton();
            this.rbt_Hombre = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ApeMat = new System.Windows.Forms.TextBox();
            this.lbl_ApeMat = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.dgt_Alumnos = new System.Windows.Forms.DataGridView();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApePat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApeMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoMovil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoFIjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_Fijo = new System.Windows.Forms.MaskedTextBox();
            this.txt_Movil = new System.Windows.Forms.MaskedTextBox();
            this.grb_Alumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Alumno
            // 
            this.grb_Alumno.Controls.Add(this.txt_Movil);
            this.grb_Alumno.Controls.Add(this.txt_Fijo);
            this.grb_Alumno.Controls.Add(this.txt_Matricula);
            this.grb_Alumno.Controls.Add(this.btn_Nuevo);
            this.grb_Alumno.Controls.Add(this.btn_Eliminar);
            this.grb_Alumno.Controls.Add(this.btn_Agregar);
            this.grb_Alumno.Controls.Add(this.rtb_Info);
            this.grb_Alumno.Controls.Add(this.lbl_Info);
            this.grb_Alumno.Controls.Add(this.txt_mail);
            this.grb_Alumno.Controls.Add(this.lbl_mail);
            this.grb_Alumno.Controls.Add(this.txt_Direccion);
            this.grb_Alumno.Controls.Add(this.lbl_Movil);
            this.grb_Alumno.Controls.Add(this.lbl_Direccion);
            this.grb_Alumno.Controls.Add(this.txt_ApePat);
            this.grb_Alumno.Controls.Add(this.lbl_ApePat);
            this.grb_Alumno.Controls.Add(this.lbl_NumeroFijo);
            this.grb_Alumno.Controls.Add(this.txt_Barrio);
            this.grb_Alumno.Controls.Add(this.dtp_FechaNac);
            this.grb_Alumno.Controls.Add(this.lbl_Barrio);
            this.grb_Alumno.Controls.Add(this.lbl_Nacimiento);
            this.grb_Alumno.Controls.Add(this.txt_Nombres);
            this.grb_Alumno.Controls.Add(this.lbl_Nombres);
            this.grb_Alumno.Controls.Add(this.rbt_Mujer);
            this.grb_Alumno.Controls.Add(this.rbt_Hombre);
            this.grb_Alumno.Controls.Add(this.label1);
            this.grb_Alumno.Controls.Add(this.txt_ApeMat);
            this.grb_Alumno.Controls.Add(this.lbl_ApeMat);
            this.grb_Alumno.Controls.Add(this.lbl_Matricula);
            this.grb_Alumno.Location = new System.Drawing.Point(13, 13);
            this.grb_Alumno.Name = "grb_Alumno";
            this.grb_Alumno.Size = new System.Drawing.Size(695, 271);
            this.grb_Alumno.TabIndex = 0;
            this.grb_Alumno.TabStop = false;
            this.grb_Alumno.Text = "Ficha Alumno";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(29, 158);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(204, 28);
            this.btn_Nuevo.TabIndex = 31;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(29, 226);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(204, 28);
            this.btn_Eliminar.TabIndex = 30;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(29, 192);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(204, 28);
            this.btn_Agregar.TabIndex = 29;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // rtb_Info
            // 
            this.rtb_Info.Location = new System.Drawing.Point(271, 158);
            this.rtb_Info.Name = "rtb_Info";
            this.rtb_Info.Size = new System.Drawing.Size(418, 107);
            this.rtb_Info.TabIndex = 28;
            this.rtb_Info.Text = "";
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(268, 141);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(89, 13);
            this.lbl_Info.TabIndex = 27;
            this.lbl_Info.Text = "Informacion Extra";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(484, 102);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(32, 13);
            this.lbl_mail.TabIndex = 24;
            this.lbl_mail.Text = "Email";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(576, 39);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 23;
            // 
            // lbl_Movil
            // 
            this.lbl_Movil.AutoSize = true;
            this.lbl_Movil.Location = new System.Drawing.Point(484, 69);
            this.lbl_Movil.Name = "lbl_Movil";
            this.lbl_Movil.Size = new System.Drawing.Size(76, 13);
            this.lbl_Movil.TabIndex = 21;
            this.lbl_Movil.Text = "Telefono movil";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(484, 43);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 20;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // txt_ApePat
            // 
            this.txt_ApePat.Location = new System.Drawing.Point(576, 13);
            this.txt_ApePat.Name = "txt_ApePat";
            this.txt_ApePat.Size = new System.Drawing.Size(100, 20);
            this.txt_ApePat.TabIndex = 19;
            // 
            // lbl_ApePat
            // 
            this.lbl_ApePat.AutoSize = true;
            this.lbl_ApePat.Location = new System.Drawing.Point(484, 17);
            this.lbl_ApePat.Name = "lbl_ApePat";
            this.lbl_ApePat.Size = new System.Drawing.Size(84, 13);
            this.lbl_ApePat.TabIndex = 18;
            this.lbl_ApePat.Text = "Apellido Paterno";
            // 
            // lbl_NumeroFijo
            // 
            this.lbl_NumeroFijo.AutoSize = true;
            this.lbl_NumeroFijo.Location = new System.Drawing.Point(268, 95);
            this.lbl_NumeroFijo.Name = "lbl_NumeroFijo";
            this.lbl_NumeroFijo.Size = new System.Drawing.Size(60, 13);
            this.lbl_NumeroFijo.TabIndex = 16;
            this.lbl_NumeroFijo.Text = "Numero fijo";
            // 
            // txt_Barrio
            // 
            this.txt_Barrio.Location = new System.Drawing.Point(348, 66);
            this.txt_Barrio.Name = "txt_Barrio";
            this.txt_Barrio.Size = new System.Drawing.Size(100, 20);
            this.txt_Barrio.TabIndex = 15;
            // 
            // dtp_FechaNac
            // 
            this.dtp_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNac.Location = new System.Drawing.Point(348, 40);
            this.dtp_FechaNac.Name = "dtp_FechaNac";
            this.dtp_FechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtp_FechaNac.TabIndex = 14;
            // 
            // lbl_Barrio
            // 
            this.lbl_Barrio.AutoSize = true;
            this.lbl_Barrio.Location = new System.Drawing.Point(268, 69);
            this.lbl_Barrio.Name = "lbl_Barrio";
            this.lbl_Barrio.Size = new System.Drawing.Size(34, 13);
            this.lbl_Barrio.TabIndex = 11;
            this.lbl_Barrio.Text = "Barrio";
            // 
            // lbl_Nacimiento
            // 
            this.lbl_Nacimiento.AutoSize = true;
            this.lbl_Nacimiento.Location = new System.Drawing.Point(268, 43);
            this.lbl_Nacimiento.Name = "lbl_Nacimiento";
            this.lbl_Nacimiento.Size = new System.Drawing.Size(60, 13);
            this.lbl_Nacimiento.TabIndex = 9;
            this.lbl_Nacimiento.Text = "Nacimiento";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(348, 14);
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(100, 20);
            this.txt_Nombres.TabIndex = 8;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(268, 17);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 7;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // rbt_Mujer
            // 
            this.rbt_Mujer.AutoSize = true;
            this.rbt_Mujer.Location = new System.Drawing.Point(99, 100);
            this.rbt_Mujer.Name = "rbt_Mujer";
            this.rbt_Mujer.Size = new System.Drawing.Size(51, 17);
            this.rbt_Mujer.TabIndex = 6;
            this.rbt_Mujer.TabStop = true;
            this.rbt_Mujer.Text = "Mujer";
            this.rbt_Mujer.UseVisualStyleBackColor = true;
            // 
            // rbt_Hombre
            // 
            this.rbt_Hombre.AutoSize = true;
            this.rbt_Hombre.Location = new System.Drawing.Point(99, 76);
            this.rbt_Hombre.Name = "rbt_Hombre";
            this.rbt_Hombre.Size = new System.Drawing.Size(62, 17);
            this.rbt_Hombre.TabIndex = 5;
            this.rbt_Hombre.TabStop = true;
            this.rbt_Hombre.Text = "Hombre";
            this.rbt_Hombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sexo";
            // 
            // txt_ApeMat
            // 
            this.txt_ApeMat.Location = new System.Drawing.Point(99, 43);
            this.txt_ApeMat.Name = "txt_ApeMat";
            this.txt_ApeMat.Size = new System.Drawing.Size(100, 20);
            this.txt_ApeMat.TabIndex = 3;
            // 
            // lbl_ApeMat
            // 
            this.lbl_ApeMat.AutoSize = true;
            this.lbl_ApeMat.Location = new System.Drawing.Point(7, 46);
            this.lbl_ApeMat.Name = "lbl_ApeMat";
            this.lbl_ApeMat.Size = new System.Drawing.Size(86, 13);
            this.lbl_ApeMat.TabIndex = 2;
            this.lbl_ApeMat.Text = "Apellido Materno";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Location = new System.Drawing.Point(7, 20);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_Matricula.TabIndex = 0;
            this.lbl_Matricula.Text = "Matricula";
            // 
            // dgt_Alumnos
            // 
            this.dgt_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.Nombres,
            this.ApePat,
            this.ApeMat,
            this.Nacimiento,
            this.Direccion,
            this.Sexo,
            this.Barrio,
            this.TelefonoMovil,
            this.TelefonoFIjo,
            this.Mail,
            this.Info});
            this.dgt_Alumnos.Location = new System.Drawing.Point(13, 291);
            this.dgt_Alumnos.Name = "dgt_Alumnos";
            this.dgt_Alumnos.Size = new System.Drawing.Size(695, 150);
            this.dgt_Alumnos.TabIndex = 1;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // ApePat
            // 
            this.ApePat.HeaderText = "Apellido Paterno";
            this.ApePat.Name = "ApePat";
            // 
            // ApeMat
            // 
            this.ApeMat.HeaderText = "Apellido Materno";
            this.ApeMat.Name = "ApeMat";
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // TelefonoMovil
            // 
            this.TelefonoMovil.HeaderText = "Telefono";
            this.TelefonoMovil.Name = "TelefonoMovil";
            // 
            // TelefonoFIjo
            // 
            this.TelefonoFIjo.HeaderText = "Telefono Fijo";
            this.TelefonoFIjo.Name = "TelefonoFIjo";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "E-Mail";
            this.Mail.Name = "Mail";
            // 
            // Info
            // 
            this.Info.HeaderText = "Informacion";
            this.Info.Name = "Info";
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(99, 14);
            this.txt_Matricula.Mask = "99999";
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_Matricula.TabIndex = 32;
            this.txt_Matricula.ValidatingType = typeof(int);
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(576, 95);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 26;
            // 
            // txt_Fijo
            // 
            this.txt_Fijo.Location = new System.Drawing.Point(348, 92);
            this.txt_Fijo.Mask = "(999)000-0000";
            this.txt_Fijo.Name = "txt_Fijo";
            this.txt_Fijo.Size = new System.Drawing.Size(100, 20);
            this.txt_Fijo.TabIndex = 33;
            // 
            // txt_Movil
            // 
            this.txt_Movil.Location = new System.Drawing.Point(576, 66);
            this.txt_Movil.Mask = "(999)000-0000";
            this.txt_Movil.Name = "txt_Movil";
            this.txt_Movil.Size = new System.Drawing.Size(100, 20);
            this.txt_Movil.TabIndex = 34;
            // 
            // frm_Ejercicio14GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 479);
            this.Controls.Add(this.dgt_Alumnos);
            this.Controls.Add(this.grb_Alumno);
            this.Name = "frm_Ejercicio14GUI";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.frm_Ejercicio14GUI_Load);
            this.grb_Alumno.ResumeLayout(false);
            this.grb_Alumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Alumno;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.DataGridView dgt_Alumnos;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.RichTextBox rtb_Info;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Movil;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.TextBox txt_ApePat;
        private System.Windows.Forms.Label lbl_ApePat;
        private System.Windows.Forms.Label lbl_NumeroFijo;
        private System.Windows.Forms.TextBox txt_Barrio;
        private System.Windows.Forms.DateTimePicker dtp_FechaNac;
        private System.Windows.Forms.Label lbl_Barrio;
        private System.Windows.Forms.Label lbl_Nacimiento;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.RadioButton rbt_Mujer;
        private System.Windows.Forms.RadioButton rbt_Hombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ApeMat;
        private System.Windows.Forms.Label lbl_ApeMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApePat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApeMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoMovil;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoFIjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.MaskedTextBox txt_Movil;
        private System.Windows.Forms.MaskedTextBox txt_Fijo;
        private System.Windows.Forms.MaskedTextBox txt_Matricula;
        private System.Windows.Forms.TextBox txt_mail;
    }
}