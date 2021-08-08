/*
 * Criado por Luiz Henrique
 * Data: 08/08/2021
 * Hora: 17:53
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Senha_Random_GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void btnClick(object sender, EventArgs e)
		{
			if(textBox1.Text.Trim() == string.Empty || textBox1.Text == "0")
			{
				lblRes.ForeColor = System.Drawing.Color.Red;
				lblRes.Text = "Entrada Invalida!" ;
			}else{
				lblRes.ResetText();
				int c;
				FileStream file = new FileStream("Senhas.txt", FileMode.Append);
				StreamWriter write = new StreamWriter(file);
				Random rng = new Random();
				var lista = new List<char>(){'a','b','c','d','e','f','g','h','i','j','k','l',
											'm','n','o','p','q','r','s','t','u','v','x','w','y','z',
											'A','B','C','D','E','F','G','H','I','J','K','L','M','N',
											'O','P','Q','R','S','T','U','V','X','W','Y','Z','0','1',
											'2','3','4','5','6','7','8','9','_','-','@','#','%',
											'>','<','=','/'
											};
				int.TryParse(textBox1.Text, out c);
				write.Write("("+DateTime.Now+") Nova Senha: ");
				for(int i = 1; i <= c; i++)
				{
					write.Write(lista[rng.Next(0, 70)]);
				}
				lblRes.ForeColor = System.Drawing.Color.Green;
				lblRes.Text = "Senha Gerada com Sucesso";
				write.WriteLine();
				write.Close();
				textBox1.Clear();
			}
		}
		
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}
	}
}
