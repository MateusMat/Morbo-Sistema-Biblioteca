﻿namespace Forma_Alunos
{
	partial class Editar_Livro
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
			this.BotaoCadastrar = new System.Windows.Forms.Button();
			this.DescricaoTextBox = new System.Windows.Forms.RichTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.AssuntoTextBox = new System.Windows.Forms.RichTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.AnoTextBox = new System.Windows.Forms.RichTextBox();
			this.IdiomaTextBox = new System.Windows.Forms.RichTextBox();
			this.AutorTextBox = new System.Windows.Forms.RichTextBox();
			this.EdicaoTextBox = new System.Windows.Forms.RichTextBox();
			this.EditoraTextBox = new System.Windows.Forms.RichTextBox();
			this.TituloTextBox = new System.Windows.Forms.RichTextBox();
			this.ISBNtextBox = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BotaoCancelar = new System.Windows.Forms.Button();
			this.CodigoTextBox = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BotaoCadastrar
			// 
			this.BotaoCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BotaoCadastrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotaoCadastrar.Location = new System.Drawing.Point(524, 280);
			this.BotaoCadastrar.Name = "BotaoCadastrar";
			this.BotaoCadastrar.Size = new System.Drawing.Size(104, 28);
			this.BotaoCadastrar.TabIndex = 157;
			this.BotaoCadastrar.Text = "Salvar";
			this.BotaoCadastrar.UseVisualStyleBackColor = true;
			this.BotaoCadastrar.Click += new System.EventHandler(this.BotaoCadastrar_Click);
			// 
			// DescricaoTextBox
			// 
			this.DescricaoTextBox.DetectUrls = false;
			this.DescricaoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescricaoTextBox.Location = new System.Drawing.Point(112, 216);
			this.DescricaoTextBox.MaxLength = 2048;
			this.DescricaoTextBox.Name = "DescricaoTextBox";
			this.DescricaoTextBox.Size = new System.Drawing.Size(516, 60);
			this.DescricaoTextBox.TabIndex = 156;
			this.DescricaoTextBox.Text = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label10.Location = new System.Drawing.Point(0, 220);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label10.Size = new System.Drawing.Size(112, 20);
			this.label10.TabIndex = 166;
			this.label10.Text = "Descrição:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AssuntoTextBox
			// 
			this.AssuntoTextBox.DetectUrls = false;
			this.AssuntoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AssuntoTextBox.ForeColor = System.Drawing.Color.Gray;
			this.AssuntoTextBox.Location = new System.Drawing.Point(112, 184);
			this.AssuntoTextBox.MaxLength = 1024;
			this.AssuntoTextBox.Multiline = false;
			this.AssuntoTextBox.Name = "AssuntoTextBox";
			this.AssuntoTextBox.Size = new System.Drawing.Size(516, 27);
			this.AssuntoTextBox.TabIndex = 155;
			this.AssuntoTextBox.Text = "Assuntos devem ser separados por ponto e virgula.";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label9.Location = new System.Drawing.Point(0, 188);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label9.Size = new System.Drawing.Size(112, 20);
			this.label9.TabIndex = 165;
			this.label9.Text = "Assunto:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// AnoTextBox
			// 
			this.AnoTextBox.DetectUrls = false;
			this.AnoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AnoTextBox.Location = new System.Drawing.Point(492, 152);
			this.AnoTextBox.MaxLength = 4;
			this.AnoTextBox.Multiline = false;
			this.AnoTextBox.Name = "AnoTextBox";
			this.AnoTextBox.ShortcutsEnabled = false;
			this.AnoTextBox.Size = new System.Drawing.Size(136, 27);
			this.AnoTextBox.TabIndex = 154;
			this.AnoTextBox.Text = "";
			// 
			// IdiomaTextBox
			// 
			this.IdiomaTextBox.DetectUrls = false;
			this.IdiomaTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IdiomaTextBox.Location = new System.Drawing.Point(112, 152);
			this.IdiomaTextBox.MaxLength = 64;
			this.IdiomaTextBox.Multiline = false;
			this.IdiomaTextBox.Name = "IdiomaTextBox";
			this.IdiomaTextBox.Size = new System.Drawing.Size(200, 27);
			this.IdiomaTextBox.TabIndex = 153;
			this.IdiomaTextBox.Text = "";
			// 
			// AutorTextBox
			// 
			this.AutorTextBox.DetectUrls = false;
			this.AutorTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutorTextBox.Location = new System.Drawing.Point(112, 88);
			this.AutorTextBox.MaxLength = 64;
			this.AutorTextBox.Multiline = false;
			this.AutorTextBox.Name = "AutorTextBox";
			this.AutorTextBox.Size = new System.Drawing.Size(516, 27);
			this.AutorTextBox.TabIndex = 150;
			this.AutorTextBox.Text = "";
			// 
			// EdicaoTextBox
			// 
			this.EdicaoTextBox.DetectUrls = false;
			this.EdicaoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EdicaoTextBox.Location = new System.Drawing.Point(492, 120);
			this.EdicaoTextBox.MaxLength = 4;
			this.EdicaoTextBox.Multiline = false;
			this.EdicaoTextBox.Name = "EdicaoTextBox";
			this.EdicaoTextBox.ShortcutsEnabled = false;
			this.EdicaoTextBox.Size = new System.Drawing.Size(136, 27);
			this.EdicaoTextBox.TabIndex = 152;
			this.EdicaoTextBox.Text = "";
			// 
			// EditoraTextBox
			// 
			this.EditoraTextBox.DetectUrls = false;
			this.EditoraTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EditoraTextBox.Location = new System.Drawing.Point(112, 120);
			this.EditoraTextBox.MaxLength = 64;
			this.EditoraTextBox.Multiline = false;
			this.EditoraTextBox.Name = "EditoraTextBox";
			this.EditoraTextBox.Size = new System.Drawing.Size(200, 27);
			this.EditoraTextBox.TabIndex = 151;
			this.EditoraTextBox.Text = "";
			// 
			// TituloTextBox
			// 
			this.TituloTextBox.DetectUrls = false;
			this.TituloTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TituloTextBox.Location = new System.Drawing.Point(112, 40);
			this.TituloTextBox.MaxLength = 256;
			this.TituloTextBox.Name = "TituloTextBox";
			this.TituloTextBox.Size = new System.Drawing.Size(516, 44);
			this.TituloTextBox.TabIndex = 149;
			this.TituloTextBox.Text = "";
			// 
			// ISBNtextBox
			// 
			this.ISBNtextBox.DetectUrls = false;
			this.ISBNtextBox.Enabled = false;
			this.ISBNtextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ISBNtextBox.Location = new System.Drawing.Point(112, 8);
			this.ISBNtextBox.MaxLength = 32;
			this.ISBNtextBox.Multiline = false;
			this.ISBNtextBox.Name = "ISBNtextBox";
			this.ISBNtextBox.Size = new System.Drawing.Size(200, 27);
			this.ISBNtextBox.TabIndex = 148;
			this.ISBNtextBox.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label6.Location = new System.Drawing.Point(0, 156);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(112, 20);
			this.label6.TabIndex = 164;
			this.label6.Text = "Idioma:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label7.Location = new System.Drawing.Point(324, 156);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(168, 20);
			this.label7.TabIndex = 163;
			this.label7.Text = "Ano de Publicação:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label8.Location = new System.Drawing.Point(380, 124);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(112, 20);
			this.label8.TabIndex = 162;
			this.label8.Text = "Edição:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Location = new System.Drawing.Point(0, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 161;
			this.label3.Text = "Editora:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Location = new System.Drawing.Point(0, 92);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(112, 20);
			this.label4.TabIndex = 160;
			this.label4.Text = "Autor:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(0, 44);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(112, 20);
			this.label2.TabIndex = 159;
			this.label2.Text = "Título:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(112, 20);
			this.label1.TabIndex = 158;
			this.label1.Text = "ISBN:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BotaoCancelar
			// 
			this.BotaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BotaoCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotaoCancelar.Location = new System.Drawing.Point(112, 280);
			this.BotaoCancelar.Name = "BotaoCancelar";
			this.BotaoCancelar.Size = new System.Drawing.Size(104, 28);
			this.BotaoCancelar.TabIndex = 167;
			this.BotaoCancelar.Text = "Cancelar";
			this.BotaoCancelar.UseVisualStyleBackColor = true;
			this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
			// 
			// CodigoTextBox
			// 
			this.CodigoTextBox.DetectUrls = false;
			this.CodigoTextBox.Enabled = false;
			this.CodigoTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CodigoTextBox.Location = new System.Drawing.Point(428, 8);
			this.CodigoTextBox.MaxLength = 32;
			this.CodigoTextBox.Multiline = false;
			this.CodigoTextBox.Name = "CodigoTextBox";
			this.CodigoTextBox.Size = new System.Drawing.Size(200, 27);
			this.CodigoTextBox.TabIndex = 168;
			this.CodigoTextBox.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label5.Location = new System.Drawing.Point(316, 12);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(112, 20);
			this.label5.TabIndex = 169;
			this.label5.Text = "Código:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Editar_Livro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 317);
			this.Controls.Add(this.CodigoTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BotaoCancelar);
			this.Controls.Add(this.BotaoCadastrar);
			this.Controls.Add(this.DescricaoTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.AssuntoTextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.AnoTextBox);
			this.Controls.Add(this.IdiomaTextBox);
			this.Controls.Add(this.AutorTextBox);
			this.Controls.Add(this.EdicaoTextBox);
			this.Controls.Add(this.EditoraTextBox);
			this.Controls.Add(this.TituloTextBox);
			this.Controls.Add(this.ISBNtextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Editar_Livro";
			this.Text = "Editar_Livro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editar_Livro_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BotaoCadastrar;
		private System.Windows.Forms.RichTextBox DescricaoTextBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox AssuntoTextBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.RichTextBox AnoTextBox;
		private System.Windows.Forms.RichTextBox IdiomaTextBox;
		private System.Windows.Forms.RichTextBox AutorTextBox;
		private System.Windows.Forms.RichTextBox EdicaoTextBox;
		private System.Windows.Forms.RichTextBox EditoraTextBox;
		private System.Windows.Forms.RichTextBox TituloTextBox;
		private System.Windows.Forms.RichTextBox ISBNtextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BotaoCancelar;
		private System.Windows.Forms.RichTextBox CodigoTextBox;
		private System.Windows.Forms.Label label5;
	}
}