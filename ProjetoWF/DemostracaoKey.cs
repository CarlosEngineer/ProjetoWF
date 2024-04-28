using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWF
{
    public partial class DemonstracaoKey : Form
    {
        public DemonstracaoKey()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DemonstracaoKey_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_Msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Msg_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            Txt_Msg.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t" + "Codigo da tecla: " + (int)e.KeyCode + "\r\n");
            Txt_Msg.AppendText("\t\t" + "Nome da tecla: " + e.KeyData + "\r\n");
            Lbl_Lower.Text = e.KeyCode.ToString().ToLower();
            Lbl_Upper.Text = e.KeyCode.ToString().ToUpper();
            
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Msg.Text = "";
            Txt_Input.Text = "";
            Lbl_Lower.Text = "";
            Lbl_Upper.Text = "";
        }
    }
}
