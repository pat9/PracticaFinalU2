namespace PracticasU2.GUI
{
    partial class frm_Ejercicio8GUI
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
            this.lbl_Jugador1 = new System.Windows.Forms.Label();
            this.lbl_Jugador2 = new System.Windows.Forms.Label();
            this.lbl_PuntosJ1 = new System.Windows.Forms.Label();
            this.lbl_PuntosJ2 = new System.Windows.Forms.Label();
            this.lbl_Turno = new System.Windows.Forms.Label();
            this.btn_Turno = new System.Windows.Forms.Button();
            this.grb_Juego = new System.Windows.Forms.GroupBox();
            this.btn_P1 = new System.Windows.Forms.Button();
            this.btn_P2 = new System.Windows.Forms.Button();
            this.btn_P3 = new System.Windows.Forms.Button();
            this.btn_P4 = new System.Windows.Forms.Button();
            this.btn_P5 = new System.Windows.Forms.Button();
            this.btn_P8 = new System.Windows.Forms.Button();
            this.btn_P6 = new System.Windows.Forms.Button();
            this.btn_P7 = new System.Windows.Forms.Button();
            this.btn_P9 = new System.Windows.Forms.Button();
            this.grb_Juego.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Jugador1
            // 
            this.lbl_Jugador1.AutoSize = true;
            this.lbl_Jugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jugador1.Location = new System.Drawing.Point(13, 13);
            this.lbl_Jugador1.Name = "lbl_Jugador1";
            this.lbl_Jugador1.Size = new System.Drawing.Size(156, 24);
            this.lbl_Jugador1.TabIndex = 0;
            this.lbl_Jugador1.Text = "(X) JUGADOR 1: ";
            // 
            // lbl_Jugador2
            // 
            this.lbl_Jugador2.AutoSize = true;
            this.lbl_Jugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Jugador2.Location = new System.Drawing.Point(197, 12);
            this.lbl_Jugador2.Name = "lbl_Jugador2";
            this.lbl_Jugador2.Size = new System.Drawing.Size(157, 24);
            this.lbl_Jugador2.TabIndex = 1;
            this.lbl_Jugador2.Text = "(O) JUGADOR 2: ";
            // 
            // lbl_PuntosJ1
            // 
            this.lbl_PuntosJ1.AutoSize = true;
            this.lbl_PuntosJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PuntosJ1.ForeColor = System.Drawing.Color.Blue;
            this.lbl_PuntosJ1.Location = new System.Drawing.Point(166, 12);
            this.lbl_PuntosJ1.Name = "lbl_PuntosJ1";
            this.lbl_PuntosJ1.Size = new System.Drawing.Size(25, 25);
            this.lbl_PuntosJ1.TabIndex = 2;
            this.lbl_PuntosJ1.Text = "0";
            this.lbl_PuntosJ1.Click += new System.EventHandler(this.lbl_PuntosJ1_Click);
            // 
            // lbl_PuntosJ2
            // 
            this.lbl_PuntosJ2.AutoSize = true;
            this.lbl_PuntosJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PuntosJ2.ForeColor = System.Drawing.Color.Blue;
            this.lbl_PuntosJ2.Location = new System.Drawing.Point(350, 11);
            this.lbl_PuntosJ2.Name = "lbl_PuntosJ2";
            this.lbl_PuntosJ2.Size = new System.Drawing.Size(25, 25);
            this.lbl_PuntosJ2.TabIndex = 3;
            this.lbl_PuntosJ2.Text = "0";
            // 
            // lbl_Turno
            // 
            this.lbl_Turno.AutoSize = true;
            this.lbl_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turno.Location = new System.Drawing.Point(64, 248);
            this.lbl_Turno.Name = "lbl_Turno";
            this.lbl_Turno.Size = new System.Drawing.Size(66, 24);
            this.lbl_Turno.TabIndex = 13;
            this.lbl_Turno.Text = "Turno:";
            // 
            // btn_Turno
            // 
            this.btn_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Turno.Location = new System.Drawing.Point(154, 236);
            this.btn_Turno.Name = "btn_Turno";
            this.btn_Turno.Size = new System.Drawing.Size(80, 53);
            this.btn_Turno.TabIndex = 14;
            this.btn_Turno.Text = "-";
            this.btn_Turno.UseVisualStyleBackColor = true;
            this.btn_Turno.Click += new System.EventHandler(this.btn_Turno_Click);
            // 
            // grb_Juego
            // 
            this.grb_Juego.Controls.Add(this.btn_P9);
            this.grb_Juego.Controls.Add(this.btn_P7);
            this.grb_Juego.Controls.Add(this.btn_P6);
            this.grb_Juego.Controls.Add(this.btn_P8);
            this.grb_Juego.Controls.Add(this.btn_P5);
            this.grb_Juego.Controls.Add(this.btn_P4);
            this.grb_Juego.Controls.Add(this.btn_P3);
            this.grb_Juego.Controls.Add(this.btn_P2);
            this.grb_Juego.Controls.Add(this.btn_P1);
            this.grb_Juego.Location = new System.Drawing.Point(29, 40);
            this.grb_Juego.Name = "grb_Juego";
            this.grb_Juego.Size = new System.Drawing.Size(325, 190);
            this.grb_Juego.TabIndex = 22;
            this.grb_Juego.TabStop = false;
            this.grb_Juego.EnabledChanged += new System.EventHandler(this.grb_Juego_EnabledChanged);
            // 
            // btn_P1
            // 
            this.btn_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P1.Location = new System.Drawing.Point(36, 10);
            this.btn_P1.Name = "btn_P1";
            this.btn_P1.Size = new System.Drawing.Size(80, 53);
            this.btn_P1.TabIndex = 22;
            this.btn_P1.Text = "-";
            this.btn_P1.UseVisualStyleBackColor = true;
            this.btn_P1.Click += new System.EventHandler(this.btn_P1_Click);
            // 
            // btn_P2
            // 
            this.btn_P2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P2.Location = new System.Drawing.Point(122, 10);
            this.btn_P2.Name = "btn_P2";
            this.btn_P2.Size = new System.Drawing.Size(80, 53);
            this.btn_P2.TabIndex = 23;
            this.btn_P2.Text = "-";
            this.btn_P2.UseVisualStyleBackColor = false;
            this.btn_P2.Click += new System.EventHandler(this.btn_P2_Click);
            // 
            // btn_P3
            // 
            this.btn_P3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P3.Location = new System.Drawing.Point(208, 10);
            this.btn_P3.Name = "btn_P3";
            this.btn_P3.Size = new System.Drawing.Size(80, 53);
            this.btn_P3.TabIndex = 24;
            this.btn_P3.Text = "-";
            this.btn_P3.UseVisualStyleBackColor = true;
            this.btn_P3.Click += new System.EventHandler(this.btn_P3_Click);
            // 
            // btn_P4
            // 
            this.btn_P4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P4.Location = new System.Drawing.Point(36, 69);
            this.btn_P4.Name = "btn_P4";
            this.btn_P4.Size = new System.Drawing.Size(80, 53);
            this.btn_P4.TabIndex = 25;
            this.btn_P4.Text = "-";
            this.btn_P4.UseVisualStyleBackColor = true;
            this.btn_P4.Click += new System.EventHandler(this.btn_P4_Click);
            // 
            // btn_P5
            // 
            this.btn_P5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P5.Location = new System.Drawing.Point(122, 69);
            this.btn_P5.Name = "btn_P5";
            this.btn_P5.Size = new System.Drawing.Size(80, 53);
            this.btn_P5.TabIndex = 26;
            this.btn_P5.Text = "-";
            this.btn_P5.UseVisualStyleBackColor = true;
            this.btn_P5.Click += new System.EventHandler(this.btn_P5_Click);
            // 
            // btn_P8
            // 
            this.btn_P8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P8.Location = new System.Drawing.Point(122, 128);
            this.btn_P8.Name = "btn_P8";
            this.btn_P8.Size = new System.Drawing.Size(80, 53);
            this.btn_P8.TabIndex = 28;
            this.btn_P8.Text = "-";
            this.btn_P8.UseVisualStyleBackColor = true;
            this.btn_P8.Click += new System.EventHandler(this.btn_P8_Click);
            // 
            // btn_P6
            // 
            this.btn_P6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P6.Location = new System.Drawing.Point(208, 69);
            this.btn_P6.Name = "btn_P6";
            this.btn_P6.Size = new System.Drawing.Size(80, 53);
            this.btn_P6.TabIndex = 27;
            this.btn_P6.Text = "-";
            this.btn_P6.UseVisualStyleBackColor = true;
            this.btn_P6.Click += new System.EventHandler(this.btn_P6_Click);
            // 
            // btn_P7
            // 
            this.btn_P7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P7.Location = new System.Drawing.Point(36, 128);
            this.btn_P7.Name = "btn_P7";
            this.btn_P7.Size = new System.Drawing.Size(80, 53);
            this.btn_P7.TabIndex = 29;
            this.btn_P7.Text = "-";
            this.btn_P7.UseVisualStyleBackColor = true;
            this.btn_P7.Click += new System.EventHandler(this.btn_P7_Click);
            // 
            // btn_P9
            // 
            this.btn_P9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_P9.Location = new System.Drawing.Point(208, 128);
            this.btn_P9.Name = "btn_P9";
            this.btn_P9.Size = new System.Drawing.Size(80, 53);
            this.btn_P9.TabIndex = 30;
            this.btn_P9.Text = "-";
            this.btn_P9.UseVisualStyleBackColor = true;
            this.btn_P9.Click += new System.EventHandler(this.btn_P9_Click);
            // 
            // frm_Ejercicio8GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 301);
            this.Controls.Add(this.grb_Juego);
            this.Controls.Add(this.btn_Turno);
            this.Controls.Add(this.lbl_Turno);
            this.Controls.Add(this.lbl_PuntosJ2);
            this.Controls.Add(this.lbl_PuntosJ1);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.lbl_Jugador1);
            this.Name = "frm_Ejercicio8GUI";
            this.Text = "Juego del gato";
            this.Load += new System.EventHandler(this.frm_Ejercicio8GUI_Load);
            this.grb_Juego.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Jugador1;
        private System.Windows.Forms.Label lbl_Jugador2;
        private System.Windows.Forms.Label lbl_PuntosJ1;
        private System.Windows.Forms.Label lbl_PuntosJ2;
        private System.Windows.Forms.Label lbl_Turno;
        private System.Windows.Forms.Button btn_Turno;
        public System.Windows.Forms.GroupBox grb_Juego;
        public System.Windows.Forms.Button btn_P9;
        public System.Windows.Forms.Button btn_P7;
        public System.Windows.Forms.Button btn_P6;
        public System.Windows.Forms.Button btn_P8;
        public System.Windows.Forms.Button btn_P5;
        public System.Windows.Forms.Button btn_P4;
        public System.Windows.Forms.Button btn_P3;
        public System.Windows.Forms.Button btn_P2;
        public System.Windows.Forms.Button btn_P1;
    }
}