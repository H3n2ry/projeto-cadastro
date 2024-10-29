using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_cadastro
{
    public partial class frm_Confirm : Form
    {
        public frm_Confirm()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro frm_Cadastro = new Frm_Cadastro();
            frm_Cadastro.Show(); // abrir aba cadastro
            Hide(); // ocultar aba confirm
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close(); // fechando pagina
        }

        private void Lbl_Cdd_Click(object sender, EventArgs e)
        {

        }

        private void frm_Confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
