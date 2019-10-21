namespace Forma_Alunos.Componentes_Interface
{
	partial class Pesquisa_Usuario
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
			this.modoPesquisa = new System.Windows.Forms.ComboBox();
			this.botaoBuscar = new System.Windows.Forms.Button();
			this.displayAlunos = new System.Windows.Forms.ListBox();
			this.buscaTextBox = new System.Windows.Forms.RichTextBox();
			this.buscaLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// modoPesquisa
			// 
			this.modoPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.modoPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.modoPesquisa.Font = new System.Drawing.Font("Verdana", 12F);
			this.modoPesquisa.FormattingEnabled = true;
			this.modoPesquisa.Items.AddRange(new object[] {
            "Nome",
            "RA",
            "CPF"});
			this.modoPesquisa.Location = new System.Drawing.Point(112, 88);
			this.modoPesquisa.Name = "modoPesquisa";
			this.modoPesquisa.Size = new System.Drawing.Size(144, 26);
			this.modoPesquisa.TabIndex = 115;
			// 
			// botaoBuscar
			// 
			this.botaoBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.botaoBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.botaoBuscar.Location = new System.Drawing.Point(264, 88);
			this.botaoBuscar.Name = "botaoBuscar";
			this.botaoBuscar.Size = new System.Drawing.Size(104, 28);
			this.botaoBuscar.TabIndex = 114;
			this.botaoBuscar.Text = "Busca";
			this.botaoBuscar.UseVisualStyleBackColor = true;
			this.botaoBuscar.Click += new System.EventHandler(this.botaoBuscar_Click);
			// 
			// displayAlunos
			// 
			this.displayAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.displayAlunos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayAlunos.FormattingEnabled = true;
			this.displayAlunos.ItemHeight = 16;
			this.displayAlunos.Location = new System.Drawing.Point(112, 120);
			this.displayAlunos.Margin = new System.Windows.Forms.Padding(4);
			this.displayAlunos.Name = "displayAlunos";
			this.displayAlunos.Size = new System.Drawing.Size(516, 340);
			this.displayAlunos.TabIndex = 113;
			this.displayAlunos.DoubleClick += new System.EventHandler(this.displayAlunos_DoubleClick);
			// 
			// buscaTextBox
			// 
			this.buscaTextBox.DetectUrls = false;
			this.buscaTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buscaTextBox.Location = new System.Drawing.Point(112, 56);
			this.buscaTextBox.MaxLength = 32;
			this.buscaTextBox.Multiline = false;
			this.buscaTextBox.Name = "buscaTextBox";
			this.buscaTextBox.Size = new System.Drawing.Size(516, 27);
			this.buscaTextBox.TabIndex = 111;
			this.buscaTextBox.Text = "";
			// 
			// buscaLabel
			// 
			this.buscaLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buscaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buscaLabel.Location = new System.Drawing.Point(0, 60);
			this.buscaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.buscaLabel.Name = "buscaLabel";
			this.buscaLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.buscaLabel.Size = new System.Drawing.Size(112, 20);
			this.buscaLabel.TabIndex = 112;
			this.buscaLabel.Text = "Busca:";
			this.buscaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(640, 20);
			this.label1.TabIndex = 117;
			this.label1.Text = "Pesquisa de Alunos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Pesquisa_Usuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.modoPesquisa);
			this.Controls.Add(this.botaoBuscar);
			this.Controls.Add(this.displayAlunos);
			this.Controls.Add(this.buscaTextBox);
			this.Controls.Add(this.buscaLabel);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Pesquisa_Usuario";
			this.Size = new System.Drawing.Size(640, 480);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox modoPesquisa;
		private System.Windows.Forms.Button botaoBuscar;
		private System.Windows.Forms.ListBox displayAlunos;
		private System.Windows.Forms.RichTextBox buscaTextBox;
		private System.Windows.Forms.Label buscaLabel;
		private System.Windows.Forms.Label label1;
	}
}
