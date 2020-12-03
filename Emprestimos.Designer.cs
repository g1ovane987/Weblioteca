
namespace testeDeFrontEnd1
{
    partial class Emprestimos
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
            this.EmprestarExemplares = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanelForm1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProlongarEmprestimo = new System.Windows.Forms.Button();
            this.FaturarEmprestimo = new System.Windows.Forms.Button();
            this.DevolucaoExemplares = new System.Windows.Forms.Button();
            this.button1AbonarMulta = new System.Windows.Forms.Button();
            this.prolongarEmprestimo1 = new testeDeFrontEnd1.ProlongarEmprestimo();
            this.devolucaoDeExemplares1 = new testeDeFrontEnd1.DevolucaoDeExemplares();
            this.emprestarExemplares1 = new testeDeFrontEnd1.EmprestarExemplares();
            this.faturarEmprestimo1 = new testeDeFrontEnd1.FaturarEmprestimo();
            this.abonarMulta1 = new testeDeFrontEnd1.AbonarMulta();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmprestarExemplares
            // 
            this.EmprestarExemplares.BackColor = System.Drawing.SystemColors.ControlDark;
            this.EmprestarExemplares.FlatAppearance.BorderSize = 0;
            this.EmprestarExemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmprestarExemplares.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmprestarExemplares.Location = new System.Drawing.Point(0, 26);
            this.EmprestarExemplares.Name = "EmprestarExemplares";
            this.EmprestarExemplares.Size = new System.Drawing.Size(227, 62);
            this.EmprestarExemplares.TabIndex = 0;
            this.EmprestarExemplares.Text = "Emprestar Exemplares";
            this.EmprestarExemplares.UseVisualStyleBackColor = false;
            this.EmprestarExemplares.Click += new System.EventHandler(this.EmprestarExemplares_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SidePanelForm1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ProlongarEmprestimo);
            this.panel1.Controls.Add(this.FaturarEmprestimo);
            this.panel1.Controls.Add(this.DevolucaoExemplares);
            this.panel1.Controls.Add(this.EmprestarExemplares);
            this.panel1.Controls.Add(this.button1AbonarMulta);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 420);
            this.panel1.TabIndex = 1;
            // 
            // SidePanelForm1
            // 
            this.SidePanelForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.SidePanelForm1.Location = new System.Drawing.Point(0, 26);
            this.SidePanelForm1.Name = "SidePanelForm1";
            this.SidePanelForm1.Size = new System.Drawing.Size(5, 62);
            this.SidePanelForm1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 421);
            this.panel2.TabIndex = 2;
            // 
            // ProlongarEmprestimo
            // 
            this.ProlongarEmprestimo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ProlongarEmprestimo.FlatAppearance.BorderSize = 0;
            this.ProlongarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProlongarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProlongarEmprestimo.Location = new System.Drawing.Point(0, 248);
            this.ProlongarEmprestimo.Name = "ProlongarEmprestimo";
            this.ProlongarEmprestimo.Size = new System.Drawing.Size(227, 62);
            this.ProlongarEmprestimo.TabIndex = 3;
            this.ProlongarEmprestimo.Text = "Prolongar Empréstimo";
            this.ProlongarEmprestimo.UseVisualStyleBackColor = false;
            this.ProlongarEmprestimo.Click += new System.EventHandler(this.ProlongarEmprestimo_Click);
            // 
            // FaturarEmprestimo
            // 
            this.FaturarEmprestimo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FaturarEmprestimo.FlatAppearance.BorderSize = 0;
            this.FaturarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaturarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaturarEmprestimo.Location = new System.Drawing.Point(0, 171);
            this.FaturarEmprestimo.Name = "FaturarEmprestimo";
            this.FaturarEmprestimo.Size = new System.Drawing.Size(227, 62);
            this.FaturarEmprestimo.TabIndex = 2;
            this.FaturarEmprestimo.Text = "Faturar Empréstimo";
            this.FaturarEmprestimo.UseVisualStyleBackColor = false;
            this.FaturarEmprestimo.Click += new System.EventHandler(this.FaturarEmprestimo_Click);
            // 
            // DevolucaoExemplares
            // 
            this.DevolucaoExemplares.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DevolucaoExemplares.FlatAppearance.BorderSize = 0;
            this.DevolucaoExemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevolucaoExemplares.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevolucaoExemplares.Location = new System.Drawing.Point(0, 98);
            this.DevolucaoExemplares.Name = "DevolucaoExemplares";
            this.DevolucaoExemplares.Size = new System.Drawing.Size(227, 62);
            this.DevolucaoExemplares.TabIndex = 1;
            this.DevolucaoExemplares.Text = "Devolução de Exemplares";
            this.DevolucaoExemplares.UseVisualStyleBackColor = false;
            this.DevolucaoExemplares.Click += new System.EventHandler(this.DevolucaoExemplares_Click);
            // 
            // button1AbonarMulta
            // 
            this.button1AbonarMulta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1AbonarMulta.FlatAppearance.BorderSize = 0;
            this.button1AbonarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1AbonarMulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1AbonarMulta.Location = new System.Drawing.Point(-3, 323);
            this.button1AbonarMulta.Name = "button1AbonarMulta";
            this.button1AbonarMulta.Size = new System.Drawing.Size(227, 62);
            this.button1AbonarMulta.TabIndex = 4;
            this.button1AbonarMulta.Text = "Abonar Multa";
            this.button1AbonarMulta.UseVisualStyleBackColor = false;
            this.button1AbonarMulta.Click += new System.EventHandler(this.button1AbonarMulta_Click);
            // 
            // prolongarEmprestimo1
            // 
            this.prolongarEmprestimo1.Location = new System.Drawing.Point(227, 0);
            this.prolongarEmprestimo1.Name = "prolongarEmprestimo1";
            this.prolongarEmprestimo1.Size = new System.Drawing.Size(500, 420);
            this.prolongarEmprestimo1.TabIndex = 5;
            // 
            // devolucaoDeExemplares1
            // 
            this.devolucaoDeExemplares1.Location = new System.Drawing.Point(227, 0);
            this.devolucaoDeExemplares1.Name = "devolucaoDeExemplares1";
            this.devolucaoDeExemplares1.Size = new System.Drawing.Size(500, 420);
            this.devolucaoDeExemplares1.TabIndex = 4;
            // 
            // emprestarExemplares1
            // 
            this.emprestarExemplares1.Location = new System.Drawing.Point(227, 0);
            this.emprestarExemplares1.Name = "emprestarExemplares1";
            this.emprestarExemplares1.Size = new System.Drawing.Size(500, 420);
            this.emprestarExemplares1.TabIndex = 3;
            // 
            // faturarEmprestimo1
            // 
            this.faturarEmprestimo1.Location = new System.Drawing.Point(227, 0);
            this.faturarEmprestimo1.Name = "faturarEmprestimo1";
            this.faturarEmprestimo1.Size = new System.Drawing.Size(500, 420);
            this.faturarEmprestimo1.TabIndex = 2;
            // 
            // abonarMulta1
            // 
            this.abonarMulta1.Location = new System.Drawing.Point(227, 0);
            this.abonarMulta1.Name = "abonarMulta1";
            this.abonarMulta1.Size = new System.Drawing.Size(500, 420);
            this.abonarMulta1.TabIndex = 6;
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.abonarMulta1);
            this.Controls.Add(this.prolongarEmprestimo1);
            this.Controls.Add(this.devolucaoDeExemplares1);
            this.Controls.Add(this.emprestarExemplares1);
            this.Controls.Add(this.faturarEmprestimo1);
            this.Controls.Add(this.panel1);
            this.Name = "Emprestimos";
            this.Size = new System.Drawing.Size(734, 426);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmprestarExemplares;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DevolucaoExemplares;
        private System.Windows.Forms.Button FaturarEmprestimo;
        private System.Windows.Forms.Button ProlongarEmprestimo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SidePanelForm1;
        private FaturarEmprestimo faturarEmprestimo1;
        private EmprestarExemplares emprestarExemplares1;
        private DevolucaoDeExemplares devolucaoDeExemplares1;
        private ProlongarEmprestimo prolongarEmprestimo1;
        private System.Windows.Forms.Button button1AbonarMulta;
        private AbonarMulta abonarMulta1;
    }
}
