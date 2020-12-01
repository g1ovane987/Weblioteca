
namespace testeDeFrontEnd1
{
    partial class Relatorios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RelatorioRentabilidadeExemplares = new System.Windows.Forms.Button();
            this.RelatorioEmprestimosDevolvidos = new System.Windows.Forms.Button();
            this.RelatorioEmprestimosCliente = new System.Windows.Forms.Button();
            this.SidePanelForm1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanelForm1);
            this.panel1.Controls.Add(this.RelatorioRentabilidadeExemplares);
            this.panel1.Controls.Add(this.RelatorioEmprestimosDevolvidos);
            this.panel1.Controls.Add(this.RelatorioEmprestimosCliente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 420);
            this.panel1.TabIndex = 3;
            // 
            // RelatorioRentabilidadeExemplares
            // 
            this.RelatorioRentabilidadeExemplares.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RelatorioRentabilidadeExemplares.FlatAppearance.BorderSize = 0;
            this.RelatorioRentabilidadeExemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelatorioRentabilidadeExemplares.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelatorioRentabilidadeExemplares.Location = new System.Drawing.Point(-1, 219);
            this.RelatorioRentabilidadeExemplares.Name = "RelatorioRentabilidadeExemplares";
            this.RelatorioRentabilidadeExemplares.Size = new System.Drawing.Size(227, 62);
            this.RelatorioRentabilidadeExemplares.TabIndex = 2;
            this.RelatorioRentabilidadeExemplares.Text = "Relatório de Rentabilidade de Exemplares";
            this.RelatorioRentabilidadeExemplares.UseVisualStyleBackColor = false;
            this.RelatorioRentabilidadeExemplares.Click += new System.EventHandler(this.RelatorioRentabilidadeExemplares_Click);
            // 
            // RelatorioEmprestimosDevolvidos
            // 
            this.RelatorioEmprestimosDevolvidos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RelatorioEmprestimosDevolvidos.FlatAppearance.BorderSize = 0;
            this.RelatorioEmprestimosDevolvidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelatorioEmprestimosDevolvidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelatorioEmprestimosDevolvidos.Location = new System.Drawing.Point(0, 122);
            this.RelatorioEmprestimosDevolvidos.Name = "RelatorioEmprestimosDevolvidos";
            this.RelatorioEmprestimosDevolvidos.Size = new System.Drawing.Size(227, 62);
            this.RelatorioEmprestimosDevolvidos.TabIndex = 1;
            this.RelatorioEmprestimosDevolvidos.Text = "Relatório de Empréstimos não Devolvidos";
            this.RelatorioEmprestimosDevolvidos.UseVisualStyleBackColor = false;
            this.RelatorioEmprestimosDevolvidos.Click += new System.EventHandler(this.RelatorioEmprestimosDevolvidos_Click);
            // 
            // RelatorioEmprestimosCliente
            // 
            this.RelatorioEmprestimosCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RelatorioEmprestimosCliente.FlatAppearance.BorderSize = 0;
            this.RelatorioEmprestimosCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelatorioEmprestimosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelatorioEmprestimosCliente.Location = new System.Drawing.Point(0, 26);
            this.RelatorioEmprestimosCliente.Name = "RelatorioEmprestimosCliente";
            this.RelatorioEmprestimosCliente.Size = new System.Drawing.Size(227, 62);
            this.RelatorioEmprestimosCliente.TabIndex = 0;
            this.RelatorioEmprestimosCliente.Text = "Relatório de Empréstimos Realizados por Cliente";
            this.RelatorioEmprestimosCliente.UseVisualStyleBackColor = false;
            this.RelatorioEmprestimosCliente.Click += new System.EventHandler(this.RelatorioEmprestimosCliente_Click);
            // 
            // SidePanelForm1
            // 
            this.SidePanelForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.Location = new System.Drawing.Point(0, 26);
            this.SidePanelForm1.Name = "SidePanelForm1";
            this.SidePanelForm1.Size = new System.Drawing.Size(5, 62);
            this.SidePanelForm1.TabIndex = 4;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Relatorios";
            this.Size = new System.Drawing.Size(729, 421);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RelatorioRentabilidadeExemplares;
        private System.Windows.Forms.Button RelatorioEmprestimosDevolvidos;
        private System.Windows.Forms.Button RelatorioEmprestimosCliente;
        private System.Windows.Forms.Panel SidePanelForm1;
    }
}
