
namespace testeDeFrontEnd1
{
    partial class EmprestarExemplares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmprestarExemplares));
            this.button1Gravar = new System.Windows.Forms.Button();
            this.label2ClienteNome = new System.Windows.Forms.Label();
            this.label2clienteCodigo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2Cliente = new System.Windows.Forms.Label();
            this.label4Periodo = new System.Windows.Forms.Label();
            this.label3ate = new System.Windows.Forms.Label();
            this.label2De = new System.Windows.Forms.Label();
            this.dateTimePicker1Final = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1Inicio = new System.Windows.Forms.DateTimePicker();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.button3Limpar = new System.Windows.Forms.Button();
            this.button2Excluir = new System.Windows.Forms.Button();
            this.button1Incluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2EmprestimoNUmero = new System.Windows.Forms.Label();
            this.label2NumeroEmprestimo = new System.Windows.Forms.Label();
            this.label2Multa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Gravar
            // 
            this.button1Gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Gravar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Gravar.Image = ((System.Drawing.Image)(resources.GetObject("button1Gravar.Image")));
            this.button1Gravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Gravar.Location = new System.Drawing.Point(3, 363);
            this.button1Gravar.Name = "button1Gravar";
            this.button1Gravar.Size = new System.Drawing.Size(150, 50);
            this.button1Gravar.TabIndex = 33;
            this.button1Gravar.Text = "Gravar";
            this.button1Gravar.UseVisualStyleBackColor = true;
            // 
            // label2ClienteNome
            // 
            this.label2ClienteNome.AutoSize = true;
            this.label2ClienteNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2ClienteNome.Location = new System.Drawing.Point(165, 5);
            this.label2ClienteNome.Name = "label2ClienteNome";
            this.label2ClienteNome.Size = new System.Drawing.Size(43, 16);
            this.label2ClienteNome.TabIndex = 32;
            this.label2ClienteNome.Text = "Nome:";
            // 
            // label2clienteCodigo
            // 
            this.label2clienteCodigo.AutoSize = true;
            this.label2clienteCodigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2clienteCodigo.Location = new System.Drawing.Point(84, 5);
            this.label2clienteCodigo.Name = "label2clienteCodigo";
            this.label2clienteCodigo.Size = new System.Drawing.Size(51, 16);
            this.label2clienteCodigo.TabIndex = 31;
            this.label2clienteCodigo.Text = "Código:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 29;
            // 
            // label2Cliente
            // 
            this.label2Cliente.AutoSize = true;
            this.label2Cliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Cliente.Location = new System.Drawing.Point(21, 24);
            this.label2Cliente.Name = "label2Cliente";
            this.label2Cliente.Size = new System.Drawing.Size(49, 16);
            this.label2Cliente.TabIndex = 28;
            this.label2Cliente.Text = "Cliente:";
            // 
            // label4Periodo
            // 
            this.label4Periodo.AutoSize = true;
            this.label4Periodo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Periodo.Location = new System.Drawing.Point(21, 58);
            this.label4Periodo.Name = "label4Periodo";
            this.label4Periodo.Size = new System.Drawing.Size(49, 16);
            this.label4Periodo.TabIndex = 27;
            this.label4Periodo.Text = "Período";
            // 
            // label3ate
            // 
            this.label3ate.AutoSize = true;
            this.label3ate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3ate.Location = new System.Drawing.Point(21, 106);
            this.label3ate.Name = "label3ate";
            this.label3ate.Size = new System.Drawing.Size(29, 16);
            this.label3ate.TabIndex = 26;
            this.label3ate.Text = "Até:";
            // 
            // label2De
            // 
            this.label2De.AutoSize = true;
            this.label2De.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2De.Location = new System.Drawing.Point(21, 82);
            this.label2De.Name = "label2De";
            this.label2De.Size = new System.Drawing.Size(26, 16);
            this.label2De.TabIndex = 25;
            this.label2De.Text = "De:";
            // 
            // dateTimePicker1Final
            // 
            this.dateTimePicker1Final.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1Final.Location = new System.Drawing.Point(87, 106);
            this.dateTimePicker1Final.Name = "dateTimePicker1Final";
            this.dateTimePicker1Final.Size = new System.Drawing.Size(253, 21);
            this.dateTimePicker1Final.TabIndex = 24;
            // 
            // dateTimePicker1Inicio
            // 
            this.dateTimePicker1Inicio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1Inicio.Location = new System.Drawing.Point(87, 77);
            this.dateTimePicker1Inicio.Name = "dateTimePicker1Inicio";
            this.dateTimePicker1Inicio.Size = new System.Drawing.Size(253, 21);
            this.dateTimePicker1Inicio.TabIndex = 23;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(175, 363);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(150, 50);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // button3Limpar
            // 
            this.button3Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3Limpar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Limpar.Image = ((System.Drawing.Image)(resources.GetObject("button3Limpar.Image")));
            this.button3Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3Limpar.Location = new System.Drawing.Point(346, 76);
            this.button3Limpar.Name = "button3Limpar";
            this.button3Limpar.Size = new System.Drawing.Size(150, 50);
            this.button3Limpar.TabIndex = 21;
            this.button3Limpar.Text = "Limpar";
            this.button3Limpar.UseVisualStyleBackColor = true;
            // 
            // button2Excluir
            // 
            this.button2Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2Excluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Excluir.Image = ((System.Drawing.Image)(resources.GetObject("button2Excluir.Image")));
            this.button2Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2Excluir.Location = new System.Drawing.Point(175, 292);
            this.button2Excluir.Name = "button2Excluir";
            this.button2Excluir.Size = new System.Drawing.Size(150, 50);
            this.button2Excluir.TabIndex = 20;
            this.button2Excluir.Text = "Excluir";
            this.button2Excluir.UseVisualStyleBackColor = true;
            // 
            // button1Incluir
            // 
            this.button1Incluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1Incluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Incluir.Image = ((System.Drawing.Image)(resources.GetObject("button1Incluir.Image")));
            this.button1Incluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1Incluir.Location = new System.Drawing.Point(3, 292);
            this.button1Incluir.Name = "button1Incluir";
            this.button1Incluir.Size = new System.Drawing.Size(150, 50);
            this.button1Incluir.TabIndex = 19;
            this.button1Incluir.Text = "Incluir";
            this.button1Incluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total R$ 0,00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2EmprestimoNUmero
            // 
            this.label2EmprestimoNUmero.AutoSize = true;
            this.label2EmprestimoNUmero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2EmprestimoNUmero.Location = new System.Drawing.Point(343, 57);
            this.label2EmprestimoNUmero.Name = "label2EmprestimoNUmero";
            this.label2EmprestimoNUmero.Size = new System.Drawing.Size(117, 16);
            this.label2EmprestimoNUmero.TabIndex = 34;
            this.label2EmprestimoNUmero.Text = "Empréstimo Número:";
            // 
            // label2NumeroEmprestimo
            // 
            this.label2NumeroEmprestimo.AutoSize = true;
            this.label2NumeroEmprestimo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2NumeroEmprestimo.Location = new System.Drawing.Point(458, 57);
            this.label2NumeroEmprestimo.Name = "label2NumeroEmprestimo";
            this.label2NumeroEmprestimo.Size = new System.Drawing.Size(38, 16);
            this.label2NumeroEmprestimo.TabIndex = 35;
            this.label2NumeroEmprestimo.Text = "99999";
            // 
            // label2Multa
            // 
            this.label2Multa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Multa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2Multa.Location = new System.Drawing.Point(328, 292);
            this.label2Multa.Name = "label2Multa";
            this.label2Multa.Size = new System.Drawing.Size(168, 22);
            this.label2Multa.TabIndex = 36;
            this.label2Multa.Text = "Total de Exemplares: 000\r\n";
            this.label2Multa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmprestarExemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2Multa);
            this.Controls.Add(this.label2NumeroEmprestimo);
            this.Controls.Add(this.label2EmprestimoNUmero);
            this.Controls.Add(this.button1Gravar);
            this.Controls.Add(this.label2ClienteNome);
            this.Controls.Add(this.label2clienteCodigo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2Cliente);
            this.Controls.Add(this.label4Periodo);
            this.Controls.Add(this.label3ate);
            this.Controls.Add(this.label2De);
            this.Controls.Add(this.dateTimePicker1Final);
            this.Controls.Add(this.dateTimePicker1Inicio);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.button3Limpar);
            this.Controls.Add(this.button2Excluir);
            this.Controls.Add(this.button1Incluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmprestarExemplares";
            this.Size = new System.Drawing.Size(500, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Gravar;
        private System.Windows.Forms.Label label2ClienteNome;
        private System.Windows.Forms.Label label2clienteCodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2Cliente;
        private System.Windows.Forms.Label label4Periodo;
        private System.Windows.Forms.Label label3ate;
        private System.Windows.Forms.Label label2De;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Final;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Inicio;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button button3Limpar;
        private System.Windows.Forms.Button button2Excluir;
        private System.Windows.Forms.Button button1Incluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2EmprestimoNUmero;
        private System.Windows.Forms.Label label2NumeroEmprestimo;
        private System.Windows.Forms.Label label2Multa;
    }
}
