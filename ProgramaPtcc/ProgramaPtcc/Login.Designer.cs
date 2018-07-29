namespace ProgramaPtcc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.pcbLog = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOlho = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.tgl_pa = new MetroFramework.Controls.MetroToggle();
            this.lblProf = new MetroFramework.Controls.MetroLabel();
            this.lblalu = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEntrar.Location = new System.Drawing.Point(177, 405);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(100, 33);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(91, 211);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(135, 15);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(91, 275);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(135, 15);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // pcbPass
            // 
            this.pcbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pcbPass.Location = new System.Drawing.Point(91, 290);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(135, 5);
            this.pcbPass.TabIndex = 8;
            this.pcbPass.TabStop = false;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(27, 211);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(58, 20);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Login";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(21, 275);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(64, 20);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Senha";
            // 
            // pcbLog
            // 
            this.pcbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.pcbLog.Location = new System.Drawing.Point(91, 226);
            this.pcbLog.Name = "pcbLog";
            this.pcbLog.Size = new System.Drawing.Size(135, 5);
            this.pcbLog.TabIndex = 11;
            this.pcbLog.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSair.Location = new System.Drawing.Point(31, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 33);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOlho
            // 
            this.btnOlho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOlho.BackgroundImage")));
            this.btnOlho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOlho.FlatAppearance.BorderSize = 0;
            this.btnOlho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlho.Location = new System.Drawing.Point(244, 275);
            this.btnOlho.Name = "btnOlho";
            this.btnOlho.Size = new System.Drawing.Size(33, 22);
            this.btnOlho.TabIndex = 13;
            this.btnOlho.UseVisualStyleBackColor = true;
            this.btnOlho.Click += new System.EventHandler(this.btnOlho_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(45, 310);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(220, 20);
            this.lblErro.TabIndex = 14;
            this.lblErro.Text = "Login ou Senha incorretos";
            this.lblErro.Visible = false;
            // 
            // tgl_pa
            // 
            this.tgl_pa.AutoSize = true;
            this.tgl_pa.DisplayStatus = false;
            this.tgl_pa.Location = new System.Drawing.Point(130, 359);
            this.tgl_pa.Name = "tgl_pa";
            this.tgl_pa.Size = new System.Drawing.Size(50, 17);
            this.tgl_pa.TabIndex = 15;
            this.tgl_pa.Tag = "";
            this.tgl_pa.Text = "Off";
            this.tgl_pa.UseVisualStyleBackColor = true;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(49, 357);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(64, 19);
            this.lblProf.TabIndex = 16;
            this.lblProf.Text = "Professor";
            // 
            // lblalu
            // 
            this.lblalu.AutoSize = true;
            this.lblalu.Location = new System.Drawing.Point(198, 357);
            this.lblalu.Name = "lblalu";
            this.lblalu.Size = new System.Drawing.Size(43, 19);
            this.lblalu.TabIndex = 17;
            this.lblalu.Text = "Aluno";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblalu);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.tgl_pa);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnOlho);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pcbLog);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.pcbPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.PictureBox pcbLog;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOlho;
        private System.Windows.Forms.Label lblErro;
        private MetroFramework.Controls.MetroToggle tgl_pa;
        private MetroFramework.Controls.MetroLabel lblProf;
        private MetroFramework.Controls.MetroLabel lblalu;
    }
}