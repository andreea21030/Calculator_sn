using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Operatii opAritmetice = new Operatii();
        //String operatii = "";
        //Double valoare = 0;
        //bool calc = true;
        //bool EsteZecimal = true;

        public Form1()
        {
            InitializeComponent();
            opAritmetice.EsteOperatii = true;
            opAritmetice.EsteZecimal = true;
        }
             
        
        private void buttonCifre_Click(object sender, EventArgs e)
        {
            //lblRezultat.Text = lblRezultat.Text + "7";
            if (lblRezultat.Text == "0" || opAritmetice.EsteOperatii)
                lblRezultat.ResetText();
            opAritmetice.EsteOperatii = false;

            Button buton = (Button)sender;
            if (buton.Text == ".")
            {
                //if(!lblRezultat.Text.Contains("."))
                if (opAritmetice.EsteZecimal)
                {
                    lblRezultat.Text = lblRezultat.Text + buton.Text;
                    opAritmetice.EsteZecimal = false;
                }
            }else
            lblRezultat.Text = lblRezultat.Text + buton.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //lblRezultat.Text = "";
            lblRezultat.ResetText();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            
            lblRezultat.Text = "0";
        }

        private void ButtonOperatii_Click(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            opAritmetice.Operatori = buton.Text;
            opAritmetice.Valoare01 = double.Parse(lblRezultat.Text);
            opAritmetice.EsteOperatii = true;
            opAritmetice.EsteZecimal = true;


        }

        private void buttonRezultat_Click(object sender, EventArgs e)
        {
            switch (opAritmetice.Operatori)
            {
                case "+":
                    lblRezultat.Text = Operatii.Adunare(opAritmetice.Valoare01, double.Parse(lblRezultat.Text)).ToString();
                    break;
                case "-":
                    lblRezultat.Text = Operatii.Scadere(opAritmetice.Valoare01, double.Parse(lblRezultat.Text)).ToString();
                    break;
                case "X":
                    lblRezultat.Text = Operatii.Inmultire(opAritmetice.Valoare01, double.Parse(lblRezultat.Text)).ToString();
                    break;
                case "/":
                    lblRezultat.Text = Operatii.Impartire(opAritmetice.Valoare01, double.Parse(lblRezultat.Text)).ToString();
                    break;
                default:
                    break;

            }
            opAritmetice.EsteOperatii = true;
            opAritmetice.EsteZecimal = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button02.PerformClick();
                    break;
                case "3":
                    button03.PerformClick();
                    break;
                case "4":
                    button04.PerformClick();
                    break;
                case "5":
                    button05.PerformClick();
                    break;
                case "6":
                    button06.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button09.PerformClick();
                    break;
                case ".":
                    buttonPunct.PerformClick();
                    break;
                case "+":
                    buttonPlus.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonInmu.PerformClick();
                    break;
                case "/":
                    buttonImp.PerformClick();
                    break;
                case " ":
                    buttonRezultat.PerformClick();
                    break;
                case "\r":
                    buttonRezultat.PerformClick();
                    break;
                default:
                    break;
            }
            if (e.KeyChar == (char)Keys.Escape)
                lblRezultat.Text = "0";
        }
    }
}
