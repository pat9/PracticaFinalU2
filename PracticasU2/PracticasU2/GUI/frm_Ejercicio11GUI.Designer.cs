namespace PracticasU2.GUI
{
    partial class frm_Ejercicio11GUI
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Tiempo = new System.Windows.Forms.Label();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.trm_Cronometro = new System.Windows.Forms.Timer(this.components);
            this.btn_Iniciar_Parar = new System.Windows.Forms.Button();
            this.btn_Reiniciar_Vuelta = new System.Windows.Forms.Button();
            this.dgt_Registro = new System.Windows.Forms.DataGridView();
            this.Vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Registro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tiempo.Location = new System.Drawing.Point(52, 36);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(80, 24);
            this.lbl_Tiempo.TabIndex = 0;
            this.lbl_Tiempo.Text = "Tiempo:";
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contador.Location = new System.Drawing.Point(129, 36);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(80, 24);
            this.lbl_Contador.TabIndex = 1;
            this.lbl_Contador.Text = "00:00:00";
            // 
            // trm_Cronometro
            // 
            this.trm_Cronometro.Interval = 1000;
            this.trm_Cronometro.Tick += new System.EventHandler(this.trm_Cronometro_Tick);
            // 
            // btn_Iniciar_Parar
            // 
            this.btn_Iniciar_Parar.Location = new System.Drawing.Point(57, 76);
            this.btn_Iniciar_Parar.Name = "btn_Iniciar_Parar";
            this.btn_Iniciar_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar_Parar.TabIndex = 2;
            this.btn_Iniciar_Parar.Text = "Iniciar";
            this.btn_Iniciar_Parar.UseVisualStyleBackColor = true;
            this.btn_Iniciar_Parar.Click += new System.EventHandler(this.btn_Iniciar_Parar_Click);
            // 
            // btn_Reiniciar_Vuelta
            // 
            this.btn_Reiniciar_Vuelta.Enabled = false;
            this.btn_Reiniciar_Vuelta.Location = new System.Drawing.Point(138, 76);
            this.btn_Reiniciar_Vuelta.Name = "btn_Reiniciar_Vuelta";
            this.btn_Reiniciar_Vuelta.Size = new System.Drawing.Size(75, 23);
            this.btn_Reiniciar_Vuelta.TabIndex = 3;
            this.btn_Reiniciar_Vuelta.Text = "Reiniciar";
            this.btn_Reiniciar_Vuelta.UseVisualStyleBackColor = true;
            this.btn_Reiniciar_Vuelta.Click += new System.EventHandler(this.btn_Reiniciar_Vuelta_Click);
            // 
            // dgt_Registro
            // 
            this.dgt_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_Registro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vuelta,
            this.Tiempo});
            this.dgt_Registro.Location = new System.Drawing.Point(13, 122);
            this.dgt_Registro.Name = "dgt_Registro";
            this.dgt_Registro.Size = new System.Drawing.Size(256, 127);
            this.dgt_Registro.TabIndex = 4;
            // 
            // Vuelta
            // 
            this.Vuelta.HeaderText = "Vuelta";
            this.Vuelta.Name = "Vuelta";
            // 
            // Tiempo
            // 
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // frm_Ejercicio11GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.dgt_Registro);
            this.Controls.Add(this.btn_Reiniciar_Vuelta);
            this.Controls.Add(this.btn_Iniciar_Parar);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.lbl_Tiempo);
            this.Name = "frm_Ejercicio11GUI";
            this.Text = "Cronometro";
            ((System.ComponentModel.ISupportInitialize)(this.dgt_Registro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tiempo;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Timer trm_Cronometro;
        private System.Windows.Forms.Button btn_Iniciar_Parar;
        private System.Windows.Forms.Button btn_Reiniciar_Vuelta;
        private System.Windows.Forms.DataGridView dgt_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    }
}