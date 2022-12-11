using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachecaTodeschini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bacheca b1 = new Bacheca("b1");

        public int counter = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //AGGIUNGI ANNUNCIO
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                annuncio annuncioa = new annuncio(counter.ToString(), namebox.Text, descbox.Text, datebox.Text, Convert.ToInt32(pricebox.Text)); //dichiaro un annuncio

                b1.Aggiungi(annuncioa); //aggiungo l'annuncio alla bacheca
                counter++; //aumento counter per generare id

                Aggiorna();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            namebox.Text = null;
            descbox.Text = null;
            pricebox.Text = null;
        }

        //AGGIORNA BACHECA CON ANCHE GLI ANNUNCI NUOVI
        public void Aggiorna()
        {
            bacheca.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (b1.Cerca(b1.GetAnnuncio(i)) != -1)
                {
                    annuncio a = b1.GetAnnuncio(i);
                    if (a != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(a.ToString());
                        bacheca.Items.Add(itm);
                    }

                }
            }
        }

        //RICERCA E INSERIMENTO DATI NELLE TEXTBOX
        private void searchbutton_Click(object sender, EventArgs e)
        {
            string[] stringa = new string[4];
            stringa = b1.CercaID(idbox.Text);

            namebox.Text = stringa[0];
            descbox.Text = stringa[1];
            pricebox.Text = stringa[2];
            datebox.Text = stringa[3];
        }

        //MODIFICA ANNUNCIO
        private void modbutton_Click(object sender, EventArgs e)
        {
            try
            {
                annuncio annuncioa = new annuncio(idbox.Text, namebox.Text, descbox.Text, datebox.Text, Convert.ToInt32(pricebox.Text)); //dichiaro un annuncio

                b1.Modifica(idbox.Text, annuncioa);

                Aggiorna();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ELIMINA ANNUNCIO
        private void delbutton_Click(object sender, EventArgs e)
        {
            try
            {
                b1.Elimina(idbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Aggiorna();
        }

        //ORDINAMENTO PER PREZZO
        private void orderbutton_Click(object sender, EventArgs e)
        {
            b1.Ordinamento();

            Aggiorna();
        }

        //CALCOLO PREZZO TOTALE
        private void pricebutton_Click(object sender, EventArgs e)
        {
            price.Text = null;

            price.Text = b1.PrezzoTot().ToString();
        }
    }
}
