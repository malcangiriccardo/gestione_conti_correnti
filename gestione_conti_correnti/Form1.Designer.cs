namespace gestione_conti_correnti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_nome = new System.Windows.Forms.ListBox();
            this.lbx_numero = new System.Windows.Forms.ListBox();
            this.lbx_saldo = new System.Windows.Forms.ListBox();
            this.btn_numero = new System.Windows.Forms.Button();
            this.btn_nome = new System.Windows.Forms.Button();
            this.btn_conto_rosso = new System.Windows.Forms.Button();
            this.btn_saldo_massimo = new System.Windows.Forms.Button();
            this.btn_media = new System.Windows.Forms.Button();
            this.btn_saldo_crescente = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_conto_rosso = new System.Windows.Forms.TextBox();
            this.txt_saldo_massimo = new System.Windows.Forms.TextBox();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.txt_saldo_crescente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbx_nome
            // 
            this.lbx_nome.FormattingEnabled = true;
            this.lbx_nome.Location = new System.Drawing.Point(146, 69);
            this.lbx_nome.Name = "lbx_nome";
            this.lbx_nome.Size = new System.Drawing.Size(120, 108);
            this.lbx_nome.TabIndex = 0;
            // 
            // lbx_numero
            // 
            this.lbx_numero.FormattingEnabled = true;
            this.lbx_numero.Location = new System.Drawing.Point(338, 69);
            this.lbx_numero.Name = "lbx_numero";
            this.lbx_numero.Size = new System.Drawing.Size(120, 108);
            this.lbx_numero.TabIndex = 1;
            // 
            // lbx_saldo
            // 
            this.lbx_saldo.FormattingEnabled = true;
            this.lbx_saldo.Location = new System.Drawing.Point(530, 69);
            this.lbx_saldo.Name = "lbx_saldo";
            this.lbx_saldo.Size = new System.Drawing.Size(120, 108);
            this.lbx_saldo.TabIndex = 2;
            // 
            // btn_numero
            // 
            this.btn_numero.Enabled = false;
            this.btn_numero.Location = new System.Drawing.Point(42, 339);
            this.btn_numero.Name = "btn_numero";
            this.btn_numero.Size = new System.Drawing.Size(75, 64);
            this.btn_numero.TabIndex = 3;
            this.btn_numero.Text = "Trova con numero di conto";
            this.btn_numero.UseVisualStyleBackColor = true;
            this.btn_numero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nome
            // 
            this.btn_nome.Enabled = false;
            this.btn_nome.Location = new System.Drawing.Point(157, 339);
            this.btn_nome.Name = "btn_nome";
            this.btn_nome.Size = new System.Drawing.Size(75, 64);
            this.btn_nome.TabIndex = 4;
            this.btn_nome.Text = "Trova con nome del conto";
            this.btn_nome.UseVisualStyleBackColor = true;
            // 
            // btn_conto_rosso
            // 
            this.btn_conto_rosso.Enabled = false;
            this.btn_conto_rosso.Location = new System.Drawing.Point(272, 339);
            this.btn_conto_rosso.Name = "btn_conto_rosso";
            this.btn_conto_rosso.Size = new System.Drawing.Size(75, 64);
            this.btn_conto_rosso.TabIndex = 5;
            this.btn_conto_rosso.Text = "Trova conti in rosso";
            this.btn_conto_rosso.UseVisualStyleBackColor = true;
            // 
            // btn_saldo_massimo
            // 
            this.btn_saldo_massimo.Enabled = false;
            this.btn_saldo_massimo.Location = new System.Drawing.Point(387, 339);
            this.btn_saldo_massimo.Name = "btn_saldo_massimo";
            this.btn_saldo_massimo.Size = new System.Drawing.Size(75, 64);
            this.btn_saldo_massimo.TabIndex = 6;
            this.btn_saldo_massimo.Text = "Trova conto con il saldo massimo";
            this.btn_saldo_massimo.UseVisualStyleBackColor = true;
            // 
            // btn_media
            // 
            this.btn_media.Enabled = false;
            this.btn_media.Location = new System.Drawing.Point(502, 339);
            this.btn_media.Name = "btn_media";
            this.btn_media.Size = new System.Drawing.Size(75, 64);
            this.btn_media.TabIndex = 7;
            this.btn_media.Text = "Calcola la media dei saldi";
            this.btn_media.UseVisualStyleBackColor = true;
            // 
            // btn_saldo_crescente
            // 
            this.btn_saldo_crescente.Enabled = false;
            this.btn_saldo_crescente.Location = new System.Drawing.Point(617, 339);
            this.btn_saldo_crescente.Name = "btn_saldo_crescente";
            this.btn_saldo_crescente.Size = new System.Drawing.Size(75, 64);
            this.btn_saldo_crescente.TabIndex = 8;
            this.btn_saldo_crescente.Text = "Visualizza saldi in ordine crescente";
            this.btn_saldo_crescente.UseVisualStyleBackColor = true;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(29, 313);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 9;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(144, 313);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 10;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_conto_rosso
            // 
            this.txt_conto_rosso.Location = new System.Drawing.Point(259, 313);
            this.txt_conto_rosso.Name = "txt_conto_rosso";
            this.txt_conto_rosso.Size = new System.Drawing.Size(100, 20);
            this.txt_conto_rosso.TabIndex = 11;
            this.txt_conto_rosso.TextChanged += new System.EventHandler(this.txt_conto_rosso_TextChanged);
            // 
            // txt_saldo_massimo
            // 
            this.txt_saldo_massimo.Location = new System.Drawing.Point(374, 313);
            this.txt_saldo_massimo.Name = "txt_saldo_massimo";
            this.txt_saldo_massimo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo_massimo.TabIndex = 12;
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(489, 313);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 20);
            this.txt_media.TabIndex = 13;
            // 
            // txt_saldo_crescente
            // 
            this.txt_saldo_crescente.Location = new System.Drawing.Point(604, 313);
            this.txt_saldo_crescente.Name = "txt_saldo_crescente";
            this.txt_saldo_crescente.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo_crescente.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_saldo_crescente);
            this.Controls.Add(this.txt_media);
            this.Controls.Add(this.txt_saldo_massimo);
            this.Controls.Add(this.txt_conto_rosso);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_saldo_crescente);
            this.Controls.Add(this.btn_media);
            this.Controls.Add(this.btn_saldo_massimo);
            this.Controls.Add(this.btn_conto_rosso);
            this.Controls.Add(this.btn_nome);
            this.Controls.Add(this.btn_numero);
            this.Controls.Add(this.lbx_saldo);
            this.Controls.Add(this.lbx_numero);
            this.Controls.Add(this.lbx_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_nome;
        private System.Windows.Forms.ListBox lbx_numero;
        private System.Windows.Forms.ListBox lbx_saldo;
        private System.Windows.Forms.Button btn_numero;
        private System.Windows.Forms.Button btn_nome;
        private System.Windows.Forms.Button btn_conto_rosso;
        private System.Windows.Forms.Button btn_saldo_massimo;
        private System.Windows.Forms.Button btn_media;
        private System.Windows.Forms.Button btn_saldo_crescente;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_conto_rosso;
        private System.Windows.Forms.TextBox txt_saldo_massimo;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.TextBox txt_saldo_crescente;
    }
}

