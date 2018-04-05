using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Simulatore_di_Enigma
{
    public partial class Impostazioni : Form
    {
        public Impostazioni(Form1 formPrincipale)
        {
            InitializeComponent();
            this.formPrincipale = formPrincipale;
        }


        private Form1 formPrincipale;
        ArrayList al1, al2, al3;
        string rotore1, rotore2, rotore3, rotore4, rotore5;
     

        private void Impostazioni_Load(object sender, EventArgs e)
        {
            al1 = new ArrayList();
            al2 = new ArrayList();
            al3 = new ArrayList();
            al1.Add("Rotore I");
            al1.Add("Rotore II");
            al1.Add("Rotore III");
            al1.Add("Rotore IV");
            al1.Add("Rotore V");
            rotore1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
            rotore2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
            rotore3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
            rotore4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
            rotore5 = "VZBRGITYUPSDNHLXAWMJQOFECK";
            al2.Add(rotore1);
            al2.Add(rotore2);
            al2.Add(rotore3);
            al2.Add(rotore4);
            al2.Add(rotore5);
            al3.Add("Q");
            al3.Add("E");
            al3.Add("V");
            al3.Add("J");
            al3.Add("Z");
            listBoxRotoriDisponibili.Items.Clear();
            for (int i = 0; i < al1.Count; i++)
            {
                listBoxRotoriDisponibili.Items.Add(al1[i]);
            }
        
            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == formPrincipale.GetRotoreSinistro())
                {
                    listBoxRotoriDisponibili.Items.Remove(al1[i].ToString());
                    listBoxRotoriSelezionati.Items.Add(al1[i].ToString());
                    break;
                }
            }

            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == formPrincipale.GetRotoreCentrale())
                {
                    listBoxRotoriDisponibili.Items.Remove(al1[i].ToString());
                    listBoxRotoriSelezionati.Items.Add(al1[i].ToString());
                    break;
                }
            }
            for (int i = 0; i < al2.Count; i++)
            {
                if (al2[i].ToString() == formPrincipale.GetRotoreDestro())
                {
                    listBoxRotoriDisponibili.Items.Remove(al1[i].ToString());
                    listBoxRotoriSelezionati.Items.Add(al1[i].ToString());
                    break;
                }
            }
        }

        private void listBoxRotoriDisponibili_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBoxRotoriDisponibili.SelectedIndex >= 0)
            {
                for (int i = 0; i < al1.Count; i++)
                {
                    if (listBoxRotoriDisponibili.SelectedItem.ToString() == "" + al1[i])
                    {
                        labelStrutturaRotore.Text = "" + al2[i];
                        return;
                    }
                }
                //labelStrutturaRotore.Text = "";
            }
            
        }

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (listBoxRotoriDisponibili.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Seleziona un rotore!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                listBoxRotoriSelezionati.Items.Add(listBoxRotoriDisponibili.SelectedItem);
                listBoxRotoriDisponibili.Items.Remove(listBoxRotoriDisponibili.SelectedItem);
                labelStrutturaRotore.Text = "";
            }
        }

        private void buttonDeselect_Click(object sender, EventArgs e)
        {
            if (listBoxRotoriSelezionati.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Seleziona un rotore!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listBoxRotoriDisponibili.Items.Add(listBoxRotoriSelezionati.SelectedItem);
                listBoxRotoriSelezionati.Items.Remove(listBoxRotoriSelezionati.SelectedItem);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listBoxRotoriSelezionati.SelectedIndex > 0)
            {
                if (listBoxRotoriSelezionati.SelectedIndex >= 1)
                    listBoxRotoriSelezionati.SelectedIndex = listBoxRotoriSelezionati.SelectedIndex - 1;
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxRotoriSelezionati.SelectedIndex >= 0 && listBoxRotoriSelezionati.SelectedIndex != listBoxRotoriSelezionati.Items.Count - 1)
            {
                 
                    listBoxRotoriSelezionati.SelectedIndex = listBoxRotoriSelezionati.SelectedIndex + 1;
            }

            
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (listBoxRotoriSelezionati.Items.Count != 3)
            {
                MessageBox.Show(this, "Devi selezionare tre rotori!", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                ArrayList alRotore = new ArrayList();
                ArrayList alNomeRotore = new ArrayList();
                ArrayList alRotNotch = new ArrayList();

                for (int j = 0; j < listBoxRotoriSelezionati.Items.Count; j++)
                {
                    for (int i = 0; i < al1.Count; i++)
                    {
                        if (listBoxRotoriSelezionati.Items[j].ToString() == "" + al1[i])
                        {
                            alRotore.Add(al2[i]);
                            alNomeRotore.Add(al1[i].ToString().Substring(al1[i].ToString().LastIndexOf(" ")).Trim());
                            alRotNotch.Add(al3[i]);
                            break;
                        }
                    }
                }

                formPrincipale.CambiaRotori(alRotore[0].ToString(),
                                alNomeRotore[0].ToString(),
                                alRotNotch[0].ToString().ToCharArray()[0],
                                alRotore[1].ToString(),
                                alNomeRotore[1].ToString(),
                                alRotNotch[1].ToString().ToCharArray()[0],
                                alRotore[2].ToString(),
                                alNomeRotore[2].ToString(),
                                alRotNotch[2].ToString().ToCharArray()[0]);

              
          
                Close();
            }
        }



    }
}
