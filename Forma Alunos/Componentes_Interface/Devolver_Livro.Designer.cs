namespace Forma_Alunos.Componentes_Interface
{
	partial class Devolver_Livro
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
			this.TituloTextBox = new System.Windows.Forms.RichTextBox();
			this.CodigotextBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.BotaoConfirmar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TituloTextBox
			// 
			this.TituloTextBox.BackColor = System.Drawing.Color.White;
			this.TituloTextBox.DetectUrls = false;
			this.TituloTextBox.Enabled = false;
			this.TituloTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TituloTextBox.Location = new System.Drawing.Point(12, 88);
			this.TituloTextBox.MaxLength = 256;
			this.TituloTextBox.Name = "TituloTextBox";
			this.TituloTextBox.Size = new System.Drawing.Size(616, 44);
			this.TituloTextBox.TabIndex = 106;
			this.TituloTextBox.Text = "";
			// 
			// CodigotextBox
			// 
			this.CodigotextBox.DetectUrls = false;
			this.CodigotextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CodigotextBox.Location = new System.Drawing.Point(232, 56);
			this.CodigotextBox.MaxLength = 32;
			this.CodigotextBox.Multiline = false;
			this.CodigotextBox.Name = "CodigotextBox";
			this.CodigotextBox.Size = new System.Drawing.Size(396, 27);
			this.CodigotextBox.TabIndex = 104;
			this.CodigotextBox.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Location = new System.Drawing.Point(0, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(232, 20);
			this.label1.TabIndex = 105;
			this.label1.Text = "Código de Barras do Livro:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(0, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(640, 20);
			this.label2.TabIndex = 107;
			this.label2.Text = "Devolução de Livro\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BotaoConfirmar
			// 
			this.BotaoConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.BotaoConfirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BotaoConfirmar.Location = new System.Drawing.Point(524, 136);
			this.BotaoConfirmar.Name = "BotaoConfirmar";
			this.BotaoConfirmar.Size = new System.Drawing.Size(104, 28);
			this.BotaoConfirmar.TabIndex = 108;
			this.BotaoConfirmar.Text = "Confirmar";
			this.BotaoConfirmar.UseVisualStyleBackColor = true;
			this.BotaoConfirmar.Click += new System.EventHandler(this.BotaoConfirmar_Click);
			// 
			// Devolver_Livro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.BotaoConfirmar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TituloTextBox);
			this.Controls.Add(this.CodigotextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Devolver_Livro";
			this.Size = new System.Drawing.Size(640, 480);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox TituloTextBox;
		private System.Windows.Forms.RichTextBox CodigotextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BotaoConfirmar;
	}
}
