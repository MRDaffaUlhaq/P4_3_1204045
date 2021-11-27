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

namespace P4_3_1204045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void huruf_Leave(object sender, EventArgs e)
        {
            if (huruf.Text == "")
            {
                epWarning.SetError(huruf, "Textbox huruf tidak boleh kosong!");
                epWrong.SetError(huruf, "");
                epCorrect.SetError(huruf, "");
            }
            else
            {
                if ((huruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(huruf, "");
                    epWrong.SetError(huruf, "");
                    epCorrect.SetError(huruf, "Correct");
                }
                else
                {
                    epWarning.SetError(huruf, "");
                    epWrong.SetError(huruf, "Ups, harap inputkan huruf!");
                    epCorrect.SetError(huruf, "");
                }
            }
        }

        private void angka_Leave(object sender, EventArgs e)
        {
            if (angka.Text == "")
            {
                epWarning.SetError(angka, "Textbox angka tidak boleh kosong!");
                epWrong.SetError(angka, "");
                epCorrect.SetError(angka, "");
            }
            else
            {
                if ((angka.Text).All(Char.IsNumber))
                {
                    epWarning.SetError(angka, "");
                    epWrong.SetError(angka, "");
                    epCorrect.SetError(angka, "Correct");
                }
                else
                {
                    epWarning.SetError(angka, "");
                    epWrong.SetError(angka, "Ups, harap inputkan angka!");
                    epCorrect.SetError(angka, "");
                }
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                epWarning.SetError(email, "Textbox email tidak boleh kosong!");
                epWrong.SetError(email, "");
                epCorrect.SetError(email, "");
            }
            else
            {
                if (Regex.IsMatch(email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(email, "");
                    epWrong.SetError(email, "");
                    epCorrect.SetError(email, "Correct");
                }
                else
                {
                    epWarning.SetError(email, "");
                    epWrong.SetError(email, "Ups, format email salah!");
                    epCorrect.SetError(email, "");
                }
            }
        }

        private void angka1_Leave(object sender, EventArgs e)
        {
            if(angka2.Text != "")
            {
                if((int.Parse(angka1.Text) > int.Parse(angka2.Text)))
                {
                    epWarning.SetError(angka1, "Ups, angka 1 tidak boleh lebih besar dari angka 2");
                    epWrong.SetError(angka1, "");
                    epCorrect.SetError(angka1, "");
                }
                else { }
            }
        }

        private void angka2_Leave(object sender, EventArgs e)
        {
            if ((int.Parse(angka1.Text) > int.Parse(angka2.Text)))
            {
                epWarning.SetError(angka2, "Ups, angka 1 tidak boleh lebih besar dari angka 2");
                epWrong.SetError(angka2, "");
                epCorrect.SetError(angka2, "");
            }
            else { }
        }
    }
}
