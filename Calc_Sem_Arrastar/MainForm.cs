/*
 * Criado por SharpDevelop.
 * Usuário: Asus
 * Data: 20/04/2023
 * Hora: 19:37
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calc_Sem_Arrastar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		TextBox txt1 = new TextBox();
		TextBox txt2 = new TextBox();
		TextBox txt3 = new TextBox();
		Button sub = new Button();
		Button soma = new Button();
		Button mult = new Button();
		Button div = new Button();
		Button raiz = new Button();
		Button nn = new Button();
		Label l1 = new Label();
		Label l2 = new Label();
		Label l3 = new Label();
		Label l4 = new Label();
		void MainFormLoad(object sender, EventArgs e)
		{
			this.BackColor = Color.AliceBlue;
			
			l1.Parent = this;
			l1.Left = 100;
			l1.Top = 60;
			l1.Text = "Primeiro número";
			
			l3.Parent = this;
			l3.Left = 220;
			l3.Top = 60;
			l3.Text = "Segundo número";
			
			l4.Parent = this;
			l4.Left = 340;
			l4.Top = 60;
			l4.Text = "Resultado";
			
			txt1.Parent = this;
			txt1.Left = 100;
			txt1.Top = 90;
			
			txt2.Parent = this;
			txt2.Left = 220;
			txt2.Top = 90;
			
			txt3.Parent = this;
			txt3.Left = 340;
			txt3.Top = 90;
			
			
			//primeiro botão
			sub.Parent = this;
			sub.Click += subClick;
			sub.Left = 100;
			sub.Top = 150;
			sub.Text = "Subtrair";
			sub.Width = 100;
			sub.Height = 30;
			sub.BackColor = Color.Azure;
			sub.TextAlign = ContentAlignment.MiddleCenter;
			
			//segundo botão
			soma.Parent = this;
			soma.Click += somaClick;
			soma.Left = 100;
			soma.Top = 200;
			soma.Text = "Somar";
			soma.Width = 100;
			soma.Height = 30;
			soma.BackColor = Color.Azure;
			soma.TextAlign = ContentAlignment.MiddleCenter;
			
			//terceiro botão
			mult.Parent = this;
			mult.Click += muClick;
			mult.Left = 220;
			mult.Top = 150;
			mult.Text = "Multiplicar";
			mult.Width = 100;
			mult.Height = 30;
			mult.BackColor = Color.Azure;
			mult.TextAlign = ContentAlignment.MiddleCenter;
			
			//quarto botão
			div.Parent = this;
			div.Click += diviClick;
			div.Left = 220;
			div.Top = 200;
			div.Text = "Dividir";
			div.Width = 100;
			div.Height = 30;
			div.BackColor = Color.Azure;
			div.TextAlign = ContentAlignment.MiddleCenter;
			
			//quinto botão
			raiz.Parent = this;
			raiz.Click += raiClick;
			raiz.Left = 340;
			raiz.Top = 150;
			raiz.Text = "Raiz";
			raiz.Width = 100;
			raiz.Height = 30;
			raiz.BackColor = Color.Azure;
			raiz.TextAlign = ContentAlignment.MiddleCenter;
			
			//sexto botão
			nn.Parent = this;
			nn.Click += nClick;
			nn.Left = 340;
			nn.Top = 200;
			nn.Text = "Potência";
			nn.Width = 100;
			nn.Height = 30;
			nn.BackColor = Color.Azure;
			nn.TextAlign = ContentAlignment.MiddleCenter;
			
			l2.Parent = this;
			l2.Left = 100;
			l2.Top = 250;
			l2.Text = "Por favor, se for usar a Raiz quadrada ou Potência só coloque o número no primeiro TextBox.";
			l2.Width = 340;
			l2.Height = 40;
			
		}
			
		void somaClick (object sender, EventArgs e)
		{
			decimal n1 = decimal.Parse (txt1.Text);
			decimal n2 = decimal.Parse (txt2.Text);
			decimal somar = n1 + n2;
			
			txt3.Text = somar.ToString();
			
			txt1.Clear();
			txt2.Clear();
		}
		
		void subClick (object sender, EventArgs e)
		{
			decimal n1 = decimal.Parse (txt1.Text);
			decimal n2 = decimal.Parse (txt2.Text);
			decimal subt = n1 - n2;
			
			txt3.Text = subt.ToString();
			
			txt1.Clear();
			txt2.Clear();
		
		}
		void muClick (object sender, EventArgs e)
		{
			decimal n1 = decimal.Parse (txt1.Text);
			decimal n2 = decimal.Parse (txt2.Text);
			decimal subt = n1 * n2;
			
			txt3.Text = subt.ToString();
			
			txt1.Clear();
			txt2.Clear();
		
		}
		void diviClick (object sender, EventArgs e)
		{
			decimal n1 = decimal.Parse (txt1.Text);
			decimal n2 = decimal.Parse (txt2.Text);
			decimal subt = n1 / n2;
			
			txt3.Text = subt.ToString();
			
			txt1.Clear();
			txt2.Clear();
		
		}
		void nClick (object sender, EventArgs e)
		{
			
            int n = int.Parse (txt1.Text);
            double r = Math.Pow(n,2);
			
			txt3.Text = r.ToString();
			
			txt1.Clear();
			txt2.Clear();
		
		}
		void raiClick (object sender, EventArgs e)
		{
			double primeiro = double.Parse(txt1.Text);
			double resutado = Convert.ToSingle(Math.Sqrt(primeiro));
			txt3.Text = resutado.ToString();
			
			txt1.Clear();
			txt2.Clear();
		
		}
		
	}

	}

