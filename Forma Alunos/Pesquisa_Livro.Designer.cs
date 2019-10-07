namespace Forma_Alunos
{
	partial class Pesquisa_Livro
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
			this.displayLivros = new System.Windows.Forms.ListBox();
			this.buscaTextBox = new System.Windows.Forms.RichTextBox();
			this.buscaLabel = new System.Windows.Forms.Label();
			this.botaoBuscar = new System.Windows.Forms.Button();
			this.modoPesquisaSQL = new System.Windows.Forms.ComboBox();
			this.botaoEditar = new System.Windows.Forms.Button();
			this.botaoEmprestar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// displayLivros
			// 
			this.displayLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayLivros.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayLivros.FormattingEnabled = true;
			this.displayLivros.ItemHeight = 16;
			this.displayLivros.Location = new System.Drawing.Point(112, 88);
			this.displayLivros.Margin = new System.Windows.Forms.Padding(4);
			this.displayLivros.Name = "displayLivros";
			this.displayLivros.Size = new System.Drawing.Size(516, 340);
			this.displayLivros.TabIndex = 106;
			// 
			// buscaTextBox
			// 
			this.buscaTextBox.DetectUrls = false;
			this.buscaTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buscaTextBox.Location = new System.Drawing.Point(112, 20);
			this.buscaTextBox.MaxLength = 32;
			this.buscaTextBox.Multiline = false;
			this.buscaTextBox.Name = "buscaTextBox";
			this.buscaTextBox.Size = new System.Drawing.Size(516, 27);
			this.buscaTextBox.TabIndex = 104;
			this.buscaTextBox.Text = "";
			// 
			// buscaLabel
			// 
			this.buscaLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buscaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buscaLabel.Location = new System.Drawing.Point(0, 24);
			this.buscaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.buscaLabel.Name = "buscaLabel";
			this.buscaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buscaLabel.Size = new System.Drawing.Size(112, 20);
			this.buscaLabel.TabIndex = 105;
			this.buscaLabel.Text = "Busca:";
			this.buscaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// botaoBuscar
			// 
			this.botaoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.botaoBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoBuscar.Location = new System.Drawing.Point(264, 52);
			this.botaoBuscar.Name = "botaoBuscar";
			this.botaoBuscar.Size = new System.Drawing.Size(104, 28);
			this.botaoBuscar.TabIndex = 107;
			this.botaoBuscar.Text = "Busca";
			this.botaoBuscar.UseVisualStyleBackColor = true;
			this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
			// 
			// modoPesquisaSQL
			// 
			this.modoPesquisaSQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modoPesquisaSQL.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.modoPesquisaSQL.Font = new System.Drawing.Font("Verdana", 12F);
			this.modoPesquisaSQL.FormattingEnabled = true;
			this.modoPesquisaSQL.Items.AddRange(new object[] {
            "Título",
            "Autor",
            "ISBN",
            "Todos"});
			this.modoPesquisaSQL.Location = new System.Drawing.Point(112, 52);
			this.modoPesquisaSQL.Name = "modoPesquisaSQL";
			this.modoPesquisaSQL.Size = new System.Drawing.Size(144, 26);
			this.modoPesquisaSQL.TabIndex = 108;
			// 
			// botaoEditar
			// 
			this.botaoEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.botaoEditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoEditar.Location = new System.Drawing.Point(524, 436);
			this.botaoEditar.Name = "botaoEditar";
			this.botaoEditar.Size = new System.Drawing.Size(104, 28);
			this.botaoEditar.TabIndex = 109;
			this.botaoEditar.Text = "Editar";
			this.botaoEditar.UseVisualStyleBackColor = true;
			this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
			// 
			// botaoEmprestar
			// 
			this.botaoEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.botaoEmprestar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoEmprestar.Location = new System.Drawing.Point(112, 436);
			this.botaoEmprestar.Name = "botaoEmprestar";
			this.botaoEmprestar.Size = new System.Drawing.Size(104, 28);
			this.botaoEmprestar.TabIndex = 110;
			this.botaoEmprestar.Text = "Emprestar";
			this.botaoEmprestar.UseVisualStyleBackColor = true;
			// 
			// Pesquisa_Livro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.botaoEmprestar);
			this.Controls.Add(this.botaoEditar);
			this.Controls.Add(this.modoPesquisaSQL);
			this.Controls.Add(this.botaoBuscar);
			this.Controls.Add(this.displayLivros);
			this.Controls.Add(this.buscaTextBox);
			this.Controls.Add(this.buscaLabel);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Pesquisa_Livro";
			this.Size = new System.Drawing.Size(640, 480);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox displayLivros;
		private System.Windows.Forms.RichTextBox buscaTextBox;
		private System.Windows.Forms.Label buscaLabel;
		private System.Windows.Forms.Button botaoBuscar;
		private System.Windows.Forms.ComboBox modoPesquisaSQL;
		private System.Windows.Forms.Button botaoEditar;
		private System.Windows.Forms.Button botaoEmprestar;
	}
}
