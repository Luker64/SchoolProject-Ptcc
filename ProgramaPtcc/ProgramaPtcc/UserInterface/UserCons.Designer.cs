namespace ProgramaPtcc {
    partial class UserCons {
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
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.lbl_filtro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_campoAl = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btncons = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cb_campoTur = new System.Windows.Forms.ComboBox();
            this.cb_campoFunc = new System.Windows.Forms.ComboBox();
            this.cb_campoProf = new System.Windows.Forms.ComboBox();
            this.cb_campoMat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(49, 46);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(48, 20);
            this.lbl_tipo.TabIndex = 0;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_campo
            // 
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campo.Location = new System.Drawing.Point(348, 49);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(65, 20);
            this.lbl_campo.TabIndex = 1;
            this.lbl_campo.Text = "Campo";
            this.lbl_campo.Visible = false;
            // 
            // lbl_filtro
            // 
            this.lbl_filtro.AutoSize = true;
            this.lbl_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro.Location = new System.Drawing.Point(141, 118);
            this.lbl_filtro.Name = "lbl_filtro";
            this.lbl_filtro.Size = new System.Drawing.Size(50, 20);
            this.lbl_filtro.TabIndex = 2;
            this.lbl_filtro.Text = "Filtro";
            this.lbl_filtro.Visible = false;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(229, 118);
            this.txtfiltro.Multiline = true;
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(184, 20);
            this.txtfiltro.TabIndex = 5;
            this.txtfiltro.Visible = false;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Funcionario",
            "Materia",
            "Turma"});
            this.cb_tipo.Location = new System.Drawing.Point(103, 48);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 6;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            // 
            // cb_campoAl
            // 
            this.cb_campoAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campoAl.FormattingEnabled = true;
            this.cb_campoAl.Items.AddRange(new object[] {
            "Número de Matricula",
            "Nome",
            "Idade",
            "Turma",
            "Nome do Responsável",
            "Email",
            "Telefone"});
            this.cb_campoAl.Location = new System.Drawing.Point(419, 51);
            this.cb_campoAl.Name = "cb_campoAl";
            this.cb_campoAl.Size = new System.Drawing.Size(121, 21);
            this.cb_campoAl.TabIndex = 7;
            this.cb_campoAl.Visible = false;
            this.cb_campoAl.SelectedIndexChanged += new System.EventHandler(this.cb_campoAl_SelectedIndexChanged);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(75, 153);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(479, 224);
            this.dgv1.TabIndex = 8;
            // 
            // btncons
            // 
            this.btncons.Enabled = false;
            this.btncons.Location = new System.Drawing.Point(454, 383);
            this.btncons.Name = "btncons";
            this.btncons.Size = new System.Drawing.Size(100, 33);
            this.btncons.TabIndex = 9;
            this.btncons.Text = "Pesquisar";
            this.btncons.UseVisualStyleBackColor = true;
            this.btncons.Click += new System.EventHandler(this.btncons_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(75, 383);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 33);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cb_campoTur
            // 
            this.cb_campoTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campoTur.FormattingEnabled = true;
            this.cb_campoTur.Items.AddRange(new object[] {
            "Código da Turma",
            "Número da Sala",
            "Número de Alunos",
            "Horário"});
            this.cb_campoTur.Location = new System.Drawing.Point(419, 51);
            this.cb_campoTur.Name = "cb_campoTur";
            this.cb_campoTur.Size = new System.Drawing.Size(121, 21);
            this.cb_campoTur.TabIndex = 11;
            this.cb_campoTur.Visible = false;
            this.cb_campoTur.SelectedIndexChanged += new System.EventHandler(this.cb_campoTur_SelectedIndexChanged);
            // 
            // cb_campoFunc
            // 
            this.cb_campoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campoFunc.FormattingEnabled = true;
            this.cb_campoFunc.Items.AddRange(new object[] {
            "Carteira de Trabalho",
            "CPF",
            "Email",
            "Endereço",
            "Faixa de Comissão",
            "Data de Nascimento",
            "Nome",
            "Profissão",
            "RG",
            "Telefone"});
            this.cb_campoFunc.Location = new System.Drawing.Point(419, 51);
            this.cb_campoFunc.Name = "cb_campoFunc";
            this.cb_campoFunc.Size = new System.Drawing.Size(121, 21);
            this.cb_campoFunc.TabIndex = 12;
            this.cb_campoFunc.Visible = false;
            this.cb_campoFunc.SelectedIndexChanged += new System.EventHandler(this.cb_campoFunc_SelectedIndexChanged);
            // 
            // cb_campoProf
            // 
            this.cb_campoProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campoProf.FormattingEnabled = true;
            this.cb_campoProf.Items.AddRange(new object[] {
            "Carteira de Trabalho",
            "CPF",
            "Email",
            "Endereço",
            "Faixa de Comissão",
            "Data de Nascimento",
            "Nome",
            "RG",
            "Telefone"});
            this.cb_campoProf.Location = new System.Drawing.Point(419, 51);
            this.cb_campoProf.Name = "cb_campoProf";
            this.cb_campoProf.Size = new System.Drawing.Size(121, 21);
            this.cb_campoProf.TabIndex = 13;
            this.cb_campoProf.Visible = false;
            this.cb_campoProf.SelectedIndexChanged += new System.EventHandler(this.cb_campoProf_SelectedIndexChanged);
            // 
            // cb_campoMat
            // 
            this.cb_campoMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_campoMat.FormattingEnabled = true;
            this.cb_campoMat.Items.AddRange(new object[] {
            "Id ",
            "Nome"});
            this.cb_campoMat.Location = new System.Drawing.Point(419, 51);
            this.cb_campoMat.Name = "cb_campoMat";
            this.cb_campoMat.Size = new System.Drawing.Size(121, 21);
            this.cb_campoMat.TabIndex = 14;
            this.cb_campoMat.Visible = false;
            this.cb_campoMat.SelectedIndexChanged += new System.EventHandler(this.cb_campoMat_SelectedIndexChanged);
            // 
            // UserCons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_campoProf);
            this.Controls.Add(this.cb_campoFunc);
            this.Controls.Add(this.cb_campoTur);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btncons);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cb_tipo);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lbl_filtro);
            this.Controls.Add(this.lbl_campo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.cb_campoMat);
            this.Controls.Add(this.cb_campoAl);
            this.Name = "UserCons";
            this.Size = new System.Drawing.Size(600, 422);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_campo;
        private System.Windows.Forms.Label lbl_filtro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_campoAl;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btncons;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cb_campoTur;
        private System.Windows.Forms.ComboBox cb_campoFunc;
        private System.Windows.Forms.ComboBox cb_campoProf;
        private System.Windows.Forms.ComboBox cb_campoMat;
    }
}
