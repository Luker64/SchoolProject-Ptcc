using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaPtcc.Entidades;

namespace ProgramaPtcc {
    public partial class UserCons : UserControl {
        int escolha, att;
        EntidadesContext context = new EntidadesContext();
        public UserCons()
        {
            InitializeComponent();
        }



        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo.SelectedIndex == 0)
            {
                lbl_campo.Visible = true;
                esconder();
                cb_campoAl.Visible = true;
                escolha = 0;
            }
            else if (cb_tipo.SelectedIndex == 1)
            {
                lbl_campo.Visible = true;
                esconder();
                cb_campoProf.Visible = true;
                escolha = 1;
            }
            else if (cb_tipo.SelectedIndex == 2)
            {
                lbl_campo.Visible = true;
                esconder();
                cb_campoFunc.Visible = true;
                escolha = 2;
            }
            else if (cb_tipo.SelectedIndex == 3)
            {
                lbl_campo.Visible = true;
                esconder();
                cb_campoMat.Visible = true;
                escolha = 3;
            }
            else if (cb_tipo.SelectedIndex == 4)
            {
                lbl_campo.Visible = true;
                esconder();
                cb_campoTur.Visible = true;
                escolha = 4;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            LimpaDG();
            txtfiltro.Text = "";
            lbl_filtro.Visible = false;
            txtfiltro.Visible = false;
            cb_tipo.SelectedIndex = -1;
            cb_campoAl.SelectedIndex = -1;
            cb_campoFunc.SelectedIndex = -1;
            cb_campoMat.SelectedIndex = -1;
            cb_campoProf.SelectedIndex = -1;
            cb_campoTur.SelectedIndex = -1;
            this.Visible = false;
        }

