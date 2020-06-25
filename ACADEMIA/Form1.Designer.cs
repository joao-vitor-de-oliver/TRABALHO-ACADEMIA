namespace ACADEMIA
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IconButton1 = new FontAwesome.Sharp.IconButton();
            this.IconButton2 = new FontAwesome.Sharp.IconButton();
            this.IconButton3 = new FontAwesome.Sharp.IconButton();
            this.IconButton4 = new FontAwesome.Sharp.IconButton();
            this.IconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Desligar = new FontAwesome.Sharp.IconButton();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IconButton1
            // 
            this.IconButton1.BackColor = System.Drawing.Color.Transparent;
            this.IconButton1.FlatAppearance.BorderSize = 0;
            this.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.IconButton1.IconColor = System.Drawing.Color.Black;
            this.IconButton1.IconSize = 50;
            this.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton1.Location = new System.Drawing.Point(3, 5);
            this.IconButton1.Name = "IconButton1";
            this.IconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconButton1.Rotation = 10D;
            this.IconButton1.Size = new System.Drawing.Size(172, 60);
            this.IconButton1.TabIndex = 0;
            this.IconButton1.Text = "Alunos";
            this.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton1.UseVisualStyleBackColor = false;
            this.IconButton1.Click += new System.EventHandler(this.IconButton1_Click_1);
            // 
            // IconButton2
            // 
            this.IconButton2.BackColor = System.Drawing.Color.Transparent;
            this.IconButton2.FlatAppearance.BorderSize = 0;
            this.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IconButton2.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.IconButton2.IconColor = System.Drawing.Color.Black;
            this.IconButton2.IconSize = 50;
            this.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton2.Location = new System.Drawing.Point(3, 123);
            this.IconButton2.Name = "IconButton2";
            this.IconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconButton2.Rotation = 10D;
            this.IconButton2.Size = new System.Drawing.Size(172, 60);
            this.IconButton2.TabIndex = 1;
            this.IconButton2.Text = "Tutores";
            this.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton2.UseVisualStyleBackColor = false;
            this.IconButton2.Click += new System.EventHandler(this.IconButton2_Click);
            // 
            // IconButton3
            // 
            this.IconButton3.BackColor = System.Drawing.Color.Transparent;
            this.IconButton3.FlatAppearance.BorderSize = 0;
            this.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.IconButton3.IconColor = System.Drawing.Color.Black;
            this.IconButton3.IconSize = 50;
            this.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton3.Location = new System.Drawing.Point(3, 64);
            this.IconButton3.Name = "IconButton3";
            this.IconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconButton3.Rotation = 10D;
            this.IconButton3.Size = new System.Drawing.Size(172, 60);
            this.IconButton3.TabIndex = 2;
            this.IconButton3.Text = "Atletas";
            this.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton3.UseVisualStyleBackColor = false;
            this.IconButton3.Click += new System.EventHandler(this.IconButton3_Click);
            // 
            // IconButton4
            // 
            this.IconButton4.BackColor = System.Drawing.Color.Transparent;
            this.IconButton4.FlatAppearance.BorderSize = 0;
            this.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IconButton4.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.IconButton4.IconColor = System.Drawing.Color.Black;
            this.IconButton4.IconSize = 50;
            this.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton4.Location = new System.Drawing.Point(3, 182);
            this.IconButton4.Name = "IconButton4";
            this.IconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconButton4.Rotation = 10D;
            this.IconButton4.Size = new System.Drawing.Size(172, 60);
            this.IconButton4.TabIndex = 3;
            this.IconButton4.Text = "Mensalidade";
            this.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton4.UseVisualStyleBackColor = false;
            this.IconButton4.Click += new System.EventHandler(this.IconButton4_Click);
            // 
            // IconButton5
            // 
            this.IconButton5.BackColor = System.Drawing.Color.Transparent;
            this.IconButton5.FlatAppearance.BorderSize = 0;
            this.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.IconButton5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButton5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IconButton5.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.IconButton5.IconColor = System.Drawing.Color.Black;
            this.IconButton5.IconSize = 50;
            this.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton5.Location = new System.Drawing.Point(3, 241);
            this.IconButton5.Name = "IconButton5";
            this.IconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IconButton5.Rotation = 10D;
            this.IconButton5.Size = new System.Drawing.Size(172, 60);
            this.IconButton5.TabIndex = 4;
            this.IconButton5.Text = "Relatorio";
            this.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconButton5.UseVisualStyleBackColor = false;
            this.IconButton5.Click += new System.EventHandler(this.IconButton5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IconButton1);
            this.panel1.Controls.Add(this.IconButton5);
            this.panel1.Controls.Add(this.IconButton3);
            this.panel1.Controls.Add(this.IconButton4);
            this.panel1.Controls.Add(this.IconButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 450);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 135);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Desligar
            // 
            this.Desligar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.Desligar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Desligar.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desligar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Desligar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.Desligar.IconColor = System.Drawing.Color.Black;
            this.Desligar.IconSize = 45;
            this.Desligar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Desligar.Location = new System.Drawing.Point(789, 406);
            this.Desligar.Name = "Desligar";
            this.Desligar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Desligar.Rotation = 10D;
            this.Desligar.Size = new System.Drawing.Size(147, 44);
            this.Desligar.TabIndex = 6;
            this.Desligar.Text = "Desligar";
            this.Desligar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Desligar.UseVisualStyleBackColor = false;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblFecha.Location = new System.Drawing.Point(193, 51);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(66, 29);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Data";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblHora.Location = new System.Drawing.Point(310, 5);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(111, 46);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "Hora";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private FontAwesome.Sharp.IconButton IconButton1;
        private FontAwesome.Sharp.IconButton IconButton2;
        private FontAwesome.Sharp.IconButton IconButton3;
        private FontAwesome.Sharp.IconButton IconButton4;
        private FontAwesome.Sharp.IconButton IconButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Desligar;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer horafecha;
    }
}

