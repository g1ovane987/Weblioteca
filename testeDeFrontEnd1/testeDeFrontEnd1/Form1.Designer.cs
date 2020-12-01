
namespace testeDeFrontEnd1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanelForm1 = new System.Windows.Forms.Panel();
            this.BotaoRelatorios = new System.Windows.Forms.Button();
            this.BotaoReservas = new System.Windows.Forms.Button();
            this.BotaoEmprestimos = new System.Windows.Forms.Button();
            this.BotaoCadastros = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SairSistema = new System.Windows.Forms.Button();
            this.botaoHome = new System.Windows.Forms.Button();
            this.telaHome1 = new testeDeFrontEnd1.TelaHome();
            this.emprestimos2 = new testeDeFrontEnd1.Emprestimos();
            this.telaDeLogin1 = new testeDeFrontEnd1.TelaDeLogin();
            this.relatorios1 = new testeDeFrontEnd1.Relatorios();
            this.reservas1 = new testeDeFrontEnd1.Reservas();
            this.emprestimos1 = new testeDeFrontEnd1.Emprestimos();
            this.cadastros1 = new testeDeFrontEnd1.Cadastros();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.SidePanelForm1);
            this.panel1.Controls.Add(this.BotaoRelatorios);
            this.panel1.Controls.Add(this.BotaoReservas);
            this.panel1.Controls.Add(this.BotaoEmprestimos);
            this.panel1.Controls.Add(this.BotaoCadastros);
            this.panel1.Controls.Add(this.botaoHome);
            this.panel1.Controls.Add(this.SairSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 542);
            this.panel1.TabIndex = 0;
            // 
            // SidePanelForm1
            // 
            this.SidePanelForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.Location = new System.Drawing.Point(0, 110);
            this.SidePanelForm1.Name = "SidePanelForm1";
            this.SidePanelForm1.Size = new System.Drawing.Size(5, 62);
            this.SidePanelForm1.TabIndex = 1;
            // 
            // BotaoRelatorios
            // 
            this.BotaoRelatorios.FlatAppearance.BorderSize = 0;
            this.BotaoRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRelatorios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoRelatorios.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("BotaoRelatorios.Image")));
            this.BotaoRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoRelatorios.Location = new System.Drawing.Point(0, 314);
            this.BotaoRelatorios.Name = "BotaoRelatorios";
            this.BotaoRelatorios.Size = new System.Drawing.Size(200, 62);
            this.BotaoRelatorios.TabIndex = 6;
            this.BotaoRelatorios.Text = "Relatórios";
            this.BotaoRelatorios.UseVisualStyleBackColor = true;
            this.BotaoRelatorios.Click += new System.EventHandler(this.BotaoRelatorios_Click);
            // 
            // BotaoReservas
            // 
            this.BotaoReservas.FlatAppearance.BorderSize = 0;
            this.BotaoReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoReservas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoReservas.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoReservas.Image = ((System.Drawing.Image)(resources.GetObject("BotaoReservas.Image")));
            this.BotaoReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoReservas.Location = new System.Drawing.Point(0, 246);
            this.BotaoReservas.Name = "BotaoReservas";
            this.BotaoReservas.Size = new System.Drawing.Size(200, 62);
            this.BotaoReservas.TabIndex = 5;
            this.BotaoReservas.Text = "Reservas";
            this.BotaoReservas.UseVisualStyleBackColor = true;
            this.BotaoReservas.Click += new System.EventHandler(this.BotaoReservas_Click);
            // 
            // BotaoEmprestimos
            // 
            this.BotaoEmprestimos.FlatAppearance.BorderSize = 0;
            this.BotaoEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoEmprestimos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEmprestimos.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoEmprestimos.Image = ((System.Drawing.Image)(resources.GetObject("BotaoEmprestimos.Image")));
            this.BotaoEmprestimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoEmprestimos.Location = new System.Drawing.Point(0, 178);
            this.BotaoEmprestimos.Name = "BotaoEmprestimos";
            this.BotaoEmprestimos.Size = new System.Drawing.Size(200, 62);
            this.BotaoEmprestimos.TabIndex = 4;
            this.BotaoEmprestimos.Text = "Empréstimos";
            this.BotaoEmprestimos.UseVisualStyleBackColor = true;
            this.BotaoEmprestimos.Click += new System.EventHandler(this.BotaoEmprestimos_Click);
            // 
            // BotaoCadastros
            // 
            this.BotaoCadastros.FlatAppearance.BorderSize = 0;
            this.BotaoCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoCadastros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCadastros.ForeColor = System.Drawing.SystemColors.Control;
            this.BotaoCadastros.Image = ((System.Drawing.Image)(resources.GetObject("BotaoCadastros.Image")));
            this.BotaoCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BotaoCadastros.Location = new System.Drawing.Point(0, 110);
            this.BotaoCadastros.Name = "BotaoCadastros";
            this.BotaoCadastros.Size = new System.Drawing.Size(200, 62);
            this.BotaoCadastros.TabIndex = 3;
            this.BotaoCadastros.Text = "Cadastros";
            this.BotaoCadastros.UseVisualStyleBackColor = true;
            this.BotaoCadastros.Click += new System.EventHandler(this.BotaoCadastros_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 22);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(206, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 69);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sistema de Gestão de Bibliotecas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webiblioteca";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.telaHome1);
            this.panel4.Controls.Add(this.emprestimos2);
            this.panel4.Controls.Add(this.telaDeLogin1);
            this.panel4.Controls.Add(this.relatorios1);
            this.panel4.Controls.Add(this.reservas1);
            this.panel4.Controls.Add(this.emprestimos1);
            this.panel4.Controls.Add(this.cadastros1);
            this.panel4.Location = new System.Drawing.Point(200, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(729, 421);
            this.panel4.TabIndex = 5;
            // 
            // SairSistema
            // 
            this.SairSistema.FlatAppearance.BorderSize = 0;
            this.SairSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SairSistema.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SairSistema.ForeColor = System.Drawing.SystemColors.Control;
            this.SairSistema.Image = ((System.Drawing.Image)(resources.GetObject("SairSistema.Image")));
            this.SairSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SairSistema.Location = new System.Drawing.Point(0, 382);
            this.SairSistema.Name = "SairSistema";
            this.SairSistema.Size = new System.Drawing.Size(200, 62);
            this.SairSistema.TabIndex = 7;
            this.SairSistema.Text = "Sair";
            this.SairSistema.UseVisualStyleBackColor = true;
            this.SairSistema.Click += new System.EventHandler(this.SairSistema_Click);
            // 
            // botaoHome
            // 
            this.botaoHome.FlatAppearance.BorderSize = 0;
            this.botaoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoHome.ForeColor = System.Drawing.SystemColors.Control;
            this.botaoHome.Image = ((System.Drawing.Image)(resources.GetObject("botaoHome.Image")));
            this.botaoHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoHome.Location = new System.Drawing.Point(0, 35);
            this.botaoHome.Name = "botaoHome";
            this.botaoHome.Size = new System.Drawing.Size(200, 62);
            this.botaoHome.TabIndex = 8;
            this.botaoHome.Text = "Home";
            this.botaoHome.UseVisualStyleBackColor = true;
            this.botaoHome.Click += new System.EventHandler(this.botaoHome_Click);
            // 
            // telaHome1
            // 
            this.telaHome1.Location = new System.Drawing.Point(0, -103);
            this.telaHome1.Name = "telaHome1";
            this.telaHome1.Size = new System.Drawing.Size(743, 542);
            this.telaHome1.TabIndex = 6;
            // 
            // emprestimos2
            // 
            this.emprestimos2.Location = new System.Drawing.Point(0, 0);
            this.emprestimos2.Name = "emprestimos2";
            this.emprestimos2.Size = new System.Drawing.Size(729, 421);
            this.emprestimos2.TabIndex = 5;
            // 
            // telaDeLogin1
            // 
            this.telaDeLogin1.Location = new System.Drawing.Point(153, 34);
            this.telaDeLogin1.Name = "telaDeLogin1";
            this.telaDeLogin1.Size = new System.Drawing.Size(257, 258);
            this.telaDeLogin1.TabIndex = 4;
            // 
            // relatorios1
            // 
            this.relatorios1.Location = new System.Drawing.Point(0, -3);
            this.relatorios1.Name = "relatorios1";
            this.relatorios1.Size = new System.Drawing.Size(729, 421);
            this.relatorios1.TabIndex = 3;
            // 
            // reservas1
            // 
            this.reservas1.Location = new System.Drawing.Point(0, 3);
            this.reservas1.Name = "reservas1";
            this.reservas1.Size = new System.Drawing.Size(729, 421);
            this.reservas1.TabIndex = 2;
            // 
            // emprestimos1
            // 
            this.emprestimos1.Location = new System.Drawing.Point(0, 6);
            this.emprestimos1.Name = "emprestimos1";
            this.emprestimos1.Size = new System.Drawing.Size(729, 421);
            this.emprestimos1.TabIndex = 1;
            // 
            // cadastros1
            // 
            this.cadastros1.Location = new System.Drawing.Point(0, 0);
            this.cadastros1.Name = "cadastros1";
            this.cadastros1.Size = new System.Drawing.Size(729, 424);
            this.cadastros1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotaoCadastros;
        private System.Windows.Forms.Button BotaoEmprestimos;
        private System.Windows.Forms.Button BotaoRelatorios;
        private System.Windows.Forms.Button BotaoReservas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private Cadastros cadastros1;
        private System.Windows.Forms.Panel SidePanelForm1;
        private Emprestimos emprestimos1;
        private Reservas reservas1;
        private Relatorios relatorios1;
        private TelaDeLogin telaDeLogin1;
        private Emprestimos emprestimos2;
        private System.Windows.Forms.Button SairSistema;
        private System.Windows.Forms.Button botaoHome;
        private TelaHome telaHome1;
    }
}

