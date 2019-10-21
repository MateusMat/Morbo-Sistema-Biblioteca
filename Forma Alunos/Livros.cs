using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Forma_Alunos
{
    public class Livros
    {
        public string ISBN { set; get; }
		public string Codigo { set; get; }
		public string Titulo { set; get; }
        public string Autor { set; get; }
        public string Editora { set; get; }
		public string Idioma { set; get; }
		public string Edicao { set; get; }
		public string Ano { set; get; }
		public string Descricao { set; get; }
		public int Numero_Exemplares { set; get; }

		public Livros(string isbn, string codigo, string titulo, string autor, string editora, string idioma, string edicao, string ano, string descricao)
        {
            ISBN = isbn;
			Codigo = codigo;
            Titulo = ToTitleCase(titulo);
            Autor = ToTitleCase (autor);
            Editora = ToTitleCase (editora);
			Idioma = ToTitleCase (idioma);
			Edicao = edicao;
            Ano = ano;
			Descricao = descricao;
			Numero_Exemplares = -1;
        }

		public static string ToTitleCase( string title )
		{
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase (title.ToLower ());
		}

		public override string ToString()
        {
            return Titulo + ", " + Autor + " - " + Editora + ", " + Edicao + "ª Edição " + Ano + ";";
        }
    }
}
