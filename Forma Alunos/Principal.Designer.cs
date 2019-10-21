namespace Forma_Alunos
{
	partial class Principal
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button1 = new System.Windows.Forms.Button();
			this.botao_EmprestarLivro = new System.Windows.Forms.Button();
			this.botao_pesquisarLivro = new System.Windows.Forms.Button();
			this.botao_cadastrarUsuario = new System.Windows.Forms.Button();
			this.botao_cadastrarLivro = new System.Windows.Forms.Button();
			this.pesquisa_Usuario = new Forma_Alunos.Componentes_Interface.Pesquisa_Usuario();
			this.emprestar_Livro = new Forma_Alunos.Componentes_Interface.Emprestar_Livro();
			this.pesquisa_Livro = new Forma_Alunos.Pesquisa_Livro();
			this.cadastro_Livro = new Forma_Alunos.Cadastro_Livro();
			this.cadastro_Usuario = new Forma_Alunos.Cadastro_Usuario();
			this.devolver_Livro = new Forma_Alunos.Componentes_Interface.Devolver_Livro();
			this.botao_DevolverLivro = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectToolStripMenuItem});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// objectToolStripMenuItem
			// 
			this.objectToolStripMenuItem.Name = "objectToolStripMenuItem";
			this.objectToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.objectToolStripMenuItem.Text = "Object";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.botao_DevolverLivro);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.botao_EmprestarLivro);
			this.splitContainer1.Panel1.Controls.Add(this.botao_pesquisarLivro);
			this.splitContainer1.Panel1.Controls.Add(this.botao_cadastrarUsuario);
			this.splitContainer1.Panel1.Controls.Add(this.botao_cadastrarLivro);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.devolver_Livro);
			this.splitContainer1.Panel2.Controls.Add(this.pesquisa_Usuario);
			this.splitContainer1.Panel2.Controls.Add(this.emprestar_Livro);
			this.splitContainer1.Panel2.Controls.Add(this.pesquisa_Livro);
			this.splitContainer1.Panel2.Controls.Add(this.cadastro_Livro);
			this.splitContainer1.Panel2.Controls.Add(this.cadastro_Usuario);
			this.splitContainer1.Size = new System.Drawing.Size(1264, 657);
			this.splitContainer1.SplitterDistance = 355;
			this.splitContainer1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(184, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Pesquisar Aluno";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// botao_EmprestarLivro
			// 
			this.botao_EmprestarLivro.Location = new System.Drawing.Point(8, 56);
			this.botao_EmprestarLivro.Name = "botao_EmprestarLivro";
			this.botao_EmprestarLivro.Size = new System.Drawing.Size(160, 32);
			this.botao_EmprestarLivro.TabIndex = 3;
			this.botao_EmprestarLivro.Text = "Emprestar Livro";
			this.botao_EmprestarLivro.UseVisualStyleBackColor = true;
			this.botao_EmprestarLivro.Click += new System.EventHandler(this.botao_EmprestarLivro_Click);
			// 
			// botao_pesquisarLivro
			// 
			this.botao_pesquisarLivro.Location = new System.Drawing.Point(184, 16);
			this.botao_pesquisarLivro.Name = "botao_pesquisarLivro";
			this.botao_pesquisarLivro.Size = new System.Drawing.Size(160, 32);
			this.botao_pesquisarLivro.TabIndex = 2;
			this.botao_pesquisarLivro.Text = "Pesquisar Livro";
			this.botao_pesquisarLivro.UseVisualStyleBackColor = true;
			this.botao_pesquisarLivro.Click += new System.EventHandler(this.botao_pesquisarLivro_Click);
			// 
			// botao_cadastrarUsuario
			// 
			this.botao_cadastrarUsuario.Location = new System.Drawing.Point(8, 136);
			this.botao_cadastrarUsuario.Name = "botao_cadastrarUsuario";
			this.botao_cadastrarUsuario.Size = new System.Drawing.Size(160, 32);
			this.botao_cadastrarUsuario.TabIndex = 1;
			this.botao_cadastrarUsuario.Text = "Cadastrar Aluno";
			this.botao_cadastrarUsuario.UseVisualStyleBackColor = true;
			this.botao_cadastrarUsuario.Click += new System.EventHandler(this.botao_cadastrarUsuario_Click);
			// 
			// botao_cadastrarLivro
			// 
			this.botao_cadastrarLivro.Location = new System.Drawing.Point(8, 16);
			this.botao_cadastrarLivro.Name = "botao_cadastrarLivro";
			this.botao_cadastrarLivro.Size = new System.Drawing.Size(160, 32);
			this.botao_cadastrarLivro.TabIndex = 0;
			this.botao_cadastrarLivro.Text = "Cadastrar Livro";
			this.botao_cadastrarLivro.UseVisualStyleBackColor = true;
			this.botao_cadastrarLivro.Click += new System.EventHandler(this.botao_cadastrarLivro_Click);
			// 
			// pesquisa_Usuario
			// 
			this.pesquisa_Usuario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pesquisa_Usuario.Location = new System.Drawing.Point(0, 0);
			this.pesquisa_Usuario.Margin = new System.Windows.Forms.Padding(4);
			this.pesquisa_Usuario.Name = "pesquisa_Usuario";
			this.pesquisa_Usuario.Size = new System.Drawing.Size(640, 480);
			this.pesquisa_Usuario.TabIndex = 4;
			this.pesquisa_Usuario.Visible = false;
			// 
			// emprestar_Livro
			// 
			this.emprestar_Livro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emprestar_Livro.Location = new System.Drawing.Point(0, 0);
			this.emprestar_Livro.Margin = new System.Windows.Forms.Padding(4);
			this.emprestar_Livro.Name = "emprestar_Livro";
			this.emprestar_Livro.Size = new System.Drawing.Size(640, 480);
			this.emprestar_Livro.TabIndex = 3;
			this.emprestar_Livro.Visible = false;
			// 
			// pesquisa_Livro
			// 
			this.pesquisa_Livro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pesquisa_Livro.Location = new System.Drawing.Point(0, 0);
			this.pesquisa_Livro.Margin = new System.Windows.Forms.Padding(4);
			this.pesquisa_Livro.Name = "pesquisa_Livro";
			this.pesquisa_Livro.Size = new System.Drawing.Size(640, 480);
			this.pesquisa_Livro.TabIndex = 2;
			this.pesquisa_Livro.Visible = false;
			// 
			// cadastro_Livro
			// 
			this.cadastro_Livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cadastro_Livro.Location = new System.Drawing.Point(0, 0);
			this.cadastro_Livro.Margin = new System.Windows.Forms.Padding(4);
			this.cadastro_Livro.Name = "cadastro_Livro";
			this.cadastro_Livro.Size = new System.Drawing.Size(640, 400);
			this.cadastro_Livro.TabIndex = 0;
			this.cadastro_Livro.Visible = false;
			// 
			// cadastro_Usuario
			// 
			this.cadastro_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.cadastro_Usuario.Location = new System.Drawing.Point(0, 0);
			this.cadastro_Usuario.Margin = new System.Windows.Forms.Padding(4);
			this.cadastro_Usuario.Name = "cadastro_Usuario";
			this.cadastro_Usuario.Size = new System.Drawing.Size(640, 480);
			this.cadastro_Usuario.TabIndex = 1;
			this.cadastro_Usuario.Visible = false;
			// 
			// devolver_Livro
			// 
			this.devolver_Livro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.devolver_Livro.Location = new System.Drawing.Point(0, 0);
			this.devolver_Livro.Margin = new System.Windows.Forms.Padding(4);
			this.devolver_Livro.Name = "devolver_Livro";
			this.devolver_Livro.Size = new System.Drawing.Size(640, 480);
			this.devolver_Livro.TabIndex = 5;
			this.devolver_Livro.Visible = false;
			// 
			// botao_DevolverLivro
			// 
			this.botao_DevolverLivro.Location = new System.Drawing.Point(184, 56);
			this.botao_DevolverLivro.Name = "botao_DevolverLivro";
			this.botao_DevolverLivro.Size = new System.Drawing.Size(160, 32);
			this.botao_DevolverLivro.TabIndex = 5;
			this.botao_DevolverLivro.Text = "Devolver Livro";
			this.botao_DevolverLivro.UseVisualStyleBackColor = true;
			this.botao_DevolverLivro.Click += new System.EventHandler(this.botao_DevolverLivro_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Principal";
			this.Text = "Sistema Biblioteca";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem objectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button botao_cadastrarUsuario;
		private System.Windows.Forms.Button botao_cadastrarLivro;
		private Cadastro_Livro cadastro_Livro;
		private Cadastro_Usuario cadastro_Usuario;
		private System.Windows.Forms.Button botao_pesquisarLivro;
		private Pesquisa_Livro pesquisa_Livro;
		private System.Windows.Forms.Button botao_EmprestarLivro;
		private Componentes_Interface.Emprestar_Livro emprestar_Livro;
		private System.Windows.Forms.Button button1;
		private Componentes_Interface.Pesquisa_Usuario pesquisa_Usuario;
		private System.Windows.Forms.Button botao_DevolverLivro;
		private Componentes_Interface.Devolver_Livro devolver_Livro;
	}
}

