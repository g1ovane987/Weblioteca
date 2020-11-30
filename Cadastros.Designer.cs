
namespace testeDeFrontEnd1
{
    partial class Cadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastros));
            this.ManterClientes = new System.Windows.Forms.Button();
            this.ManterLivros = new System.Windows.Forms.Button();
            this.ManterAutores = new System.Windows.Forms.Button();
            this.ManterEditoras = new System.Windows.Forms.Button();
            this.ManterFuncionarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanelCadastros = new System.Windows.Forms.Panel();
            this.manterFuncionarios1 = new testeDeFrontEnd1.ManterFuncionarios();
            this.manterEditoras1 = new testeDeFrontEnd1.ManterEditoras();
            this.manterClientes1 = new testeDeFrontEnd1.ManterClientes();
            this.manterAutores1 = new testeDeFrontEnd1.ManterAutores();
            this.manterLivros1 = new testeDeFrontEnd1.ManterLivros();
            this.manterClientes2 = new testeDeFrontEnd1.ManterClientes();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManterClientes
            // 
            this.ManterClientes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ManterClientes.FlatAppearance.BorderSize = 0;
            this.ManterClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManterClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManterClientes.ForeColor = System.Drawing.Color.Black;
            this.ManterClientes.Image = ((System.Drawing.Image)(resources.GetObject("ManterClientes.Image")));
            this.ManterClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManterClientes.Location = new System.Drawing.Point(0, 14);
            this.ManterClientes.Name = "ManterClientes";
            this.ManterClientes.Size = new System.Drawing.Size(227, 62);
            this.ManterClientes.TabIndex = 5;
            this.ManterClientes.Text = "Manter Clientes";
            this.ManterClientes.UseVisualStyleBackColor = false;
            this.ManterClientes.Click += new System.EventHandler(this.ManterClientes_Click);
            // 
            // ManterLivros
            // 
            this.ManterLivros.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ManterLivros.FlatAppearance.BorderSize = 0;
            this.ManterLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManterLivros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManterLivros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManterLivros.Image = ((System.Drawing.Image)(resources.GetObject("ManterLivros.Image")));
            this.ManterLivros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManterLivros.Location = new System.Drawing.Point(0, 99);
            this.ManterLivros.Name = "ManterLivros";
            this.ManterLivros.Size = new System.Drawing.Size(227, 62);
            this.ManterLivros.TabIndex = 6;
            this.ManterLivros.Text = "Manter Livros";
            this.ManterLivros.UseVisualStyleBackColor = false;
            this.ManterLivros.Click += new System.EventHandler(this.ManterLivros_Click);
            // 
            // ManterAutores
            // 
            this.ManterAutores.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ManterAutores.FlatAppearance.BorderSize = 0;
            this.ManterAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManterAutores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManterAutores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManterAutores.Image = ((System.Drawing.Image)(resources.GetObject("ManterAutores.Image")));
            this.ManterAutores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManterAutores.Location = new System.Drawing.Point(0, 178);
            this.ManterAutores.Name = "ManterAutores";
            this.ManterAutores.Size = new System.Drawing.Size(227, 62);
            this.ManterAutores.TabIndex = 7;
            this.ManterAutores.Text = "Manter Autores";
            this.ManterAutores.UseVisualStyleBackColor = false;
            this.ManterAutores.Click += new System.EventHandler(this.ManterAutores_Click);
            // 
            // ManterEditoras
            // 
            this.ManterEditoras.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ManterEditoras.FlatAppearance.BorderSize = 0;
            this.ManterEditoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManterEditoras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManterEditoras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManterEditoras.Image = ((System.Drawing.Image)(resources.GetObject("ManterEditoras.Image")));
            this.ManterEditoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManterEditoras.Location = new System.Drawing.Point(0, 257);
            this.ManterEditoras.Name = "ManterEditoras";
            this.ManterEditoras.Size = new System.Drawing.Size(227, 62);
            this.ManterEditoras.TabIndex = 8;
            this.ManterEditoras.Text = "Manter Editoras";
            this.ManterEditoras.UseVisualStyleBackColor = false;
            this.ManterEditoras.Click += new System.EventHandler(this.ManterEditoras_Click);
            // 
            // ManterFuncionarios
            // 
            this.ManterFuncionarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ManterFuncionarios.FlatAppearance.BorderSize = 0;
            this.ManterFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManterFuncionarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManterFuncionarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManterFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("ManterFuncionarios.Image")));
            this.ManterFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManterFuncionarios.Location = new System.Drawing.Point(0, 334);
            this.ManterFuncionarios.Name = "ManterFuncionarios";
            this.ManterFuncionarios.Size = new System.Drawing.Size(227, 62);
            this.ManterFuncionarios.TabIndex = 9;
            this.ManterFuncionarios.Text = "Manter Funcionários";
            this.ManterFuncionarios.UseVisualStyleBackColor = false;
            this.ManterFuncionarios.Click += new System.EventHandler(this.ManterFuncionarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanelCadastros);
            this.panel1.Controls.Add(this.ManterClientes);
            this.panel1.Controls.Add(this.ManterFuncionarios);
            this.panel1.Controls.Add(this.ManterLivros);
            this.panel1.Controls.Add(this.ManterEditoras);
            this.panel1.Controls.Add(this.ManterAutores);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 421);
            this.panel1.TabIndex = 10;
            // 
            // SidePanelCadastros
            // 
            this.SidePanelCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelCadastros.Location = new System.Drawing.Point(0, 14);
            this.SidePanelCadastros.Name = "SidePanelCadastros";
            this.SidePanelCadastros.Size = new System.Drawing.Size(5, 62);
            this.SidePanelCadastros.TabIndex = 16;
            // 
            // manterFuncionarios1
            // 
            this.manterFuncionarios1.Location = new System.Drawing.Point(226, -2);
            this.manterFuncionarios1.Name = "manterFuncionarios1";
            this.manterFuncionarios1.Size = new System.Drawing.Size(500, 420);
            this.manterFuncionarios1.TabIndex = 15;
            // 
            // manterEditoras1
            // 
            this.manterEditoras1.Location = new System.Drawing.Point(226, 0);
            this.manterEditoras1.Name = "manterEditoras1";
            this.manterEditoras1.Size = new System.Drawing.Size(500, 420);
            this.manterEditoras1.TabIndex = 14;
            // 
            // manterClientes1
            // 
            this.manterClientes1.Location = new System.Drawing.Point(226, 0);
            this.manterClientes1.Name = "manterClientes1";
            this.manterClientes1.Size = new System.Drawing.Size(500, 420);
            this.manterClientes1.TabIndex = 13;
            // 
            // manterAutores1
            // 
            this.manterAutores1.Location = new System.Drawing.Point(226, -2);
            this.manterAutores1.Name = "manterAutores1";
            this.manterAutores1.Size = new System.Drawing.Size(500, 420);
            this.manterAutores1.TabIndex = 12;
            // 
            // manterLivros1
            // 
            this.manterLivros1.Location = new System.Drawing.Point(226, 0);
            this.manterLivros1.Name = "manterLivros1";
            this.manterLivros1.Size = new System.Drawing.Size(500, 420);
            this.manterLivros1.TabIndex = 11;
            // 
            // manterClientes2
            // 
            this.manterClientes2.Location = new System.Drawing.Point(227, 0);
            this.manterClientes2.Name = "manterClientes2";
            this.manterClientes2.Size = new System.Drawing.Size(500, 420);
            this.manterClientes2.TabIndex = 16;
            // 
            // Cadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.manterClientes2);
            this.Controls.Add(this.manterFuncionarios1);
            this.Controls.Add(this.manterEditoras1);
            this.Controls.Add(this.manterClientes1);
            this.Controls.Add(this.manterAutores1);
            this.Controls.Add(this.manterLivros1);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastros";
            this.Size = new System.Drawing.Size(729, 421);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManterClientes;
        private System.Windows.Forms.Button ManterLivros;
        private System.Windows.Forms.Button ManterAutores;
        private System.Windows.Forms.Button ManterEditoras;
        private System.Windows.Forms.Button ManterFuncionarios;
        private System.Windows.Forms.Panel panel1;
        private ManterLivros manterLivros1;
        private ManterAutores manterAutores1;
        private ManterClientes manterClientes1;
        private ManterEditoras manterEditoras1;
        private ManterFuncionarios manterFuncionarios1;
        private System.Windows.Forms.Panel SidePanelCadastros;
        private ManterClientes manterClientes2;
    }
}
