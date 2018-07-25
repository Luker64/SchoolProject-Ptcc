namespace ProgramaPtcc {
    partial class UserCadMat {
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
            this.btn_cadmat = new System.Windows.Forms.Button();
            this.btn_limpmat = new System.Windows.Forms.Button();
            this.btn_voltmat = new System.Windows.Forms.Button();
            this.txtNomemat = new System.Windows.Forms.TextBox();
            this.lblNomemat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cadmat
            // 
            this.btn_cadmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadmat.Location = new System.Drawing.Point(452, 377);
            this.btn_cadmat.Name = "btn_cadmat";
            this.btn_cadmat.Size = new System.Drawing.Size(100, 33);
            this.btn_cadmat.TabIndex = 48;
            this.btn_cadmat.Text = "Cadastrar";
            this.btn_cadmat.UseVisualStyleBackColor = true;
            this.btn_cadmat.Click += new System.EventHandler(this.btn_cadmat_Click);
            // 
            // btn_limpmat
            // 
            this.btn_limpmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpmat.Location = new System.Drawing.Point(249, 377);
            this.btn_limpmat.Name = "btn_limpmat";
            this.btn_limpmat.Size = new System.Drawing.Size(100, 33);
            this.btn_limpmat.TabIndex = 47;
            this.btn_limpmat.Text = "Limpar";
            this.btn_limpmat.UseVisualStyleBackColor = true;
            this.btn_limpmat.Click += new System.EventHandler(this.btn_limpmat_Click);
            // 
            // btn_voltmat
            // 
            this.btn_voltmat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltmat.Location = new System.Drawing.Point(37, 377);
            this.btn_voltmat.Name = "btn_voltmat";
            this.btn_voltmat.Size = new System.Drawing.Size(100, 33);
            this.btn_voltmat.TabIndex = 46;
            this.btn_voltmat.Text = "Voltar";
            this.btn_voltmat.UseVisualStyleBackColor = true;
            this.btn_voltmat.Click += new System.EventHandler(this.btn_voltmat_Click);
            // 
            // txtNomemat
            // 
            this.txtNomemat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomemat.Location = new System.Drawing.Point(205, 137);
            this.txtNomemat.Multiline = true;
            this.txtNomemat.Name = "txtNomemat";
            this.txtNomemat.Size = new System.Drawing.Size(232, 20);
            this.txtNomemat.TabIndex = 45;
            // 
            // lblNomemat
            // 
            this.lblNomemat.AutoSize = true;
            this.lblNomemat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomemat.Location = new System.Drawing.Point(44, 135);
            this.lblNomemat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomemat.Name = "lblNomemat";
            this.lblNomemat.Size = new System.Drawing.Size(145, 20);
            this.lblNomemat.TabIndex = 44;
            this.lblNomemat.Text = "Nome da Matéria";
            this.lblNomemat.Click += new System.EventHandler(this.lblNomemat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pictureBox1.Location = new System.Drawing.Point(205, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 5);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // UserMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cadmat);
            this.Controls.Add(this.btn_limpmat);
            this.Controls.Add(this.btn_voltmat);
            this.Controls.Add(this.txtNomemat);
            this.Controls.Add(this.lblNomemat);
            this.Name = "UserMat";
            this.Size = new System.Drawing.Size(600, 422);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadmat;
        private System.Windows.Forms.Button btn_limpmat;
        private System.Windows.Forms.Button btn_voltmat;
        private System.Windows.Forms.Label lblNomemat;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtNomemat;
    }
}
