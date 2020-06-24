namespace ACADEMIA
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtVoltar_a_tela_inicial = new FontAwesome.Sharp.IconButton();
            this.TxtRemover_Atleta = new FontAwesome.Sharp.IconButton();
            this.TxtEditar_Atleta = new FontAwesome.Sharp.IconButton();
            this.TxtCadastrar_Atleta = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DtGrvAtletas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCADEMIADataSet = new ACADEMIA.ACADEMIADataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Telefonetxt = new System.Windows.Forms.TextBox();
            this.Nometxt = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.atletasTableAdapter = new ACADEMIA.ACADEMIADataSetTableAdapters.AtletasTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvAtletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCADEMIADataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.TxtVoltar_a_tela_inicial);
            this.panel1.Controls.Add(this.TxtRemover_Atleta);
            this.panel1.Controls.Add(this.TxtEditar_Atleta);
            this.panel1.Controls.Add(this.TxtCadastrar_Atleta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 450);
            this.panel1.TabIndex = 0;
            // 
            // TxtVoltar_a_tela_inicial
            // 
            this.TxtVoltar_a_tela_inicial.FlatAppearance.BorderSize = 0;
            this.TxtVoltar_a_tela_inicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtVoltar_a_tela_inicial.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtVoltar_a_tela_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVoltar_a_tela_inicial.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.TxtVoltar_a_tela_inicial.IconColor = System.Drawing.Color.Black;
            this.TxtVoltar_a_tela_inicial.IconSize = 30;
            this.TxtVoltar_a_tela_inicial.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtVoltar_a_tela_inicial.Location = new System.Drawing.Point(1, 229);
            this.TxtVoltar_a_tela_inicial.Name = "TxtVoltar_a_tela_inicial";
            this.TxtVoltar_a_tela_inicial.Rotation = 0D;
            this.TxtVoltar_a_tela_inicial.Size = new System.Drawing.Size(175, 64);
            this.TxtVoltar_a_tela_inicial.TabIndex = 6;
            this.TxtVoltar_a_tela_inicial.Text = "&Voltar a tela inicial";
            this.TxtVoltar_a_tela_inicial.UseVisualStyleBackColor = true;
            this.TxtVoltar_a_tela_inicial.Click += new System.EventHandler(this.TxtVoltar_a_tela_inicial_Click);
            // 
            // TxtRemover_Atleta
            // 
            this.TxtRemover_Atleta.FlatAppearance.BorderSize = 0;
            this.TxtRemover_Atleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtRemover_Atleta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtRemover_Atleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemover_Atleta.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.TxtRemover_Atleta.IconColor = System.Drawing.Color.Black;
            this.TxtRemover_Atleta.IconSize = 30;
            this.TxtRemover_Atleta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtRemover_Atleta.Location = new System.Drawing.Point(0, 159);
            this.TxtRemover_Atleta.Name = "TxtRemover_Atleta";
            this.TxtRemover_Atleta.Rotation = 0D;
            this.TxtRemover_Atleta.Size = new System.Drawing.Size(175, 64);
            this.TxtRemover_Atleta.TabIndex = 5;
            this.TxtRemover_Atleta.Text = "&Remover Atleta";
            this.TxtRemover_Atleta.UseVisualStyleBackColor = true;
            this.TxtRemover_Atleta.Click += new System.EventHandler(this.TxtRemover_Atleta_Click);
            // 
            // TxtEditar_Atleta
            // 
            this.TxtEditar_Atleta.FlatAppearance.BorderSize = 0;
            this.TxtEditar_Atleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtEditar_Atleta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtEditar_Atleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEditar_Atleta.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.TxtEditar_Atleta.IconColor = System.Drawing.Color.Black;
            this.TxtEditar_Atleta.IconSize = 30;
            this.TxtEditar_Atleta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtEditar_Atleta.Location = new System.Drawing.Point(0, 89);
            this.TxtEditar_Atleta.Name = "TxtEditar_Atleta";
            this.TxtEditar_Atleta.Rotation = 0D;
            this.TxtEditar_Atleta.Size = new System.Drawing.Size(175, 64);
            this.TxtEditar_Atleta.TabIndex = 4;
            this.TxtEditar_Atleta.Text = "&Editar Atleta";
            this.TxtEditar_Atleta.UseVisualStyleBackColor = true;
            this.TxtEditar_Atleta.Click += new System.EventHandler(this.TxtEditar_Atleta_Click);
            // 
            // TxtCadastrar_Atleta
            // 
            this.TxtCadastrar_Atleta.FlatAppearance.BorderSize = 0;
            this.TxtCadastrar_Atleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtCadastrar_Atleta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TxtCadastrar_Atleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadastrar_Atleta.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.TxtCadastrar_Atleta.IconColor = System.Drawing.Color.Black;
            this.TxtCadastrar_Atleta.IconSize = 30;
            this.TxtCadastrar_Atleta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TxtCadastrar_Atleta.Location = new System.Drawing.Point(0, 19);
            this.TxtCadastrar_Atleta.Name = "TxtCadastrar_Atleta";
            this.TxtCadastrar_Atleta.Rotation = 0D;
            this.TxtCadastrar_Atleta.Size = new System.Drawing.Size(175, 64);
            this.TxtCadastrar_Atleta.TabIndex = 3;
            this.TxtCadastrar_Atleta.Text = "&Cadastrar Atleta";
            this.TxtCadastrar_Atleta.UseVisualStyleBackColor = true;
            this.TxtCadastrar_Atleta.Click += new System.EventHandler(this.TxtCadastrar_Atleta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DtGrvAtletas
            // 
            this.DtGrvAtletas.AutoGenerateColumns = false;
            this.DtGrvAtletas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(135)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtGrvAtletas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtGrvAtletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGrvAtletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.telefone,
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.DtGrvAtletas.DataSource = this.atletasBindingSource;
            this.DtGrvAtletas.EnableHeadersVisualStyles = false;
            this.DtGrvAtletas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.DtGrvAtletas.Location = new System.Drawing.Point(316, 276);
            this.DtGrvAtletas.Name = "DtGrvAtletas";
            this.DtGrvAtletas.Size = new System.Drawing.Size(341, 154);
            this.DtGrvAtletas.TabIndex = 1;
            this.DtGrvAtletas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGrvAtletas_CellContentClick);
            this.DtGrvAtletas.DoubleClick += new System.EventHandler(this.DtGrvAtletas_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "telefone";
            this.telefone.Name = "telefone";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // atletasBindingSource
            // 
            this.atletasBindingSource.DataMember = "Atletas";
            this.atletasBindingSource.DataSource = this.aCADEMIADataSet;
            // 
            // aCADEMIADataSet
            // 
            this.aCADEMIADataSet.DataSetName = "ACADEMIADataSet";
            this.aCADEMIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.Telefonetxt);
            this.panel2.Controls.Add(this.Nometxt);
            this.panel2.Controls.Add(this.Idtxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(299, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 177);
            this.panel2.TabIndex = 2;
            // 
            // Telefonetxt
            // 
            this.Telefonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonetxt.Location = new System.Drawing.Point(137, 119);
            this.Telefonetxt.Name = "Telefonetxt";
            this.Telefonetxt.Size = new System.Drawing.Size(214, 29);
            this.Telefonetxt.TabIndex = 5;
            // 
            // Nometxt
            // 
            this.Nometxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nometxt.Location = new System.Drawing.Point(137, 71);
            this.Nometxt.Name = "Nometxt";
            this.Nometxt.Size = new System.Drawing.Size(214, 29);
            this.Nometxt.TabIndex = 4;
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(137, 19);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(51, 29);
            this.Idtxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(22)))), ((int)(((byte)(87)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(363, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 45);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atletas";
            // 
            // atletasTableAdapter
            // 
            this.atletasTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(135)))), ((int)(((byte)(168)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DtGrvAtletas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGrvAtletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCADEMIADataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DtGrvAtletas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Telefonetxt;
        private System.Windows.Forms.TextBox Nometxt;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton TxtCadastrar_Atleta;
        private FontAwesome.Sharp.IconButton TxtVoltar_a_tela_inicial;
        private FontAwesome.Sharp.IconButton TxtRemover_Atleta;
        private FontAwesome.Sharp.IconButton TxtEditar_Atleta;
        private ACADEMIADataSet aCADEMIADataSet;
        private System.Windows.Forms.BindingSource atletasBindingSource;
        private ACADEMIADataSetTableAdapters.AtletasTableAdapter atletasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}