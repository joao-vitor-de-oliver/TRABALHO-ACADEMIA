namespace ACADEMIA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtVoltar_a_tela_inicial = new FontAwesome.Sharp.IconButton();
            this.TxtRemover_aluno = new FontAwesome.Sharp.IconButton();
            this.TxtEditar_aluno = new FontAwesome.Sharp.IconButton();
            this.TxtCadastrar_aluno = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Idadetxt = new System.Windows.Forms.TextBox();
            this.TxtIdade = new System.Windows.Forms.Label();
            this.Diastxt = new System.Windows.Forms.TextBox();
            this.Multatxt = new System.Windows.Forms.TextBox();
            this.Telefonetxt = new System.Windows.Forms.TextBox();
            this.Nometxt = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.DtGrvAlunos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.TxtVoltar_a_tela_inicial);
            this.panel1.Controls.Add(this.TxtRemover_aluno);
            this.panel1.Controls.Add(this.TxtEditar_aluno);
            this.panel1.Controls.Add(this.TxtCadastrar_aluno);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 450);
            this.panel1.TabIndex = 0;
            // 
            // TxtVoltar_a_tela_inicial
            // 
            this.TxtVoltar_a_tela_inicial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtVoltar_a_tela_inicial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.TxtVoltar_a_tela_inicial.IconColor = System.Drawing.Color.Black;
            this.TxtVoltar_a_tela_inicial.IconSize = 16;
            this.TxtVoltar_a_tela_inicial.Location = new System.Drawing.Point(0, 223);
            this.TxtVoltar_a_tela_inicial.Name = "TxtVoltar_a_tela_inicial";
            this.TxtVoltar_a_tela_inicial.Rotation = 0D;
            this.TxtVoltar_a_tela_inicial.Size = new System.Drawing.Size(190, 66);
            this.TxtVoltar_a_tela_inicial.TabIndex = 5;
            this.TxtVoltar_a_tela_inicial.Text = "&Voltar a tela inicial";
            this.TxtVoltar_a_tela_inicial.UseVisualStyleBackColor = true;
            this.TxtVoltar_a_tela_inicial.Click += new System.EventHandler(this.TxtVoltar_a_tela_inicial_Click);
            // 
            // TxtRemover_aluno
            // 
            this.TxtRemover_aluno.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtRemover_aluno.IconChar = FontAwesome.Sharp.IconChar.None;
            this.TxtRemover_aluno.IconColor = System.Drawing.Color.Black;
            this.TxtRemover_aluno.IconSize = 16;
            this.TxtRemover_aluno.Location = new System.Drawing.Point(0, 151);
            this.TxtRemover_aluno.Name = "TxtRemover_aluno";
            this.TxtRemover_aluno.Rotation = 0D;
            this.TxtRemover_aluno.Size = new System.Drawing.Size(190, 66);
            this.TxtRemover_aluno.TabIndex = 4;
            this.TxtRemover_aluno.Text = "&Remover Aluno";
            this.TxtRemover_aluno.UseVisualStyleBackColor = true;
            this.TxtRemover_aluno.Click += new System.EventHandler(this.TxtRemover_aluno_Click);
            // 
            // TxtEditar_aluno
            // 
            this.TxtEditar_aluno.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtEditar_aluno.IconChar = FontAwesome.Sharp.IconChar.None;
            this.TxtEditar_aluno.IconColor = System.Drawing.Color.Black;
            this.TxtEditar_aluno.IconSize = 16;
            this.TxtEditar_aluno.Location = new System.Drawing.Point(0, 79);
            this.TxtEditar_aluno.Name = "TxtEditar_aluno";
            this.TxtEditar_aluno.Rotation = 0D;
            this.TxtEditar_aluno.Size = new System.Drawing.Size(190, 66);
            this.TxtEditar_aluno.TabIndex = 3;
            this.TxtEditar_aluno.Text = "&Editar Aluno";
            this.TxtEditar_aluno.UseVisualStyleBackColor = true;
            this.TxtEditar_aluno.Click += new System.EventHandler(this.TxtEditar_aluno_Click);
            // 
            // TxtCadastrar_aluno
            // 
            this.TxtCadastrar_aluno.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtCadastrar_aluno.IconChar = FontAwesome.Sharp.IconChar.None;
            this.TxtCadastrar_aluno.IconColor = System.Drawing.Color.Black;
            this.TxtCadastrar_aluno.IconSize = 16;
            this.TxtCadastrar_aluno.Location = new System.Drawing.Point(1, 7);
            this.TxtCadastrar_aluno.Name = "TxtCadastrar_aluno";
            this.TxtCadastrar_aluno.Rotation = 0D;
            this.TxtCadastrar_aluno.Size = new System.Drawing.Size(190, 66);
            this.TxtCadastrar_aluno.TabIndex = 2;
            this.TxtCadastrar_aluno.Text = "&Cadastrar Aluno";
            this.TxtCadastrar_aluno.UseVisualStyleBackColor = true;
            this.TxtCadastrar_aluno.Click += new System.EventHandler(this.TxtCadastrar_aluno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(70)))), ((int)(((byte)(103)))));
            this.panel2.Controls.Add(this.idtxt);
            this.panel2.Controls.Add(this.Idadetxt);
            this.panel2.Controls.Add(this.TxtIdade);
            this.panel2.Controls.Add(this.Diastxt);
            this.panel2.Controls.Add(this.Multatxt);
            this.panel2.Controls.Add(this.Telefonetxt);
            this.panel2.Controls.Add(this.Nometxt);
            this.panel2.Controls.Add(this.txtDias);
            this.panel2.Controls.Add(this.txtMulta);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Location = new System.Drawing.Point(293, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 204);
            this.panel2.TabIndex = 1;
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(57, 17);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(57, 27);
            this.idtxt.TabIndex = 13;
            // 
            // Idadetxt
            // 
            this.Idadetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idadetxt.Location = new System.Drawing.Point(58, 52);
            this.Idadetxt.Name = "Idadetxt";
            this.Idadetxt.Size = new System.Drawing.Size(56, 26);
            this.Idadetxt.TabIndex = 11;
            // 
            // TxtIdade
            // 
            this.TxtIdade.AutoSize = true;
            this.TxtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdade.Location = new System.Drawing.Point(3, 55);
            this.TxtIdade.Name = "TxtIdade";
            this.TxtIdade.Size = new System.Drawing.Size(50, 20);
            this.TxtIdade.TabIndex = 10;
            this.TxtIdade.Text = "Idade";
            // 
            // Diastxt
            // 
            this.Diastxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diastxt.Location = new System.Drawing.Point(57, 122);
            this.Diastxt.Name = "Diastxt";
            this.Diastxt.Size = new System.Drawing.Size(56, 26);
            this.Diastxt.TabIndex = 9;
            // 
            // Multatxt
            // 
            this.Multatxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multatxt.Location = new System.Drawing.Point(57, 86);
            this.Multatxt.Name = "Multatxt";
            this.Multatxt.Size = new System.Drawing.Size(56, 26);
            this.Multatxt.TabIndex = 8;
            // 
            // Telefonetxt
            // 
            this.Telefonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonetxt.Location = new System.Drawing.Point(215, 46);
            this.Telefonetxt.Name = "Telefonetxt";
            this.Telefonetxt.Size = new System.Drawing.Size(166, 26);
            this.Telefonetxt.TabIndex = 7;
            // 
            // Nometxt
            // 
            this.Nometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nometxt.Location = new System.Drawing.Point(215, 14);
            this.Nometxt.Name = "Nometxt";
            this.Nometxt.Size = new System.Drawing.Size(166, 26);
            this.Nometxt.TabIndex = 6;
            // 
            // txtDias
            // 
            this.txtDias.AutoSize = true;
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(3, 128);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(41, 20);
            this.txtDias.TabIndex = 4;
            this.txtDias.Text = "Dias";
            // 
            // txtMulta
            // 
            this.txtMulta.AutoSize = true;
            this.txtMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.Location = new System.Drawing.Point(3, 92);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(48, 20);
            this.txtMulta.TabIndex = 3;
            this.txtMulta.Text = "Multa";
            // 
            // txtTelefone
            // 
            this.txtTelefone.AutoSize = true;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(138, 52);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(71, 20);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(158, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(51, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(3, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(23, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "Id";
            // 
            // DtGrvAlunos
            // 
            this.DtGrvAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.DtGrvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrvAlunos.Location = new System.Drawing.Point(229, 253);
            this.DtGrvAlunos.Name = "DtGrvAlunos";
            this.DtGrvAlunos.Size = new System.Drawing.Size(521, 197);
            this.DtGrvAlunos.TabIndex = 2;
            this.DtGrvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrvAlunos_CellContentClick);
            this.DtGrvAlunos.DoubleClick += new System.EventHandler(this.DtGrvAlunos_DoubleClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtGrvAlunos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DtGrvAlunos;
        private FontAwesome.Sharp.IconButton TxtVoltar_a_tela_inicial;
        private FontAwesome.Sharp.IconButton TxtRemover_aluno;
        private FontAwesome.Sharp.IconButton TxtEditar_aluno;
        private FontAwesome.Sharp.IconButton TxtCadastrar_aluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Diastxt;
        private System.Windows.Forms.TextBox Multatxt;
        private System.Windows.Forms.TextBox Telefonetxt;
        private System.Windows.Forms.TextBox Nometxt;
        private System.Windows.Forms.Label txtDias;
        private System.Windows.Forms.Label txtMulta;
        private System.Windows.Forms.Label txtTelefone;
        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox Idadetxt;
        private System.Windows.Forms.Label TxtIdade;
        private System.Windows.Forms.TextBox idtxt;
    }
}