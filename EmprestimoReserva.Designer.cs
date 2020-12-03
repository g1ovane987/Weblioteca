
namespace testeDeFrontEnd1
{
    partial class EmprestimoReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestimoReserva));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button1OkFaturar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2ClienteNome = new System.Windows.Forms.Label();
            this.label2clienteCodigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2Cliente = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "Reserva:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Data,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 113;
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
            this.buttonCancelar.TabIndex = 112;
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
            this.button1OkFaturar.Size = new System.Drawing.Size(174, 50);
            this.button1OkFaturar.TabIndex = 111;
            this.button1OkFaturar.Text = "Emprestar";
            this.button1OkFaturar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Devolver em:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 109;
            // 
            // label2ClienteNome
            // 
            this.label2ClienteNome.AutoSize = true;
            this.label2ClienteNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2ClienteNome.Location = new System.Drawing.Point(154, 19);
            this.label2ClienteNome.Name = "label2ClienteNome";
            this.label2ClienteNome.Size = new System.Drawing.Size(43, 16);
            this.label2ClienteNome.TabIndex = 108;
            this.label2ClienteNome.Text = "Nome:";
            // 
            // label2clienteCodigo
            // 
            this.label2clienteCodigo.AutoSize = true;
            this.label2clienteCodigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2clienteCodigo.Location = new System.Drawing.Point(73, 19);
            this.label2clienteCodigo.Name = "label2clienteCodigo";
            this.label2clienteCodigo.Size = new System.Drawing.Size(51, 16);
            this.label2clienteCodigo.TabIndex = 107;
            this.label2clienteCodigo.Text = "Código:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 106;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 105;
            // 
            // label2Cliente
            // 
            this.label2Cliente.AutoSize = true;
            this.label2Cliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Cliente.Location = new System.Drawing.Point(10, 38);
            this.label2Cliente.Name = "label2Cliente";
            this.label2Cliente.Size = new System.Drawing.Size(49, 16);
            this.label2Cliente.TabIndex = 104;
            this.label2Cliente.Text = "Cliente:";
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Reserva Número:";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 200;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data:";
            this.Data.Name = "Data";
            this.Data.Width = 130;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor:";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 44);
            this.label1.TabIndex = 116;
            this.label1.Text = "Total R$ 0,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmprestimoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
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
            this.Name = "EmprestimoReserva";
            this.Size = new System.Drawing.Size(500, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button1OkFaturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2ClienteNome;
        private System.Windows.Forms.Label label2clienteCodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
    }
}
