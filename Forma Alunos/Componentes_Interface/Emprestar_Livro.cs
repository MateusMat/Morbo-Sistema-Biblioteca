using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_Alunos.Componentes_Interface
{
	public partial class Emprestar_Livro : UserControl
	{
		private MySQL_Conector conector;

		public Emprestar_Livro()
		{
			InitializeComponent ();
			conector = MySQL_Conector.Instance;
		}

		private void BotaoCanfirmar_Click( object sender, EventArgs e )
		{
			conector.emprestarLivro (AlunoTextBox.Text, CodigotextBox.Text);
		}
	}
}
