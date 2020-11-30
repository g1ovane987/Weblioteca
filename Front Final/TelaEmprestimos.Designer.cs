
namespace testeDeFrontEnd1
{
    partial class TelaEmprestimos
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
            this.BotaoCliente = new System.Windows.Forms.Button();
            this.BoxCodigoAutor = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // BotaoCliente
            // 
            this.BotaoCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BotaoCliente.FlatAppearance.BorderSize = 0;
            this.BotaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotaoCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCliente.Location = new System.Drawing.Point(13, 15);
            this.BotaoCliente.Name = "BotaoCliente";
            this.BotaoCliente.Size = new System.Drawing.Size(75, 23);
            this.BotaoCliente.TabIndex = 0;
            this.BotaoCliente.Text = "Cliente";
            this.BotaoCliente.UseVisualStyleBackColor = false;
            // 
            // BoxCodigoAutor
            // 
            this.BoxCodigoAutor.Location = new System.Drawing.Point(94, 15);
            this.BoxCodigoAutor.Name = "BoxCodigoAutor";
            this.BoxCodigoAutor.Size = new System.Drawing.Size(75, 20);
            this.BoxCodigoAutor.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(264, 127);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 4;
            // 
            // TelaEmprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BoxCodigoAutor);
            this.Controls.Add(this.BotaoCliente);
            this.Name = "TelaEmprestimos";
            this.Size = new System.Drawing.Size(500, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoCliente;
        private System.Windows.Forms.TextBox BoxCodigoAutor;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}
