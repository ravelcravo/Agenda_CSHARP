using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agenda001
{
    public partial class frmCadastroContato : Form
    {
        public string operacao = "";
        public frmCadastroContato()
        {
            InitializeComponent();
        }

        public void LimpaCheckbox()
        {
            ckbExclusivo.Checked = false;
        }
        public void AlteraBotoes(int op)
        {
            pDados.Enabled = false;
            btInserir.Enabled = false;
            btLocalizar.Enabled = false;
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;
            btCancelar.Enabled = false;
            ckbExclusivo.Enabled = false;
            dtTimer.Enabled = false;

            if(op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }

            if(op == 2)
            {
                pDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
                ckbExclusivo.Enabled = true;
                dtTimer.Enabled = true;

            }

            if(op == 3)
            {
                btExcluir.Enabled = true;
                btAlterar.Enabled = true;
                btCancelar.Enabled = true;
            }
        }
        public void LimpaCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtData.Clear();
            txtParticipantes.Clear();
        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                if(txtNome.Text.Length <= 0)
                {
                    MessageBox.Show("Os campos nome do evento e data são obrigatórios!");
                    return;
                }
                if (txtData.Text.Length <= 0)
                {
                    MessageBox.Show("Os campos nome do evento e data são obrigatórios!");
                    return;
                }
                contato.Nome = txtNome.Text;
                contato.Data = txtData.Text;
                contato.Participantes = txtParticipantes.Text;
                contato.Descricao = txtDescricao.Text;
                
                String strConexao = "Data Source=DESKTOP-7LHKOP8;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);



                if (this.operacao == "inserir")
                {
                    dal.Incluir(contato);
                    MessageBox.Show("O Evento '" + contato.Nome.ToString() + "' foi adicionado à sua agenda com sucesso!");
                }
                else
                {
                    contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                    dal.Alterar(contato);
                    MessageBox.Show("O Evento foi alterado!");
                    //altera o contato que esta na tela
                }
                this.AlteraBotoes(1);
                this.LimpaCampos();
                this.LimpaCheckbox();
                this.voltaData();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaContatos f = new frmConsultaContatos();
            f.ShowDialog();

            if(f.codigo != 0)
            {
                String strConexao = "Data Source=DESKTOP-7LHKOP8;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                Contato contato = dal.carregaContato(f.codigo);
                txtCodigo.Text = contato.Codigo.ToString();
                txtNome.Text = contato.Nome;
                txtDescricao.Text = contato.Descricao;
                txtParticipantes.Text = contato.Participantes;
                txtData.Text = contato.Data;
                this.AlteraBotoes(3);

            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            if(d.ToString() == "Yes")
            {
                String strConexao = "Data Source=DESKTOP-7LHKOP8;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                dal.Excluir(Convert.ToInt32(txtCodigo.Text));
                this.AlteraBotoes(1);
                this.LimpaCampos();
            }
        }

        public void ckbExclusivo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbExclusivo.Checked == true)
            {
                Contato.Exclusivo = 1;
            }
            else
            {
                Contato.Exclusivo = 0;
            }
        }

        public void voltaData()
        {
            dtTimer.Value = DateTime.Now;
        }
        public void dtTimer_ValueChanged(object sender, EventArgs e)
        {
            txtData.Text = dtTimer.Text;
            
        }
    }
}
