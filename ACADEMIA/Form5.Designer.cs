namespace ACADEMIA
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtVoltar = new FontAwesome.Sharp.IconButton();
            this.TxtRelatorio_tutores = new FontAwesome.Sharp.IconButton();
            this.TxtRelatório_atleta = new FontAwesome.Sharp.IconButton();
            this.TxtRelatório_alunos = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TxtVoltar);
            this.panel1.Controls.Add(this.TxtRelatorio_tutores);
            this.panel1.Controls.Add(this.TxtRelatório_atleta);
            this.panel1.Controls.Add(this.TxtRelatório_alunos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TxtVoltar
            // 
            this.TxtVoltar.FlatAppearance.BorderSize = 0;
            this.TxtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtVoltar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVoltar.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.TxtVoltar.IconColor = System.Drawing.Color.Black;
            this.TxtVoltar.IconSize = 30;
            this.TxtVoltar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtVoltar.Location = new System.Drawing.Point(3, 234);
            this.TxtVoltar.Name = "TxtVoltar";
            this.TxtVoltar.Rotation = 0D;
            this.TxtVoltar.Size = new System.Drawing.Size(175, 64);
            this.TxtVoltar.TabIndex = 7;
            this.TxtVoltar.Text = "&Voltar";
            this.TxtVoltar.UseVisualStyleBackColor = true;
            this.TxtVoltar.Click += new System.EventHandler(this.TxtVoltar_Click);
            // 
            // TxtRelatorio_tutores
            // 
            this.TxtRelatorio_tutores.FlatAppearance.BorderSize = 0;
            this.TxtRelatorio_tutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRelatorio_tutores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtRelatorio_tutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRelatorio_tutores.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.TxtRelatorio_tutores.IconColor = System.Drawing.Color.Black;
            this.TxtRelatorio_tutores.IconSize = 30;
            this.TxtRelatorio_tutores.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtRelatorio_tutores.Location = new System.Drawing.Point(3, 157);
            this.TxtRelatorio_tutores.Name = "TxtRelatorio_tutores";
            this.TxtRelatorio_tutores.Rotation = 0D;
            this.TxtRelatorio_tutores.Size = new System.Drawing.Size(175, 64);
            this.TxtRelatorio_tutores.TabIndex = 6;
            this.TxtRelatorio_tutores.Text = "Relatório Tutores";
            this.TxtRelatorio_tutores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtRelatorio_tutores.UseVisualStyleBackColor = true;
            this.TxtRelatorio_tutores.Click += new System.EventHandler(this.TxtRelatorio_tutores_Click);
            // 
            // TxtRelatório_atleta
            // 
            this.TxtRelatório_atleta.FlatAppearance.BorderSize = 0;
            this.TxtRelatório_atleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRelatório_atleta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtRelatório_atleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRelatório_atleta.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.TxtRelatório_atleta.IconColor = System.Drawing.Color.Black;
            this.TxtRelatório_atleta.IconSize = 30;
            this.TxtRelatório_atleta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtRelatório_atleta.Location = new System.Drawing.Point(3, 80);
            this.TxtRelatório_atleta.Name = "TxtRelatório_atleta";
            this.TxtRelatório_atleta.Rotation = 0D;
            this.TxtRelatório_atleta.Size = new System.Drawing.Size(175, 64);
            this.TxtRelatório_atleta.TabIndex = 5;
            this.TxtRelatório_atleta.Text = "Relatório Atleta";
            this.TxtRelatório_atleta.UseVisualStyleBackColor = true;
            this.TxtRelatório_atleta.Click += new System.EventHandler(this.TxtRelatório_atleta_Click);
            // 
            // TxtRelatório_alunos
            // 
            this.TxtRelatório_alunos.FlatAppearance.BorderSize = 0;
            this.TxtRelatório_alunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRelatório_alunos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtRelatório_alunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRelatório_alunos.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.TxtRelatório_alunos.IconColor = System.Drawing.Color.Black;
            this.TxtRelatório_alunos.IconSize = 30;
            this.TxtRelatório_alunos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtRelatório_alunos.Location = new System.Drawing.Point(3, 3);
            this.TxtRelatório_alunos.Name = "TxtRelatório_alunos";
            this.TxtRelatório_alunos.Rotation = 0D;
            this.TxtRelatório_alunos.Size = new System.Drawing.Size(175, 64);
            this.TxtRelatório_alunos.TabIndex = 4;
            this.TxtRelatório_alunos.Text = "&Relatório Alunos";
            this.TxtRelatório_alunos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TxtRelatório_alunos.UseVisualStyleBackColor = true;
            this.TxtRelatório_alunos.Click += new System.EventHandler(this.TxtRelatório_alunos_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton TxtVoltar;
        private FontAwesome.Sharp.IconButton TxtRelatorio_tutores;
        private FontAwesome.Sharp.IconButton TxtRelatório_atleta;
        private FontAwesome.Sharp.IconButton TxtRelatório_alunos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}