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
            this.grb_numero = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
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
            this.txt_saldo_massimo.TextChanged += new System.EventHandler(this.txt_saldo_massimo_TextChanged);
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(489, 313);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(100, 20);
            this.txt_media.TabIndex = 13;
            this.txt_media.TextChanged += new System.EventHandler(this.txt_media_TextChanged);
            // 
            // txt_saldo_crescente
            // 
            this.txt_saldo_crescente.Location = new System.Drawing.Point(604, 313);
            this.txt_saldo_crescente.Name = "txt_saldo_crescente";
            this.txt_saldo_crescente.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo_crescente.TabIndex = 14;
            this.txt_saldo_crescente.TextChanged += new System.EventHandler(this.txt_saldo_crescente_TextChanged);
            // 
            // grb_numero
            // 
            this.grb_numero.Location = new System.Drawing.Point(29, 30);
            this.grb_numero.Name = "grb_numero";
            this.grb_numero.Size = new System.Drawing.Size(200, 100);
            this.grb_numero.TabIndex = 15;
            this.grb_numero.TabStop = false;
            this.grb_numero.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(285, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(542, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(32, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(285, 211);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(542, 214);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grb_numero);
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
        private System.Windows.Forms.GroupBox grb_numero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

