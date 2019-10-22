using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Forma_Alunos
{
    public class MySQL_Conector
    {
		private static readonly MySQL_Conector instance = new MySQL_Conector();

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        static MySQL_Conector()
        {
        }

		private MySQL_Conector()
		{
			Initialize ();
		}

		public static MySQL_Conector Instance
		{
			get
			{
				return instance;
			}
		}

		//Initialize values
		private void Initialize()
        {
            server = "localhost";
            database = "biblioteca";
            uid = "root";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

		public string inserirLivroNovo(string ISBN, string titulo, string autor, string editora, string idioma, string edicao, string ano, string descricao )
		{
			string codigo = "";

			Random rnd = new Random ();

			for ( int i = 0; i < 4; i++ )
			{
				int temp = rnd.Next (65, 90);
				codigo += (char) temp;
			}

			string comando = "SELECT biblioteca.inserir_Livro(" + ISBN + ", '" + codigo + "', '" + titulo + "', '"
							+ autor + "', '" + editora + "', '" + idioma + "', " + edicao + ", " + ano + ", '" + descricao + "')";

			//open connection
			if ( this.OpenConnection () == true )
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand (comando, connection);

				//Execute command
				cmd.ExecuteNonQuery ();

				//close connection
				this.CloseConnection ();
			}

			return codigo;
		}

		public void inserirLivroExistente (string ISBN, string codigo, int quantia)
		{
			string comando = "SELECT COUNT(*) FROM biblioteca.livro_objeto WHERE idlivro LIKE '" + codigo + "%';";

			int count = new int();

			MySqlCommand cmd;

			if ( this.OpenConnection () == true )
			{
				cmd = new MySqlCommand (comando, connection);
				MySqlDataReader dataReader = cmd.ExecuteReader ();
				dataReader.Read ();
				count = Int32.Parse (dataReader["COUNT(*)"].ToString ()) + 1;
				this.CloseConnection ();
			}

			if ( this.OpenConnection () == true )
			{
				for ( int i = count; i < quantia + count; i++ )
				{
					comando = "INSERT INTO livro_objeto(idLivro, isbn) values ('" + codigo + i.ToString("D3") + "', '" + ISBN + "')";
					cmd = new MySqlCommand (comando, connection);
					cmd.ExecuteNonQuery ();
				}
			this.CloseConnection ();
			}
		}

		public void editarLivro( string ISBN, string titulo, string idioma, string edicao, string ano, string destricao )
		{
			string comando =	"UPDATE biblioteca.livro " + 
								"SET " + 
								"	titulo = '" + titulo + "', " +
								"	idioma = '" + idioma + "', " +
								"	edicao = '" + edicao + "', " +
								"	ano = '" + ano + "', " +
								"	descricao = '" + destricao +"' " +
								"WHERE ISBN = '" + ISBN +"';";

			//open connection
			if ( this.OpenConnection () == true )
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand (comando, connection);

				//Execute command
				cmd.ExecuteNonQuery ();

				//close connection
				this.CloseConnection ();
			}
		}

		public List<Livros> Pesquisa_Multi_Livros( string busca, int tipo )
		{
			string comando = "SELECT ISBN, titulo, codigo, autor.nome as autorNome, editora.nome as editoraNome, idioma, edicao, ano , descricao FROM livro " +
							 "INNER JOIN autor ON (livro.idAutor = autor.idAutor) INNER JOIN editora ON (livro.idEditora = editora.idEditora) ";

			switch ( tipo )
			{
				case 0:
					comando += "WHERE livro.titulo LIKE '%" + busca + "%'";
					break;
				case 1:
					comando += "WHERE livro.idAutor IN (SELECT autor.idAutor FROM autor WHERE nome LIKE '%" + busca + "%')";
					break;
				case 2:
					comando += "WHERE livro.ISBN LIKE '" + busca + "'";
					break;
				case 3:
					comando += "WHERE (livro.titulo LIKE '%" + busca + "%' OR livro.idAutor IN (SELECT autor.idAutor FROM autor WHERE nome LIKE '%" + busca + "%') OR livro.ISBN LIKE '" + busca + "')";
					break;
				default:
					return null;
			}

			//Create a list to store the result
			List<Livros> lista = new List<Livros> ();

			//Open connection
			if ( this.OpenConnection () == true )
			{
				//Create Command
				MySqlCommand cmd = new MySqlCommand (comando, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader ();


				while ( dataReader.Read () )
				{
					lista.Add (new Livros ("" + dataReader["ISBN"],
									   	   "" + dataReader["codigo"],
										   "" + dataReader["titulo"],
										   "" + dataReader["autorNome"],
										   "" + dataReader["editoraNome"],
										   "" + dataReader["idioma"],
										   "" + dataReader["edicao"],
										   "" + dataReader["ano"],
										   "" + dataReader["descricao"]));
				}

				//close Data Reader
				dataReader.Close ();

				//close Connection
				this.CloseConnection ();
			}

			return lista;
		}

		public Livros Pesquisa_unico_Livro( string busca, int tipo )
		{
			string comando = "SELECT ISBN, titulo, codigo, autor.nome as autorNome, editora.nome as editoraNome, idioma, edicao, ano , descricao FROM livro " +
							 "INNER JOIN autor ON (livro.idAutor = autor.idAutor) INNER JOIN editora ON (livro.idEditora = editora.idEditora) ";

			switch ( tipo )
			{
				case 0:
					comando += "WHERE livro.ISBN LIKE '" + busca + "'";
					break;
				case 1:
					comando += "WHERE livro.codigo LIKE '" + busca + "'";
					break;
				default:
					return null;
			}

			//Create a list to store the result
			Livros livro = null;

			//Open connection
			if ( this.OpenConnection () == true )
			{
				//Create Command
				MySqlCommand cmd = new MySqlCommand (comando, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader ();


				while ( dataReader.Read () )
				{
					livro = new Livros ("" + dataReader["ISBN"],
										"" + dataReader["codigo"],
										"" + dataReader["titulo"],
										"" + dataReader["autorNome"],
										"" + dataReader["editoraNome"],
										"" + dataReader["idioma"],
										"" + dataReader["edicao"],
										"" + dataReader["ano"],
										"" + dataReader["descricao"]);
				}

				//close Data Reader
				dataReader.Close ();

				//close Connection
				this.CloseConnection ();
			}

			if(livro != null)
			{
				comando = "SELECT count(*) as quantia FROM livro_objeto WHERE idlivro LIKE '" + livro.Codigo + "%'";

				//Open connection
				if ( this.OpenConnection () == true )
				{
					//Create Command
					MySqlCommand cmd = new MySqlCommand (comando, connection);
					//Create a data reader and Execute the command
					MySqlDataReader dataReader = cmd.ExecuteReader ();


					while ( dataReader.Read () )
					{
						livro.Numero_Exemplares = Int32.Parse ("" + dataReader["quantia"]);
					}

					//close Data Reader
					dataReader.Close ();

					//close Connection
					this.CloseConnection ();
				}
			}
			

			return livro;
		}

		public int emprestarLivro(string idAluno, string codigo )
		{
			string comando = "SELECT biblioteca.emprestar_Livro(" + idAluno + ", '" + codigo + "')";

			int temp = 0;

			//open connection
			if ( this.OpenConnection () == true )
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand (comando, connection);

				//Execute command
				temp = cmd.ExecuteNonQuery ();

				//close connection
				this.CloseConnection ();
			}

			MessageBox.Show (temp.ToString());

			return temp;
		}

		public void devolverLivro( string codigo )
		{
			string comando = "SELECT biblioteca.devolver_Livro('" + codigo + "')";

			//open connection
			if ( this.OpenConnection () == true )
			{
				//create command and assign the query and connection from the constructor
				MySqlCommand cmd = new MySqlCommand (comando, connection);

				//Execute command
				cmd.ExecuteNonQuery ();

				//close connection
				this.CloseConnection ();
			}
		}


		public void cadastrarUsuario (string nome, string email, string cpf, string endereco)
		{
			string comando = "INSERT INTO usuario(nome, email, CPF, endereco) VALUES ('" + nome + "', '" + email + "', '" + cpf +"', '" + endereco +"' )";

			if ( this.OpenConnection () == true )
			{
				MySqlCommand cmd = new MySqlCommand (comando, connection);
				cmd.ExecuteNonQuery ();
				this.CloseConnection ();
			}
		}

		public List<Aluno> Pesquisa_Aluno( string busca, int tipo )
		{
			string comando = "SELECT * FROM biblioteca.usuario ";

			switch ( tipo )
			{
				case 0:
					comando += "WHERE nome like '%" + busca + "%'";
					break;
				case 1:
					comando += "WHERE idUsuario like '" + busca + "'";
					break;
				case 2:
					comando += "WHERE CPF like '" + busca + "'";
					break;
				default:
					return null;
			}

			//Create a list to store the result
			List<Aluno> lista = new List<Aluno> ();

			//Open connection
			if ( this.OpenConnection () == true )
			{
				//Create Command
				MySqlCommand cmd = new MySqlCommand (comando, connection);
				//Create a data reader and Execute the command
				MySqlDataReader dataReader = cmd.ExecuteReader ();


				while ( dataReader.Read () )
				{
					lista.Add (new Aluno ("" + dataReader["idUsuario"],
										  "" + dataReader["nome"],
										  "" + dataReader["CPF"],
										  "" + dataReader["email"],
										  "" + dataReader["endereco"],
										  "" + dataReader["multaTotal"],
										  "" + dataReader["status"]));
				}

				//close Data Reader
				dataReader.Close ();

				//close Connection
				this.CloseConnection ();
			}

			return lista;
		}

	}
}
