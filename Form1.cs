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
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        



        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema4; // ativar tema 4
            Rad_Padrao.ForeColor = Color.White; //voltar a cor branca padrao
            Rad_T1.ForeColor = Color.White; //voltar a cor branca t1
            Rad_T2.ForeColor = Color.White; //voltar a cor brancat2
            Rad_T3.ForeColor = Color.White; //voltar a cor branca t3
            Rad_T4.ForeColor = Color.Red; // destacara fonte t4 
            Rad_T5.ForeColor = Color.White; //voltar a cor branca t5
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rad_T3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema3; // ativar tema 3
            Rad_Padrao.ForeColor = Color.White;// voltar a cor preta padrao
            Rad_T1.ForeColor = Color.White; // voltar a cor branca t1
            Rad_T2.ForeColor = Color.White; // voltar a cor branca t2
            Rad_T3.ForeColor = Color.Red; // destacar a cor da fonte  t3
            Rad_T4.ForeColor = Color.White; //  voltar a cor preta t4
            Rad_T5.ForeColor = Color.White; //  voltar a cor preta t5
        }

        private void Rad_Padrao_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.padrao;//ativar tema padão
            Rad_Padrao.ForeColor = Color.Red; // destacar a cor da fonte paddrao
            Rad_T1.ForeColor = Color.White;// voltar a cor preta t1
            Rad_T2.ForeColor = Color.White;// voltar a cor preta t2
            Rad_T3.ForeColor = Color.White;//  voltar a cor preta t3
            Rad_T4.ForeColor = Color.White;//  voltar a cor preta t4
            Rad_T5.ForeColor = Color.White; // voltar a cor preta t5

        }

        private void Rad_T1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema1; //ativar tema tema 1
            Rad_T1.ForeColor = Color.Red; // destacar a fonte t1
            Rad_Padrao.ForeColor = Color.White; // voltar a cor branca padrao
            Rad_T2.ForeColor = Color.White; // voltar a cor preta t2               
            Rad_T3.ForeColor = Color.White; //voltar a cor branca t3
            Rad_T4.ForeColor = Color.White; //voltar a cor branca t4
            Rad_T5.ForeColor = Color.White; //voltar a cor branca t5
        }

        private void Rad_T2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Tema_2; // ativar tema 2
            Rad_T2.ForeColor = Color.Red; // destacar a fonte t2
            Rad_Padrao.ForeColor = Color.White; // voltar a cor preta padrao
            Rad_T1.ForeColor = Color.White; // voltar a cor preta t1
            Rad_T3.ForeColor = Color.White; // voltar a cor preta t3
            Rad_T4.ForeColor = Color.White; // voltar a cor preta t4
            Rad_T5.ForeColor = Color.White; //voltar a cor branca t5
        }

        private void Rad_T5_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema5; // ativar tema 5
            Rad_Padrao.ForeColor = Color.White; //  voltar a cor preta padrao
            Rad_T1.ForeColor = Color.White; //  voltar a cor preta t1
            Rad_T2.ForeColor = Color.White; //  voltar a cor preta t2
            Rad_T3.ForeColor = Color.White; //  voltar a cor preta t3
            Rad_T4.ForeColor = Color.White; //  voltar a cor preta t4
            Rad_T5.ForeColor = Color.Red; //  destacar a a fonte t5


        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_nome.Text; // enviar nome

        }

        private void Rad_masc_CheckedChanged(object sender, EventArgs e)
        {
            Pic_masc.Image = Properties.Resources.menino; // masculino imagem 
            Pic_femi.Visible = false; // tirar imagem mulher
            Pic_masc.Visible = true; // colocar imagem homem
            Pic_outro.Visible = false; // tirar imagem outro
            Txt_Genero.Text = Rad_masc.Text; // colocar o nome masculino
            Rad_femi.ForeColor = Color.White; // ativar cor branca feminino
            Rad_masc.ForeColor = Color.Red; // ativar cor vermelha masculino
            Rad_outro.ForeColor = Color.White; //ativar cor branca outro
        }

        private void Btn_Sob_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = txt_Sob.Text; // enziar sobrenome
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_Idade.Text; // Enviar Idade
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_Bairro.Text; // enviar bairro
        }

        private void Lbl_Bairro_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cllr_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_Cllr.Text; // enviar cllr

        }

        private void Btn_Mail_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_Mail.Text; // enviar E-mail
        }

        private void Btn_Genero_Click(object sender, EventArgs e)
        {
            Lbl_resu.Text = Txt_Genero.Text; // enviar Genero

        }

        private void Pic_masc_Click(object sender, EventArgs e)
        {

        }

        private void Rad_femi_CheckedChanged(object sender, EventArgs e)
        {
            Pic_femi.Image = Properties.Resources.menina; // imagem menina
            Pic_outro.Visible = false;// tirar imagem outro
            Pic_masc.Visible = false;// tirar imagem homem
            Pic_femi.Visible = true;// colocar imagem mulher
            Txt_Genero.Text = Rad_femi.Text; // colocar o nome feminino
            Rad_femi.ForeColor = Color.Red; // ativar cor vermelha feminino
            Rad_masc.ForeColor = Color.White; // ativar cor branca homem
            Rad_outro.ForeColor = Color.White; // ativar cor branca outro

        }

        private void Rad_outro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_outro.Image = Properties.Resources.outro; // imagem outro
            Pic_masc.Visible = false; // tirar imagem homem
            Pic_femi.Visible = false; // tirar imagem mulher
            Pic_outro.Visible = true; // colocar imagem outro
            Txt_Genero.Text = Rad_outro.Text;// colocar o nome outro 
            Rad_outro.ForeColor = Color.Red; // ativar cor vermelha outro
            Rad_femi.ForeColor = Color.White; // ativar cor branca mulher
            Rad_masc.ForeColor = Color.White; // ativar cor branca homem
        }

        private void Btn_EnviarTd_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_limp_Click(object sender, EventArgs e)
        { // limpar os dados
            Controls.Clear();
            InitializeComponent();
        }

        private void Btn_desa_Click(object sender, EventArgs e)
        {
            Grp_Tema.Enabled = false; // desativar tema 
            Gpr_Dado.Enabled = false; // desativar dados
            Btn_desa.Enabled = false; // destivat btn desativar
            Btn_limp.Enabled = false; // destivat btn limpar
            btn_ative.Enabled = true; // ativar btn ativar
        }

        private void Grp_Tema_Enter(object sender, EventArgs e)
        {

        }

        private void Pic_femi_Click(object sender, EventArgs e)
        {

        }

        private void Pic_outro_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Genero_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Genero_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Btn_EnviarTd_Click_1(object sender, EventArgs e)
        {
            frm_Confirm frm_Confirm = new frm_Confirm(); // criando um objeto frm_confirm para chamar a proxima tela 
            frm_Confirm.Lbl_resu2.Text = "NOME:"+ "  " + Txt_nome.Text + " " + txt_Sob.Text + 
                " \n\n " + "IDADE:" + "  "  +Txt_Idade.Text +" Anos" +
                " \n\n " + "BAIRRO:" + "  " + Txt_Bairro.Text +
                " \n\n " + "CELULAR:" + "  " + Txt_Cllr.Text +
                " \n\n " + "E-MAIL:" + "  " + Txt_Mail.Text +
                " \n\n " + "GENERO:" + "  " + Txt_Genero.Text; // enviando nome e sobrenome do cliente enviando Bairro do Cliente  enviando Cllr do Cliente  enviando E-Mail do cliente enviando Genero do cliente
            frm_Confirm.BackgroundImage = BackgroundImage; // enviando imagem 
            frm_Confirm.Show(); // abrir a tela frm_confirm
            Hide(); // esconder a tela
        }

        private void Txt_Mail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txt_Cllr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sob_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_Cllr_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_mail_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Cdd_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_resu_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Idade_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Sob_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ative_Click(object sender, EventArgs e)
        {
            Grp_Tema.Enabled = true; // ativar tema 
            Gpr_Dado.Enabled = true; // ativar dados
            Btn_desa.Enabled = true; // ativar btn desativar 
            Btn_limp.Enabled = true;// ativar btn limpar
            btn_ative.Enabled = false; // desativar btn ativar 
        }

        private void Gpr_Dado_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
} 
       






