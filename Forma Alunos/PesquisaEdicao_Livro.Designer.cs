namespace Forma_Alunos
{
	partial class PesquisaEdicao_Livro
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pesquisa_Livro1 = new Forma_Alunos.Pesquisa_Livro();
			this.editar_Livro1 = new Forma_Alunos.Editar_Livro();
			this.SuspendLayout();
			// 
			// pesquisa_Livro1
			// 
			this.pesquisa_Livro1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pesquisa_Livro1.Location = new System.Drawing.Point(0, 0);
			this.pesquisa_Livro1.Margin = new System.Windows.Forms.Padding(4);
			this.pesquisa_Livro1.Name = "pesquisa_Livro1";
			this.pesquisa_Livro1.Size = new System.Drawing.Size(640, 480);
			this.pesquisa_Livro1.TabIndex = 0;
			// 
			// editar_Livro1
			// 
			this.editar_Livro1.Font = new System.Drawing.Font("Verdana", 9.75F);
			this.editar_Livro1.Location = new System.Drawing.Point(0, 0);
			this.editar_Livro1.Margin = new System.Windows.Forms.Padding(4);
			this.editar_Livro1.Name = "editar_Livro1";
			this.editar_Livro1.Size = new System.Drawing.Size(640, 480);
			this.editar_Livro1.TabIndex = 1;
			// 
			// PesquisaEdicao_Livro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pesquisa_Livro1);
			this.Controls.Add(this.editar_Livro1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PesquisaEdicao_Livro";
			this.Size = new System.Drawing.Size(640, 480);
			this.ResumeLayout(false);

		}

		#endregion

		private Pesquisa_Livro pesquisa_Livro1;
		private Editar_Livro editar_Livro1;
	}
}
