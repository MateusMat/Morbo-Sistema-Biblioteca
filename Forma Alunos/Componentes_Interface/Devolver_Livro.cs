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
	public partial class Devolver_Livro : UserControl
	{

		private MySQL_Conector conector;

		public Devolver_Livro()
		{
			InitializeComponent ();
			conector = MySQL_Conector.Instance;
		}

		private void BotaoConfirmar_Click( object sender, EventArgs e )
		{
			conector.devolverLivro (CodigotextBox.Text);
		}
	}
}
