using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcLau
{
    public partial class CalcLau : Form
    {
        private string operador;

        public CalcLau()
        {
            InitializeComponent();

            CalcLogic.setValorDigitado(0);
            CalcLogic.setValorExibido("0");

            lblValorDigitado.Text = CalcLogic.getValorExibido();
            lblValorDigitado2.Text = CalcLogic.getValorExibido2();
            lblOperador.Text = "";
            lblResultado.Text = "";
        }

        private void atualizarOperador(string operador)
        {
            lblValorDigitado.Text = CalcLogic.getValorExibido();
            lblValorDigitado2.Text = CalcLogic.getValorExibido2();
            lblOperador.Text = operador;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(0);
            lblValorDigitado.Text = CalcLogic.getValorExibido();            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(1);
            lblValorDigitado.Text = CalcLogic.getValorExibido();            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(2);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(3);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(4);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(5);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(6);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(7);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(8);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            CalcLogic.digitar(9);
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CalcLogic.setValorDigitado(0);
            CalcLogic.setValorExibido("0");
            lblValorDigitado.Text = CalcLogic.getValorExibido();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            CalcLogic.resetar();
            lblValorDigitado.Text = CalcLogic.getValorExibido();
            lblValorDigitado2.Text = "";
            lblResultado.Text = "";
            lblOperador.Text = "";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            CalcLogic.atualizar();
            this.atualizarOperador("+");
            this.operador = "soma";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            CalcLogic.atualizar();
            this.atualizarOperador("-");
            this.operador = "sub";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            CalcLogic.atualizar();
            this.atualizarOperador("x");
            this.operador = "multi";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            CalcLogic.atualizar();
            this.atualizarOperador("÷");
            this.operador = "div";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            CalcLogic.operar(this.operador);
            lblResultado.Text = CalcOp.getResultado();
        }
    }
}
