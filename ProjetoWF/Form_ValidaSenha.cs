using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWF
{
    public partial class Form_ValidaSenha : Form
    {

        bool VerSenha = false;
        public Form_ValidaSenha()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_ValidaSenha_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Checar_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Lbl_Senha.Text = "";
        }

        private void Txt_Msg_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Msg.Text);
            Lbl_Senha.Text = forca.ToString();

            if(Lbl_Senha.Text == "Inaceitavel" | Lbl_Senha.Text == "Fraca")
            {
                Lbl_Senha.ForeColor = Color.Red;
                
            }
            if (Lbl_Senha.Text == "Aceitavel")
            {
                Lbl_Senha.ForeColor = Color.Blue;
               
            }

            if (Lbl_Senha.Text == "Forte" | Lbl_Senha.Text == "Segura")
            {
                Lbl_Senha.ForeColor = Color.Green;
               
            }
        }

        private void Txt_Msg_ParentChanged(object sender, EventArgs e)
        {

        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if(VerSenha == false)
            {
                Txt_Msg.PasswordChar = '\0';
                VerSenha = true;
                Btn_VerSenha.Text = "Esconder Senha";
            }
            else
            {
                Txt_Msg.PasswordChar = '*';
                VerSenha = false;
                Btn_VerSenha.Text = "Ver Senha";
            }
            
        }

        private void Lbl_Senha_Click(object sender, EventArgs e)
        {

        }
    }

    public class ChecaForcaSenha
    {

        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas +
                pontosPorMaiusculas + pontosPorDigitos +
                pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }

        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }
}
