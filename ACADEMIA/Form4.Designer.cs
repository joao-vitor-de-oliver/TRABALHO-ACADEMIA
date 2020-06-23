namespace ACADEMIA
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voltar_a_tela_inicial = new FontAwesome.Sharp.IconButton();
            this.remover_tutores = new FontAwesome.Sharp.IconButton();
            this.Editar_tutores = new FontAwesome.Sharp.IconButton();
            this.Cadastro_de_tutores = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtGrvTutores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.voltar_a_tela_inicial);
            this.panel1.Controls.Add(this.remover_tutores);
            this.panel1.Controls.Add(this.Editar_tutores);
            this.panel1.Controls.Add(this.Cadastro_de_tutores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 313);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // voltar_a_tela_inicial
            // 
            this.voltar_a_tela_inicial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.voltar_a_tela_inicial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.voltar_a_tela_inicial.IconColor = System.Drawing.Color.Black;
            this.voltar_a_tela_inicial.IconSize = 16;
            this.voltar_a_tela_inicial.Location = new System.Drawing.Point(0, 237);
            this.voltar_a_tela_inicial.Name = "voltar_a_tela_inicial";
            this.voltar_a_tela_inicial.Rotation = 0D;
            this.voltar_a_tela_inicial.Size = new System.Drawing.Size(176, 70);
            this.voltar_a_tela_inicial.TabIndex = 3;
            this.voltar_a_tela_inicial.TabStop = false;
            this.voltar_a_tela_inicial.Text = "&Voltar a tela inicial";
            this.voltar_a_tela_inicial.UseVisualStyleBackColor = true;
            this.voltar_a_tela_inicial.Click += new System.EventHandler(this.Voltar_a_tela_inicial_Click);
            // 
            // remover_tutores
            // 
            this.remover_tutores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.remover_tutores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.remover_tutores.IconColor = System.Drawing.Color.Black;
            this.remover_tutores.IconSize = 16;
            this.remover_tutores.Location = new System.Drawing.Point(0, 161);
            this.remover_tutores.Name = "remover_tutores";
            this.remover_tutores.Rotation = 0D;
            this.remover_tutores.Size = new System.Drawing.Size(176, 70);
            this.remover_tutores.TabIndex = 2;
            this.remover_tutores.Text = "&Remover Tutores";
            this.remover_tutores.UseVisualStyleBackColor = true;
            this.remover_tutores.Click += new System.EventHandler(this.Remover_tutores_Click);
            // 
            // Editar_tutores
            // 
            this.Editar_tutores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Editar_tutores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Editar_tutores.IconColor = System.Drawing.Color.Black;
            this.Editar_tutores.IconSize = 16;
            this.Editar_tutores.Location = new System.Drawing.Point(0, 85);
            this.Editar_tutores.Name = "Editar_tutores";
            this.Editar_tutores.Rotation = 0D;
            this.Editar_tutores.Size = new System.Drawing.Size(176, 70);
            this.Editar_tutores.TabIndex = 1;
            this.Editar_tutores.Text = "&Editar Tutores";
            this.Editar_tutores.UseVisualStyleBackColor = true;
            this.Editar_tutores.Click += new System.EventHandler(this.Editar_tutores_Click);
            // 
            // Cadastro_de_tutores
            // 
            this.Cadastro_de_tutores.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Cadastro_de_tutores.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Cadastro_de_tutores.IconColor = System.Drawing.Color.Black;
            this.Cadastro_de_tutores.IconSize = 16;
            this.Cadastro_de_tutores.Location = new System.Drawing.Point(0, 8);
            this.Cadastro_de_tutores.Name = "Cadastro_de_tutores";
            this.Cadastro_de_tutores.Rotation = 0D;
            this.Cadastro_de_tutores.Size = new System.Drawing.Size(176, 70);
            this.Cadastro_de_tutores.TabIndex = 0;
            this.Cadastro_de_tutores.Text = "&Cadastro de Tutores";
            this.Cadastro_de_tutores.UseVisualStyleBackColor = true;
            this.Cadastro_de_tutores.Click += new System.EventHandler(this.Cadastro_de_tutores_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(389, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 44);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutores";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.panel3.Controls.Add(this.txtSalario);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(359, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 129);
            this.panel3.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(91, 85);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(89, 29);
            this.txtSalario.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(91, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 29);
            this.txtNome.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(91, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(53, 29);
            this.txtId.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // DtGrvTutores
            // 
            this.DtGrvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(103)))));
            this.DtGrvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrvTutores.Location = new System.Drawing.Point(318, 257);
            this.DtGrvTutores.Name = "DtGrvTutores";
            this.DtGrvTutores.Size = new System.Drawing.Size(343, 181);
            this.DtGrvTutores.TabIndex = 3;
            this.DtGrvTutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrvTutores_CellContentClick);
            this.DtGrvTutores.DoubleClick += new System.EventHandler(this.DtGrvTutores_DoubleClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtGrvTutores);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvTutores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DtGrvTutores;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton voltar_a_tela_inicial;
        private FontAwesome.Sharp.IconButton remover_tutores;
        private FontAwesome.Sharp.IconButton Editar_tutores;
        private FontAwesome.Sharp.IconButton Cadastro_de_tutores;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}