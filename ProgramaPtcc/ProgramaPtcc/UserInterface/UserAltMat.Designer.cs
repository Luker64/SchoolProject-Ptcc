namespace ProgramaPtcc
{
    partial class UserAltMat
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_altmat = new System.Windows.Forms.Button();
            this.btn_limpmat = new System.Windows.Forms.Button();
            this.btn_voltmat = new System.Windows.Forms.Button();
            this.txtNomemat = new System.Windows.Forms.TextBox();
            this.lblNomemat = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(260, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 5);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btn_altmat
            // 
            this.btn_altmat.Enabled = false;
            this.btn_altmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_altmat.Location = new System.Drawing.Point(452, 340);
            this.btn_altmat.Name = "btn_altmat";
            this.btn_altmat.Size = new System.Drawing.Size(100, 33);
            this.btn_altmat.TabIndex = 54;
            this.btn_altmat.Text = "Alterar";
            this.btn_altmat.UseVisualStyleBackColor = true;
            this.btn_altmat.Click += new System.EventHandler(this.btn_altmat_Click);
            // 
            // btn_limpmat
            // 
            this.btn_limpmat.Enabled = false;
            this.btn_limpmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpmat.Location = new System.Drawing.Point(260, 340);
            this.btn_limpmat.Name = "btn_limpmat";
            this.btn_limpmat.Size = new System.Drawing.Size(100, 33);
            this.btn_limpmat.TabIndex = 53;
            this.btn_limpmat.Text = "Limpar";
            this.btn_limpmat.UseVisualStyleBackColor = true;
            this.btn_limpmat.Click += new System.EventHandler(this.btn_limpmat_Click);
            // 
            // btn_voltmat
            // 
            this.btn_voltmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltmat.Location = new System.Drawing.Point(44, 340);
            this.btn_voltmat.Name = "btn_voltmat";
            this.btn_voltmat.Size = new System.Drawing.Size(100, 33);
            this.btn_voltmat.TabIndex = 52;
            this.btn_voltmat.Text = "Voltar";
            this.btn_voltmat.UseVisualStyleBackColor = true;
            this.btn_voltmat.Click += new System.EventHandler(this.btn_voltmat_Click);
            // 
            // txtNomemat
            // 
            this.txtNomemat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomemat.Enabled = false;
            this.txtNomemat.Location = new System.Drawing.Point(260, 180);
            this.txtNomemat.Multiline = true;
            this.txtNomemat.Name = "txtNomemat";
            this.txtNomemat.Size = new System.Drawing.Size(232, 20);
            this.txtNomemat.TabIndex = 51;
            // 
            // lblNomemat
            // 
            this.lblNomemat.AutoSize = true;
            this.lblNomemat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomemat.Location = new System.Drawing.Point(99, 178);
            this.lblNomemat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomemat.Name = "lblNomemat";
            this.lblNomemat.Size = new System.Drawing.Size(145, 20);
            this.lblNomemat.TabIndex = 50;
            this.lblNomemat.Text = "Nome da Matéria";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.White;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(206, 39);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(30, 20);
            this.lbl_id.TabIndex = 58;
            this.lbl_id.Text = "Id:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pictureBox2.Location = new System.Drawing.Point(240, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 5);
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(240, 38);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 20);
            this.txtid.TabIndex = 56;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(336, 28);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 33);
            this.btnbuscar.TabIndex = 90;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // UserAltMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_altmat);
            this.Controls.Add(this.btn_limpmat);
            this.Controls.Add(this.btn_voltmat);
            this.Controls.Add(this.txtNomemat);
            this.Controls.Add(this.lblNomemat);
            this.Name = "UserAltMat";
            this.Size = new System.Drawing.Size(600, 422);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_altmat;
        private System.Windows.Forms.Button btn_limpmat;
        private System.Windows.Forms.Button btn_voltmat;
        private System.Windows.Forms.Label lblNomemat;
        public System.Windows.Forms.TextBox txtNomemat;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnbuscar;
    }
}
