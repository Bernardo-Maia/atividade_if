using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_IF_11901071
{
    public partial class Form1 : Form
    {
        public int conta = 0;
        public int logado = 0;
        public int dinheiro = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsenha_Click(object sender, EventArgs e)
        {
            string senha = txtsenha.Text;
            if (senha == "") { MessageBox.Show("Digite a senha"); }
            else
            {
                if (senha == "1234") { lblresultado.Text = "Resultado: Acesso Permitido"; }
                else { lblresultado.Text = "Resultado: Acesso Negado"; }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btndesconto_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtquantidade.Text);
            double  desconto= 0, valor = int.Parse(txtvalor.Text);
            if (txtproduto.Text == "" || txtquantidade.Text == "" || txtvalor.Text == "") { MessageBox.Show("Digite todos os campos"); } else
            {
                valor = valor * quantidade;
                if (quantidade <= 5) { desconto = valor * 0.98; }
                if (quantidade >= 6) { desconto = valor * 0.97; }
                if (quantidade > 10) { desconto = valor * 0.95; }
                
                
                lbldesc.Text = "total da compra: " + quantidade + " unidades do produto " + txtproduto.Text + " no valor de R$" + valor + " com o desconto dicando R$ " + desconto;
                MessageBox.Show("" + (100 - 5) / 100);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsaque_Click(object sender, EventArgs e)
        {
            if (logado == 1)
            {
                dinheiro = dinheiro - int.Parse(txtdinheiro.Text);// adicionado  public int dinheiro = 0 no inicio do form
                lblconta.Text = "Dinheiro da conta " + conta + " R$" + dinheiro;}
            else { MessageBox.Show("Entre com uma conta antes"); }
        }

        private void txtdeposito_Click(object sender, EventArgs e)
        {
            if(logado == 1) {
                dinheiro = dinheiro + int.Parse(txtdinheiro.Text);
                lblconta.Text = "Dinheiro da conta " + conta + " R$" + dinheiro;}
            else { MessageBox.Show("Entre com uma conta antes"); }
        }

        private void txtentrar_Click(object sender, EventArgs e)
        {
            conta = int.Parse(txtconta.Text);// adicionado public int conta = 0; no inico do form
            logado = 1;// adicionado public int logado = 0; adicionado no inicio do form
            lblconta.Text = "Dinheiro da conta " + conta + " R$0";
        }

        private void btnordem_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            if(txtn1.Text == "" || txtn2.Text == "" || txtn3.Text == "") { MessageBox.Show("preencha todos os valors"); } else
            {
                n1 = int.Parse(txtn1.Text);
                n2 = int.Parse(txtn2.Text);
                n3 = int.Parse(txtn3.Text);
                if(n1 > n2 && n2 > n3) { lblordem.Text = n1 + ", " + n2 + ", " + n3; }
                if (n2 > n1 && n1 > n3) { lblordem.Text = n2 + ", " + n1 + ", " + n3; }
                if (n3 > n2 && n2 > n1) { lblordem.Text = n3 + ", " + n2 + ", " + n1; }
                if (n2 > n1 && n3 > n1) { lblordem.Text = n2 + ", " + n3 + ", " + n1; }
                if (n1 > n3 && n3 > n2) { lblordem.Text = n1 + ", " + n3 + ", " + n2; }
                if (n3 > n1 && n1 > n2) { lblordem.Text = n3 + ", " + n1 + ", " + n2; }
                if(n1 == n2 || n1 == n3 || n2 == n3) { lblordem.Text = "existem numeros iguais"; }
               

            }
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            int a1, a2, a3;
            if (txta1.Text == "" || txta2.Text == "" || txta3.Text == "") { MessageBox.Show("preencha todos os valors"); }
            else
            {
                a1 = int.Parse(txta1.Text);
                a2 = int.Parse(txta2.Text);
                a3 = int.Parse(txta3.Text);
                if(a1 == 90 || a2 == 90 || a3 == 90)
                {
                    lbltriangulo.Text = "É um triangulo Retângulo";
                }
                if (a1 > 90 || a2 > 90 || a3 > 90){

                    lbltriangulo.Text = "É um triangulo Obtusângulo";
                }
                if (a1 < 90 && a2 < 90 && a3 < 90) {
                    lbltriangulo.Text = "É um triangulo Acutângulo";
                }
            }
            }
    }
}
