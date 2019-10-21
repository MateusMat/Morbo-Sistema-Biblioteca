using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forma_Alunos
{
    public class Aluno
    {
		public int RA { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Email { get; set; }
		public string Endereco { get; set; }
		public float Multa { get; set; }
		public bool Status { get; set; }

        public Aluno(string ra, string nome, string cpf, string email, string endereco, string multa, string status)
        {
			RA = Int32.Parse (ra);
            Nome = nome;
			CPF = cpf;
			Email = email;
			Endereco = endereco;
			Multa = float.Parse (multa);
			if ( status == "1" )
				Status = true;
			else
				Status = false;
        }

        public override string ToString()
        {
            return Nome + ", " + RA.ToString();
        }
    }

}
