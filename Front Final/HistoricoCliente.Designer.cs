
namespace testeDeFrontEnd1
{
    partial class HistoricoCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exemplar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDevol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exemplar,
            this.dataHora,
            this.dataHoraDevol,
            this.tempoAtraso});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 403);
            this.dataGridView1.TabIndex = 0;
            // 
            // exemplar
            // 
            this.exemplar.HeaderText = "Exemplar";
            this.exemplar.Name = "exemplar";
            // 
            // dataHora
            // 
            this.dataHora.HeaderText = "Data e Hora Aluguel";
            this.dataHora.Name = "dataHora";
            // 
            // dataHoraDevol
            // 
            this.dataHoraDevol.HeaderText = "Data e Hora Devolução";
            this.dataHoraDevol.Name = "dataHoraDevol";
            // 
            // tempoAtraso
            // 
            this.tempoAtraso.HeaderText = "Tempo de Atraso";
            this.tempoAtraso.Name = "tempoAtraso";
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(354, 415);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 1;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistoricoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoricoCliente";
            this.Text = "HistoricoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn exemplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDevol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoAtraso;
        private System.Windows.Forms.Button btVoltar;
        private HistoricoCliente historicoCliente1;
    }
}