using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestione_conti_correnti
{
    public partial class Form1 : Form
    {

        string[] nome = new string[7] { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
        string[] numero = new string[7] { "11264", "99780", "00342", "03419","34562", "09887", "02341" };
        int[] saldo = new int[7] { 11534, -2345, 3451, 127, 45673, -13, 3452 };

        public Form1()
        {
            InitializeComponent();

            lbx_nome.Items.AddRange(nome);
            
            lbx_numero.Items.AddRange(numero);
       
            foreach (int j in saldo)
            {
                lbx_saldo.Items.Add(j);
            }

        }
        private void txt_numero_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_numero.Text))
            {
                btn_numero.Enabled = false;
            }
            else
            {
                btn_numero.Enabled = true;
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nome.Text))
            {
                btn_nome.Enabled = false;
            }
            else
            {
                btn_nome.Enabled = true;
            }
        }

        private void txt_conto_rosso_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_conto_rosso.Text))
            {
                btn_conto_rosso.Enabled = false;
            }
            else
            {
                btn_conto_rosso.Enabled = true;
            }
        }

        private void txt_saldo_massimo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_saldo_massimo.Text))
            {
                btn_saldo_massimo.Enabled = false;
            }
            else
            {
                btn_saldo_massimo.Enabled = true;
            }
        }

        private void txt_media_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_media.Text))
            {
                btn_media.Enabled = false;
            }
            else
            {
                btn_media.Enabled = true;
            }
        }

        private void txt_saldo_crescente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_saldo_crescente.Text))
            {
                btn_saldo_crescente.Enabled = false;
            }
            else
            {
                btn_saldo_crescente.Enabled = true;
            }
        }
    }
}
