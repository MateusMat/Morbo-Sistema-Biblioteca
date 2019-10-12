using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos
{
	public partial class Cadastro_Usuario : UserControl
	{
		private MySQL_Conector conector;

		public Cadastro_Usuario()
		{
			InitializeComponent ();
			conector = MySQL_Conector.Instance;
		}

		private void BotaoCadastrar_Click( object sender, EventArgs e )
		{
			conector.cadastrarUsuario (NomeTextBox.Text, emailTextBox.Text, CPFTextBox.Text, EnderecoTextBox.Text);
		}
	}
}
