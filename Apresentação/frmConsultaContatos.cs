using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace agenda001
{
    public partial class frmConsultaContatos : Form
    {
        public int codigo = 0;
        public frmConsultaContatos()
        {
            InitializeComponent();
        }

        private void btExecutar_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao("Data Source=DESKTOP-7LHKOP8;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.Localizar(txtValor.Text);
        }



        private void dgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btLocalizaTodos_Click(object sender, EventArgs e)
        {
            Conexao cx = new Conexao("Data Source=DESKTOP-7LHKOP8;Integrated Security=True");
            DALContato dal = new DALContato(cx);
            dgDados.DataSource = dal.LocalizarTodos(txtValor.Text);
        }
    }
}
