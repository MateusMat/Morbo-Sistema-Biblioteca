namespace Forma_Alunos
{
	partial class UserControl1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
			this.botaoPesquisarSQL = new System.Windows.Forms.Button();
			this.modoPesquisaSQL = new System.Windows.Forms.ComboBox();
			this.pesquisaLivroSQL = new System.Windows.Forms.TextBox();
			this.anoSQL = new System.Windows.Forms.TextBox();
			this.edicaoSQL = new System.Windows.Forms.TextBox();
			this.editoraSQL = new System.Windows.Forms.TextBox();
			this.tituloSQL = new System.Windows.Forms.TextBox();
			this.autorSQL = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.Display_LivrosSQL = new System.Windows.Forms.ListBox();
			this.label13 = new System.Windows.Forms.Label();
			this.botaoCadastrarSQL = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label16 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// botaoPesquisarSQL
			// 
			this.botaoPesquisarSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.botaoPesquisarSQL.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoPesquisarSQL.Location = new System.Drawing.Point(248, 440);
			this.botaoPesquisarSQL.Margin = new System.Windows.Forms.Padding(4);
			this.botaoPesquisarSQL.Name = "botaoPesquisarSQL";
			this.botaoPesquisarSQL.Size = new System.Drawing.Size(200, 39);
			this.botaoPesquisarSQL.TabIndex = 44;
			this.botaoPesquisarSQL.Text = "Pesquisar";
			this.botaoPesquisarSQL.UseVisualStyleBackColor = true;
			this.botaoPesquisarSQL.Click += new System.EventHandler(this.botaoPesquisarSQL_Click);
			// 
			// modoPesquisaSQL
			// 
			this.modoPesquisaSQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modoPesquisaSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.modoPesquisaSQL.Font = new System.Drawing.Font("Verdana", 12F);
			this.modoPesquisaSQL.FormattingEnabled = true;
			this.modoPesquisaSQL.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "Editora",
            "Todos"});
			this.modoPesquisaSQL.Location = new System.Drawing.Point(120, 448);
			this.modoPesquisaSQL.Name = "modoPesquisaSQL";
			this.modoPesquisaSQL.Size = new System.Drawing.Size(121, 26);
			this.modoPesquisaSQL.TabIndex = 43;
			// 
			// pesquisaLivroSQL
			// 
			this.pesquisaLivroSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pesquisaLivroSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pesquisaLivroSQL.Location = new System.Drawing.Point(120, 408);
			this.pesquisaLivroSQL.Margin = new System.Windows.Forms.Padding(4);
			this.pesquisaLivroSQL.Name = "pesquisaLivroSQL";
			this.pesquisaLivroSQL.Size = new System.Drawing.Size(328, 27);
			this.pesquisaLivroSQL.TabIndex = 42;
			this.pesquisaLivroSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyAlpha_KeyPress);
			// 
			// anoSQL
			// 
			this.anoSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.anoSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.anoSQL.Location = new System.Drawing.Point(320, 104);
			this.anoSQL.Margin = new System.Windows.Forms.Padding(4);
			this.anoSQL.Name = "anoSQL";
			this.anoSQL.Size = new System.Drawing.Size(128, 27);
			this.anoSQL.TabIndex = 38;
			this.anoSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNum_KeyPress);
			// 
			// edicaoSQL
			// 
			this.edicaoSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.edicaoSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edicaoSQL.Location = new System.Drawing.Point(120, 104);
			this.edicaoSQL.Margin = new System.Windows.Forms.Padding(4);
			this.edicaoSQL.Name = "edicaoSQL";
			this.edicaoSQL.Size = new System.Drawing.Size(128, 27);
			this.edicaoSQL.TabIndex = 36;
			this.edicaoSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNum_KeyPress);
			// 
			// editoraSQL
			// 
			this.editoraSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.editoraSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editoraSQL.Location = new System.Drawing.Point(120, 72);
			this.editoraSQL.Margin = new System.Windows.Forms.Padding(4);
			this.editoraSQL.Name = "editoraSQL";
			this.editoraSQL.Size = new System.Drawing.Size(328, 27);
			this.editoraSQL.TabIndex = 35;
			this.editoraSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyAlpha_KeyPress);
			// 
			// tituloSQL
			// 
			this.tituloSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tituloSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tituloSQL.Location = new System.Drawing.Point(120, 8);
			this.tituloSQL.Margin = new System.Windows.Forms.Padding(4);
			this.tituloSQL.Name = "tituloSQL";
			this.tituloSQL.Size = new System.Drawing.Size(328, 27);
			this.tituloSQL.TabIndex = 33;
			this.tituloSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyAlpha_KeyPress);
			// 
			// autorSQL
			// 
			this.autorSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.autorSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autorSQL.Location = new System.Drawing.Point(120, 40);
			this.autorSQL.Margin = new System.Windows.Forms.Padding(4);
			this.autorSQL.Name = "autorSQL";
			this.autorSQL.Size = new System.Drawing.Size(328, 27);
			this.autorSQL.TabIndex = 34;
			this.autorSQL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyAlpha_KeyPress);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(264, 104);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(62, 25);
			this.label15.TabIndex = 41;
			this.label15.Text = "Ano:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(35, 104);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 25);
			this.label14.TabIndex = 40;
			this.label14.Text = "Edição:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(27, 72);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 25);
			this.label11.TabIndex = 37;
			this.label11.Text = "Editora:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(40, 8);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 25);
			this.label12.TabIndex = 31;
			this.label12.Text = "Titulo:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Display_LivrosSQL
			// 
			this.Display_LivrosSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Display_LivrosSQL.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Display_LivrosSQL.FormattingEnabled = true;
			this.Display_LivrosSQL.ItemHeight = 18;
			this.Display_LivrosSQL.Location = new System.Drawing.Point(464, 8);
			this.Display_LivrosSQL.Margin = new System.Windows.Forms.Padding(4);
			this.Display_LivrosSQL.Name = "Display_LivrosSQL";
			this.Display_LivrosSQL.Size = new System.Drawing.Size(776, 598);
			this.Display_LivrosSQL.TabIndex = 46;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(43, 40);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(79, 25);
			this.label13.TabIndex = 32;
			this.label13.Text = "Autor:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// botaoCadastrarSQL
			// 
			this.botaoCadastrarSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.botaoCadastrarSQL.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoCadastrarSQL.Location = new System.Drawing.Point(120, 136);
			this.botaoCadastrarSQL.Margin = new System.Windows.Forms.Padding(4);
			this.botaoCadastrarSQL.Name = "botaoCadastrarSQL";
			this.botaoCadastrarSQL.Size = new System.Drawing.Size(328, 39);
			this.botaoCadastrarSQL.TabIndex = 39;
			this.botaoCadastrarSQL.Text = "Cadastrar";
			this.botaoCadastrarSQL.UseVisualStyleBackColor = true;
			this.botaoCadastrarSQL.Click += new System.EventHandler(this.botaoCadastrarSQL_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(136, 145);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 300);
			this.panel1.TabIndex = 45;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(8, 408);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(114, 25);
			this.label16.TabIndex = 47;
			this.label16.Text = "Pesquisa:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.botaoPesquisarSQL);
			this.Controls.Add(this.modoPesquisaSQL);
			this.Controls.Add(this.pesquisaLivroSQL);
			this.Controls.Add(this.anoSQL);
			this.Controls.Add(this.edicaoSQL);
			this.Controls.Add(this.editoraSQL);
			this.Controls.Add(this.tituloSQL);
			this.Controls.Add(this.autorSQL);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.Display_LivrosSQL);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.botaoCadastrarSQL);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(1250, 622);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button botaoPesquisarSQL;
		private System.Windows.Forms.ComboBox modoPesquisaSQL;
		private System.Windows.Forms.TextBox pesquisaLivroSQL;
		private System.Windows.Forms.TextBox anoSQL;
		private System.Windows.Forms.TextBox edicaoSQL;
		private System.Windows.Forms.TextBox editoraSQL;
		private System.Windows.Forms.TextBox tituloSQL;
		private System.Windows.Forms.TextBox autorSQL;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ListBox Display_LivrosSQL;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button botaoCadastrarSQL;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label16;
	}
}
