using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraCSHARP;



namespace agenda001
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            frmCadastroContato f = new frmCadastroContato();
            f.ShowDialog();
            f.Dispose();

        }
        public void fecharApp()
        {
            Application.Exit();
            this.fecharApp();
        }

        private void btCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora frmCalculadora = new frmCalculadora();
            frmCalculadora.Show();
        }
    }
}