        //ComboBox ALUNO
        private void cb_campoAl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_campoAl.SelectedIndex == 0)
            {
                ShowFilter(true);
                att = 0;
            }
            else if (cb_campoAl.SelectedIndex == 1)
            {
                ShowFilter(true);
                att = 1;
            }
            else if (cb_campoAl.SelectedIndex == 2)
            {
                ShowFilter(true);
                att = 2;
            }
            else if (cb_campoAl.SelectedIndex == 3)
            {
                ShowFilter(true);
                att = 3;
            }
            else if (cb_campoAl.SelectedIndex == 4)
            {
                ShowFilter(true);
                att = 4;
            }
            else if (cb_campoAl.SelectedIndex == 5)
            {
                ShowFilter(true);
                att = 5;
            }
            else if (cb_campoAl.SelectedIndex == 6)
            {
                ShowFilter(true);
                att = 6;
            }
        }

        //COMBOBOX PROFESSOR
        private void cb_campoProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_campoProf.SelectedIndex == 0)
            {
                ShowFilter(true);
                att = 0;
            }
            else if (cb_campoProf.SelectedIndex == 1)
            {
                ShowFilter(true);
                att = 1;
            }
            else if (cb_campoProf.SelectedIndex == 2)
            {
                ShowFilter(true);
                att = 2;
            }
            else if (cb_campoProf.SelectedIndex == 3)
            {
                ShowFilter(true);
                att = 3;
            }
            else if (cb_campoProf.SelectedIndex == 4)
            {
                ShowFilter(true);
                att = 4;
            }
            else if (cb_campoProf.SelectedIndex == 5)
            {
                ShowFilter(true);
                att = 5;
            }
            else if (cb_campoProf.SelectedIndex == 6)
            {
                ShowFilter(true);
                att = 6;
            }
            else if (cb_campoProf.SelectedIndex == 7)
            {
                ShowFilter(true);
                att = 7;
            }
            else if (cb_campoProf.SelectedIndex == 8)
            {
                ShowFilter(true);
                att = 8;
            }
        }

        //CB FUNCIONARIO
        private void cb_campoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_campoFunc.SelectedIndex == 0)
            {
                ShowFilter(true);
                att = 0;
            }
            else if (cb_campoFunc.SelectedIndex == 1)
            {
                ShowFilter(true);
                att = 1;
            }
            else if (cb_campoFunc.SelectedIndex == 2)
            {
                ShowFilter(true);
                att = 2;
            }
            else if (cb_campoFunc.SelectedIndex == 3)
            {
                ShowFilter(true);
                att = 3;
            }
            else if (cb_campoFunc.SelectedIndex == 4)
            {
                ShowFilter(true);
                att = 4;
            }
            else if (cb_campoFunc.SelectedIndex == 5)
            {
                ShowFilter(true);
                att = 5;
            }
            else if (cb_campoFunc.SelectedIndex == 6)
            {
                ShowFilter(true);
                att = 6;
            }
            else if (cb_campoFunc.SelectedIndex == 7)
            {
                ShowFilter(true);
                att = 7;
            }
            else if (cb_campoFunc.SelectedIndex == 8)
            {
                ShowFilter(true);
                att = 8;
            }
            else if (cb_campoFunc.SelectedIndex == 9)
            {
                ShowFilter(true);
                att = 9;
            }
        }

        private void cb_campoMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_campoMat.SelectedIndex == 0)
            {
                ShowFilter(true);
                att = 0;
            }
            else if (cb_campoMat.SelectedIndex == 1)
            {
                ShowFilter(true);
                att = 1;
            }
        }

        private void cb_campoTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_campoTur.SelectedIndex == 0)
            {
                ShowFilter(true);
                att = 0;
            }
            else if (cb_campoTur.SelectedIndex == 1)
            {
                ShowFilter(true);
                att = 1;
            }
            else if (cb_campoTur.SelectedIndex == 2)
            {
                ShowFilter(true);
                att = 2;
            }
            else if (cb_campoTur.SelectedIndex == 3)
            {
                ShowFilter(true);
                att = 3;
            }
        }

        public void esconder()
        {
            lbl_campo.Visible = false;
            cb_campoAl.Visible = false;
            cb_campoMat.Visible = false;
            cb_campoProf.Visible = false;
            cb_campoFunc.Visible = false;
            cb_campoTur.Visible = false;
            ShowFilter(false);
            btncons.Enabled = false;
            cb_campoAl.SelectedIndex = -1;
            cb_campoMat.SelectedIndex = -1;
            cb_campoProf.SelectedIndex = -1;
            cb_campoFunc.SelectedIndex = -1;
            cb_campoTur.SelectedIndex = -1;
            LimpaDG();
            txtfiltro.Text = "";
        }

        //Pesquisas
        private void btncons_Click(object sender, EventArgs e)
        {
            switch (escolha)
            {
                case 0: PesqAl();break;
                case 1: PesqProf(); break;
                case 2: PesqFunc(); break;
                case 3: PesqMat(); break;
                case 4: PesqTur(); break;
            }
        }

        //Pesquisa de Aluno
        public void PesqAl()
        {
            try {
                List<Aluno> alunos = new List<Aluno>();
                if (txtfiltro.Text == null || txtfiltro.Text == "")
                {
                    var search = from a in context.Alunos select a;
                    foreach (var a in search)
                    {
                        alunos.Add(a);
                    }
                }
                else
                {
                    switch (att)
                    {
                        case 0:
                            var search = from a in context.Alunos where a.NumMat == int.Parse(txtfiltro.Text) select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 1:
                            search = from a in context.Alunos where a.Nome == txtfiltro.Text select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 2:
                            search = from a in context.Alunos where a.Idade == int.Parse(txtfiltro.Text) select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 3:
                            search = from a in context.Alunos where a.CodTurma == int.Parse(txtfiltro.Text) select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 4:
                            search = from a in context.Alunos where a.NomeResp == txtfiltro.Text select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 5:
                            search = from a in context.Alunos where a.Email == txtfiltro.Text select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                        case 6:
                            search = from a in context.Alunos where a.Telefone == int.Parse(txtfiltro.Text) select a;
                            foreach (var a in search)
                            {
                                alunos.Add(a);
                            }
                            ; break;
                    }
                }


                var bindingList = new BindingList<Aluno>(alunos);
                var source = new BindingSource(bindingList, null);
                dgv1.DataSource = source;
                dgv1.Columns["Nummat"].HeaderText = "Número de Matrícula";
                dgv1.Columns["CodTurma"].HeaderText = "Código da Turma";
                dgv1.Columns["NomeResp"].HeaderText = "Nome do Responsável";
                dgv1.Columns["Turma"].Visible = false;
                dgv1.Columns["Senha"].Visible = false;
                //dgv1.Columns[7].Visible = false;
            }
            catch{MessageBox.Show("Ocorreu Um erro");}
            }

        //Pesquisa Professor
        public void PesqProf()
        {
            try
            {
                List<Professor> profs = new List<Professor>();
                if (txtfiltro.Text == null || txtfiltro.Text == "")
                {
                    var search = from p in context.Professores join m in context.Materias on p.IdMat equals m.IdMat select p;
                    foreach (var p in search)
                    {
                        profs.Add(p);
                    }
                }
                else
                {
                    switch (att)
                    {
                        case 0:
                            var search = from p in context.Professores where p.CarteiraTrab == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 1:
                            search = from p in context.Professores where p.CPF == int.Parse(txtfiltro.Text) select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 2:
                            search = from p in context.Professores where p.Email == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 3:
                            search = from p in context.Professores where p.Enderaco == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 4:
                            search = from p in context.Professores where p.FaixaComiss == int.Parse(txtfiltro.Text) select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 5:
                            search = from p in context.Professores where p.DataNasc == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 6:
                            search = from p in context.Professores where p.Nome == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 7:
                            search = from p in context.Professores where p.RG == txtfiltro.Text select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                        case 8:
                            search = from p in context.Professores where p.Telefone == int.Parse(txtfiltro.Text) select p;
                            foreach (var p in search)
                            {
                                profs.Add(p);
                            }
                              ; break;
                    }
                }

                var bindingList = new BindingList<Professor>(profs);
                var source = new BindingSource(bindingList, null);
                dgv1.DataSource = source;
                dgv1.Columns["IdMat"].HeaderText = "Código da Matéria";
                dgv1.Columns["Id"].HeaderText = "Código do Professor";
                dgv1.Columns["Enderaco"].HeaderText = "Endereço";
                dgv1.Columns["DataNasc"].HeaderText = "Data de Nascimento";
                dgv1.Columns["CarteiraTrab"].HeaderText = "Carteira de Trabalho";
                dgv1.Columns["FaixaComiss"].HeaderText = "Faixa de Comissão";
                dgv1.Columns["Senha"].Visible = false; dgv1.Columns["Materia"].Visible = false;
            }
            catch { MessageBox.Show("Ocorreu Um erro"); }
        }

        //PEsquisa de Funcionario
        public void PesqFunc()
        {
            try
            {
                List<Funcionario> funcs = new List<Funcionario>();
                if (txtfiltro.Text == null || txtfiltro.Text == "")
                {
                    var search = from f in context.Funcionarios select f;
                    foreach (var f in search)
                    {
                        funcs.Add(f);
                    }
                }
                else
                {
                    switch (att)
                    {
                        case 0:
                            var search = from f in context.Funcionarios where f.CarteiraTrab == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 1:
                            search = from f in context.Funcionarios where f.CPF == int.Parse(txtfiltro.Text) select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 2:
                            search = from f in context.Funcionarios where f.Email == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 3:
                            search = from f in context.Funcionarios where f.Enderaco == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 4:
                            search = from f in context.Funcionarios where f.FaixaComiss == int.Parse(txtfiltro.Text) select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 5:
                            search = from f in context.Funcionarios where f.DataNasc == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 6:
                            search = from f in context.Funcionarios where f.Nome == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 7:
                            search = from f in context.Funcionarios where f.Profissao == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 8:
                            search = from f in context.Funcionarios where f.RG == txtfiltro.Text select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                        case 9:
                            search = from f in context.Funcionarios where f.Telefone == int.Parse(txtfiltro.Text) select f;
                            foreach (var f in search)
                            {
                                funcs.Add(f);
                            }
                              ; break;
                    }
                }

                var bindingList = new BindingList<Funcionario>(funcs);
                var source = new BindingSource(bindingList, null);
                dgv1.DataSource = source;
                dgv1.Columns["Enderaco"].HeaderText = "Endereço";
                dgv1.Columns["DataNasc"].HeaderText = "Data de Nascimento";
                dgv1.Columns["CarteiraTrab"].HeaderText = "Carteira de Trabalho";
                dgv1.Columns["FaixaComiss"].HeaderText = "Faixa de Comissão";
            }
            catch { MessageBox.Show("Ocorreu Um erro"); }
        }

        //Pesquisa de Materia
        public void PesqMat()
        {
            try
            {
                List<Materia> mats = new List<Materia>();
                if (txtfiltro.Text == null || txtfiltro.Text == "")
                {
                    var search = from m in context.Materias select m;
                    foreach (var m in search)
                    {
                        mats.Add(m);
                    }
                }
                else
                {
                    switch (att)
                    {
                        case 0:
                            var search = from m in context.Materias where m.IdMat == int.Parse(txtfiltro.Text) select m;
                            foreach (var m in search)
                            {
                                mats.Add(m);
                            }; break;
                        case 1:
                            search = from m in context.Materias where m.Nome == txtfiltro.Text select m;
                            foreach (var m in search)
                            {
                                mats.Add(m);
                            }; break;
                    }

                }
                var bindingList = new BindingList<Materia>(mats);
                var source = new BindingSource(bindingList, null);
                dgv1.DataSource = source;
                dgv1.Columns["IdMat"].HeaderText = "Código da Matéria";
            }
            catch { MessageBox.Show("Ocorreu Um erro"); }
        }

        //Pesquisa de Turma
        public void PesqTur()
        {
            try
            {
                List<Turma> turmas = new List<Turma>();
                if (txtfiltro.Text == null || txtfiltro.Text == "")
                {
                    var search = from t in context.Turmas select t;
                    foreach (var t in search)
                    {
                        turmas.Add(t);
                    }
                }
                else
                {
                    switch (att)
                    {
                        case 0:
                            var search = from t in context.Turmas where t.CodTurma == int.Parse(txtfiltro.Text) select t;
                            foreach (var t in search)
                            {
                                turmas.Add(t);
                            }
                            ; break;
                        case 1:
                            search = from t in context.Turmas where t.Sala == txtfiltro.Text select t;
                            foreach (var t in search)
                            {
                                turmas.Add(t);
                            }
                            ; break;
                        case 2:
                            search = from t in context.Turmas where t.NumAlunos == int.Parse(txtfiltro.Text) select t;
                            foreach (var t in search)
                            {
                                turmas.Add(t);
                            }
                            ; break;
                        case 3:
                            search = from t in context.Turmas where t.Horario == txtfiltro.Text select t;
                            foreach (var t in search)
                            {
                                turmas.Add(t);
                            }
                            ; break;
                    }
                }
                var bindingList = new BindingList<Turma>(turmas);
                var source = new BindingSource(bindingList, null);
                dgv1.DataSource = source;
                dgv1.Columns["CodTurma"].HeaderText = "Código da Turma";
                dgv1.Columns["NumAlunos"].HeaderText = "Numero de Alunos";
                dgv1.Columns["Alunos"].Visible = false;
            }
            catch { MessageBox.Show("Ocorreu Um erro"); }
        }

        public void ShowFilter(bool c)
        {
            lbl_filtro.Visible = c;
            txtfiltro.Visible = c;
            if (c)
            {
                btncons.Enabled = c;
            }
        }

        public void LimpaDG()
        {
            dgv1.Rows.Clear();
            dgv1.DataSource = null;
        }
    }
}
