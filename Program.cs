/*
 * Criado por Luiz Henrique
 * Data: 08/08/2021
 * Hora: 17:53
 */
using System;
using System.Windows.Forms;

namespace Senha_Random_GUI
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
