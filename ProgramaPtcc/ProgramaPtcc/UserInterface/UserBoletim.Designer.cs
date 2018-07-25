namespace ProgramaPtcc.Entidades
{
    partial class UserBoletim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nummat = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btncons = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nummat
            // 
            this.lbl_nummat.AutoSize = true;
            this.lbl_nummat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nummat.Location = new System.Drawing.Point(60, 32);
            this.lbl_nummat.Name = "lbl_nummat";
            this.lbl_nummat.Size = new System.Drawing.Size(179, 20);
            this.lbl_nummat.TabIndex = 6;
            this.lbl_nummat.Text = "Número da Matricula:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pictureBox2.Location = new System.Drawing.Point(268, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 5);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(268, 31);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(90, 20);
            this.txtid.TabIndex = 27;
            // 
            // btncons
            // 
            this.btncons.Location = new System.Drawing.Point(397, 26);
            this.btncons.Name = "btncons";
            this.btncons.Size = new System.Drawing.Size(100, 33);
            this.btncons.TabIndex = 29;
            this.btncons.Text = "Pesquisar";
            this.btncons.UseVisualStyleBackColor = true;
            this.btncons.Click += new System.EventHandler(this.btncons_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(35, 89);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(559, 300);
            this.dgv.TabIndex = 30;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(268, 395);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(100, 33);
            this.btn_voltar.TabIndex = 31;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // UserBoletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btncons);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lbl_nummat);
            this.Name = "UserBoletim";
            this.Size = new System.Drawing.Size(631, 452);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nummat;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btncons;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_voltar;
    }
}
