using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Forma_Alunos
{
    class Livros
    {
        public string ID { set; get; }
        public string Titulo { set; get; }
        public string Autor { set; get; }
        public string Editora { set; get; }
        public string Edicao { set; get; }
		public string Ano { set; get; }

		public Livros()
        {
            ID = "";
            Titulo = "";
            Autor = "";
            Editora = "";
			Edicao = "";
            Ano = "";
        }

        public Livros(string id, string titulo, string autor)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            
        }

        public Livros(string id, string titulo, string autor, string editora, string edicao, string ano)
        {
            ID = id;
            Titulo = ToTitleCase(titulo);
            Autor = ToTitleCase (autor);
            Editora = ToTitleCase (editora);
			Edicao = edicao;
            Ano = ano;
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
