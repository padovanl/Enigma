using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulatore_di_Enigma
{
    class Rotore
    {
        //variabile che rappresenta la disposizione delle lettere
        private string layout;

        //variabile che rappresenta lo spostamento del rotore su se stesso
		private byte offset;

        //variabili che rappresentano i rotori adiacenti a quello in questione
		private Rotore precedente, successivo;

        //label associata al rotore, che ne visualizzerà le informazioni
		private Label lbl;

        //la variabile cIn rappresenta il carattere in ingresso, notchPos il carattere di scambio dei rotori
		private char cIn = '\0', notchPos;
	
        //metodo costruttore della classe
		public Rotore(string layout,Label lbl,char notchPos)
		{
			this.layout = layout;
			this.precedente = precedente;
			this.successivo = successivo;
			this.lbl = lbl;
			this.notchPos = notchPos;
			offset = 0;
			
		}
		
		public string GetLayout
        {
            get { return layout; }
            set { layout = value; }
			
		}
		
		public void SetProssimoRotore(Rotore successivo)
        {
            this.successivo = successivo;
		}

		public void SetPrecedenteRotore(Rotore precedente)
        {
            this.precedente = precedente;
		}
		
        // metodo che accetta in ingresso una stringa e ritorna il carattere corrispondente
		public char GetCarattereInverso(string ch)
        {
			int pos = layout.IndexOf(ch);
			
			if(offset>pos)
				pos = 26 - (offset-pos);
			else
				pos = pos - offset;
			
			
			if(precedente != null)
                pos = (pos + precedente.GetOffset) % 26;


            return (char)(65 + pos);
		}
		
		public byte GetOffset
        {
            get { return offset; }
            set { offset = value; }
		}
		
		public char GetNotchPos
        {
            get { return notchPos; }
            set { notchPos = value; }
		}
		
		public void ResetOffset()
        {
			offset = 0;
		}
		
		public bool HaSuccessivo()
        {
            if (successivo != null)
                return true;
            else
                return false;
         
		}
		
		public bool HaPrecedente()
        {
            if (precedente != null)
                return true;
            else
                return false;
		}
		
        //metodo che simula la rotazione intorno al proprio asse del rotore
		public void Muovi()
        {
            if (successivo != null)
            {

                offset++;
                if (offset == 26)
                {
                    offset = 0;
                }

                if (successivo != null && (offset + 66) == ((notchPos - 64) % 26) + 66)
                {
                    successivo.Muovi();
                }
                lbl.Text = "" + ((char)(65 + offset));
            }
		}
		
		public void MuoviIndietro()
        {
			if(offset==0)
				offset = 26;
			offset--;
            lbl.Text = "" + ((char)(65 + offset));
		}
		
        //metodo per l'inserimento del carattere digitato dall'utente
		public void InserisciInput(char s)
        {
			cIn = s;
			char c = s;
			c = (char)(((c - 65) + offset) % 26 + 65);
			
			if(successivo!=null)
            {
				c = layout.Substring((c-65),1).ToCharArray()[0];
                if ((((c - 65) + (-offset)) % 26 + 65) >= 65)
                    c = (char)(((c - 65) + (-offset)) % 26 + 65);
                else
                    c = (char)(((c - 65) + (26 + (-offset))) % 26 + 65);
				
				successivo.InserisciInput(c);
				
			}
		}
		
        //metodo per ottenere la lettera codificata
		public char GetOutput()
        {
			char c = '\0';
			
			if(successivo!=null)
            {
				c = successivo.GetOutput();
                c = GetCarattereInverso("" + c);
			}
            else //solo nel caso del riflettore
            {
                c = layout.Substring((cIn - 65), 1).ToCharArray()[0];
                c = (char)(((c - 65) + precedente.offset) % 26 + 65);
				
			}
			
			return c;
		}
    }
}
