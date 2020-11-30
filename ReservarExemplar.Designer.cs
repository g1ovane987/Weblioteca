
namespace testeDeFrontEnd1
{
    partial class ReservarExemplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservarExemplar));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1OkFaturar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2ClienteNome = new System.Windows.Forms.Label();
            this.label2clienteCodigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2Cliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2Excluir = new System.Windows.Forms.Button();
            this.button1Incluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(335, 351);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 50);
            this.buttonCancelar.TabIndex = 82;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // button1OkFaturar
            // 
            this.button1OkFaturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1OkFaturar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1OkFaturar.Image = ((System.Drawing.Image)(resources.GetObject("button1OkFaturar.Image")));
            this.button1OkFaturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1OkFaturar.Location = new System.Drawing.Point(13, 351);
            this.button1OkFaturar.Name = "button1OkFaturar";
            this.button1OkFaturar.Size = new System.Drawing.Size(150, 50);
            this.button1OkFaturar.TabIndex = 81;
            this.button1OkFaturar.Text = "Reservar";
            this.button1OkFaturar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = "Reservar para:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 312);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // label2ClienteNome
            // 
            this.label2ClienteNome.AutoSize = true;
            this.label2ClienteNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2ClienteNome.Location = new System.Drawing.Point(154, 19);
            this.label2ClienteNome.Name = "label2ClienteNome";
            this.label2ClienteNome.Size = new System.Drawing.Size(43, 16);
            this.label2ClienteNome.TabIndex = 68;
            this.label2ClienteNome.Text = "Nome:";
            // 
            // label2clienteCodigo
            // 
            this.label2clienteCodigo.AutoSize = true;
            this.label2clienteCodigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2clienteCodigo.Location = new System.Drawing.Point(73, 19);
            this.label2clienteCodigo.Name = "label2clienteCodigo";
            this.label2clienteCodigo.Size = new System.Drawing.Size(51, 16);
            this.label2clienteCodigo.TabIndex = 67;
            this.label2clienteCodigo.Text = "Código:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 66;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 65;
            // 
            // label2Cliente
            // 
            this.label2Cliente.AutoSize = true;
            this.label2Cliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Cliente.Location = new System.Drawing.Point(10, 38);
            this.label2Cliente.Name = "label2Cliente";
            this.label2Cliente.Size = new System.Drawing.Size(49, 16);
            this.label2Cliente.TabIndex = 64;
            this.label2Cliente.Text = "Cliente:";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 83;
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
            // button2Excluir
            // 
            this.button2Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Excluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Excluir.Image = ((System.Drawing.Image)(resources.GetObject("button2Excluir.Image")));
            this.button2Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2Excluir.Location = new System.Drawing.Point(175, 82);
            this.button2Excluir.Name = "button2Excluir";
            this.button2Excluir.Size = new System.Drawing.Size(150, 50);
            this.button2Excluir.TabIndex = 85;
            this.button2Excluir.Text = "Excluir";
            this.button2Excluir.UseVisualStyleBackColor = true;
            // 
            // button1Incluir
            // 
            this.button1Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Incluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Incluir.Image = ((System.Drawing.Image)(resources.GetObject("button1Incluir.Image")));
            this.button1Incluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Incluir.Location = new System.Drawing.Point(3, 82);
            this.button1Incluir.Name = "button1Incluir";
            this.button1Incluir.Size = new System.Drawing.Size(150, 50);
            this.button1Incluir.TabIndex = 84;
            this.button1Incluir.Text = "Incluir";
            this.button1Incluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Última Reserva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "999999";
            // 
            // ReservarExemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Excluir);
            this.Controls.Add(this.button1Incluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button1OkFaturar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2ClienteNome);
            this.Controls.Add(this.label2clienteCodigo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2Cliente);
            this.Name = "ReservarExemplar";
            this.Size = new System.Drawing.Size(500, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button1OkFaturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2ClienteNome;
        private System.Windows.Forms.Label label2clienteCodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lancamento;
        private System.Windows.Forms.Button button2Excluir;
        private System.Windows.Forms.Button button1Incluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
