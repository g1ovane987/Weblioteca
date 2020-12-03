
namespace testeDeFrontEnd1
{
    partial class ManterAutores
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManterAutores));
            this.labelCodigoAutor = new System.Windows.Forms.Label();
            this.BoxCodigoAutor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomeAutor = new System.Windows.Forms.TextBox();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodigoAutor
            // 
            this.labelCodigoAutor.AutoSize = true;
            this.labelCodigoAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoAutor.Location = new System.Drawing.Point(16, 10);
            this.labelCodigoAutor.Name = "labelCodigoAutor";
            this.labelCodigoAutor.Size = new System.Drawing.Size(82, 16);
            this.labelCodigoAutor.TabIndex = 0;
            this.labelCodigoAutor.Text = "Código Autor:";
            // 
            // BoxCodigoAutor
            // 
            this.BoxCodigoAutor.Location = new System.Drawing.Point(19, 26);
            this.BoxCodigoAutor.Name = "BoxCodigoAutor";
            this.BoxCodigoAutor.Size = new System.Drawing.Size(82, 20);
            this.BoxCodigoAutor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxNomeAutor
            // 
            this.textBoxNomeAutor.Location = new System.Drawing.Point(19, 72);
            this.textBoxNomeAutor.Name = "textBoxNomeAutor";
            this.textBoxNomeAutor.Size = new System.Drawing.Size(312, 20);
            this.textBoxNomeAutor.TabIndex = 3;
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(16, 56);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(43, 16);
            this.labelNomeAutor.TabIndex = 4;
            this.labelNomeAutor.Text = "Nome:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(171, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(337, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(402, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 50);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Editora,
            this.Edicao,
            this.Lancamento});
            this.dataGridView1.Location = new System.Drawing.Point(0, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            // 
            // Edicao
            // 
            this.Edicao.HeaderText = "Edição";
            this.Edicao.Name = "Edicao";
            this.Edicao.Width = 50;
            // 
            // Lancamento
            // 
            this.Lancamento.HeaderText = "Lançamento";
            this.Lancamento.Name = "Lancamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Obras:";
            // 
            // ManterAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelNomeAutor);
            this.Controls.Add(this.textBoxNomeAutor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxCodigoAutor);
            this.Controls.Add(this.labelCodigoAutor);
            this.Name = "ManterAutores";
            this.Size = new System.Drawing.Size(500, 420);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigoAutor;
        private System.Windows.Forms.TextBox BoxCodigoAutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomeAutor;
        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lancamento;
        private System.Windows.Forms.Label label1;
    }
}
