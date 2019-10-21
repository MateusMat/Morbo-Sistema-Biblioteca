using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos
{
	public partial class Dados_Aluno : Form
	{
		public Dados_Aluno(Aluno aluno)
		{
			InitializeComponent ();
			NomeTextBox.Text = aluno.Nome;
			RATextBox.Text = aluno.RA.ToString();
			CPFTextBox.Text = aluno.CPF;
			emailTextBox.Text = aluno.Email;
			EnderecoTextBox.Text = aluno.Endereco;
			MultaTextBox.Text = "R$" + aluno.Multa.ToString();

			if ( ! (aluno.Multa > 0) )
				BotaoConfirmar.Hide ();
		}

		private void BotaoConfirmar_Click( object sender, EventArgs e )
		{
			Boleto janela = new Boleto ();
			janela.Show ();
		}
	}
}
