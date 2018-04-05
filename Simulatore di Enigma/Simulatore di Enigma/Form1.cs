using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Simulatore_di_Enigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rotore rr;
        Rotore rm;
        Rotore rl;
        Rotore riflettore;
        bool backspace = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            rr = new Rotore("BDFHJLCPRTXVZNYEIWGAKMUSQO", label1, 'V');
            rm = new Rotore("AJDKSIRUXBLHWTMCQGZNPYFVOE", label2, 'E');
            rl = new Rotore("EKMFLGDQVZNTOWYHXUSPAIBRCJ", label3, 'Q');
            riflettore = new Rotore("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

            rr.SetProssimoRotore(rm);
            rm.SetProssimoRotore(rl);
            rl.SetProssimoRotore(riflettore);
            rm.SetPrecedenteRotore(rr);
            rl.SetPrecedenteRotore(rm);
            riflettore.SetPrecedenteRotore(rl);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Informazioni info = new Informazioni();
            info.ShowDialog();
        }

        private void buttonImpostazioni_Click(object sender, EventArgs e)
        {
            Impostazioni impo = new Impostazioni(this);
            impo.ShowDialog();
        }

        private void richTextBoxInput_KeyUp(object sender, KeyEventArgs e)
        {
            
           
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control) 
            {
                rr.Muovi();
                rr.InserisciInput((char)e.KeyValue);
                richTextBoxOutput.AppendText("" + rr.GetOutput());
            }
        }

        private void button1Up_Click(object sender, EventArgs e)
        {
            rr.Muovi();
        }

        private void button1Down_Click(object sender, EventArgs e)
        {
            rr.MuoviIndietro();
        }

        private void button2Up_Click(object sender, EventArgs e)
        {
            rm.Muovi();
        }

        private void button2Down_Click(object sender, EventArgs e)
        {
            rm.MuoviIndietro();
        }

        private void button3Up_Click(object sender, EventArgs e)
        {
            rl.Muovi();
        }

        private void button3Down_Click(object sender, EventArgs e)
        {
            rl.MuoviIndietro();
        }

        private void buttonElabora_Click(object sender, EventArgs e)
        {

            char[] chIn = richTextBoxInput.Text.ToUpper().ToCharArray();
            richTextBoxOutput.Text = "";
            for (int i = 0; i < chIn.Length; i++)
            {
                if (chIn[i] >= 65 && chIn[i] <= 90)
                {
                    rr.Muovi();
                    rr.InserisciInput(chIn[i]);
                    richTextBoxOutput.AppendText("" + rr.GetOutput());
                }
            }
        }

        public void CambiaRotori(string rot1, string rotNome1, char rotNotch1,
                                 string rot2, string rotNome2, char rotNotch2,
                                 string rot3, string rotNome3, char rotNotch3)
        {
            labelRotoreS.Text = rotNome1;
            labelRotoreM.Text = rotNome2;
            labelRotoreR.Text = rotNome3;
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotore(rot3, label1, rotNotch3);
            rm = new Rotore(rot2, label2, rotNotch2);
            rl = new Rotore(rot1, label3, rotNotch1);

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.SetProssimoRotore(rm);
            rm.SetProssimoRotore(rl);
            rl.SetProssimoRotore(riflettore);
            rm.SetPrecedenteRotore(rr);
            rl.SetPrecedenteRotore(rm);
            riflettore.SetPrecedenteRotore(rl);

            label1.Text = "A";
            label2.Text = "A";
            label3.Text = "A";
        }

        public void SetRiflettore(string refl)
        {
            riflettore = new Rotore(refl, null, '\0');
            riflettore.SetPrecedenteRotore(rl);
            rl.SetProssimoRotore(riflettore);
        }

        public string GetRiflettore()
        {
            return riflettore.GetLayout;
        }

        public string GetRotoreDestro()
        {
            return rr.GetLayout;
        }

        public string GetRotoreCentrale()
        {
            return rm.GetLayout;
        }

        public string GetRotoreSinistro()
        {
            return rl.GetLayout;
        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            int lunghezza = richTextBoxInput.Text.Length;
            richTextBoxInput.Text = "";
            richTextBoxOutput.Text = "";
            for (int i = 0; i < lunghezza; i++)
                rr.MuoviIndietro();
            richTextBoxInput.Select();
        }

    }

   
    
}
