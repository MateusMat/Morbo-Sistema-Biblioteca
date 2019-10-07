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
        public string Titulo { set; get; }
        public string Autor { set; get; }
        public string Editora { set; get; }
		public string Idioma { set; get; }
		public string Edicao { set; get; }
		public string Ano { set; get; }
		public string Descricao { set; get; }

		public Livros( string isbn, string titulo, string autor, string editora, string edicao, string ano )
		{
			ISBN = isbn;
			Titulo = ToTitleCase (titulo);
			Autor = ToTitleCase (autor);
			Editora = ToTitleCase (editora);
			Edicao = edicao;
			Ano = ano;
		}

		public Livros(string isbn, string titulo, string autor, string editora, string idioma, string edicao, string ano, string descricao)
        {
            ISBN = isbn;
            Titulo = ToTitleCase(titulo);
            Autor = ToTitleCase (autor);
            Editora = ToTitleCase (editora);
			Idioma = ToTitleCase (idioma);
			Edicao = edicao;
            Ano = ano;
			Descricao = descricao;
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
