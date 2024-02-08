using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;


namespace Oberfläche
{
    // folgende Status-Meldungen werden benötigt:
    // - LabelStatus: verbinden zu Outlook, einlesen der Mails, einlesen fertig
    // - ProFile ID auslesen
    // - Penta Status prüfen
    // - nach ButtonStart-Klick: QS1 starten, Datenübertragung, fertig
    // - Anzeige-LED Status: grau = warte auf UserInput, grün = Übertragung fertig, gelb = arbeitet, rot = Fehler
        public partial class SDReparatur : Form
        {
            public SDReparatur()
            {
                InitializeComponent();
            }


            private void Form1_Load(object sender, EventArgs e)
            {

                // auf Mails checken, ListItem befüllen, Count-Variable mitzählen
                int i = 0;
                if (i < 1)
                {
                    ButtonStart.Enabled = false;
                }
                else
                {
                    ButtonStart.Enabled = true;
                }

                // Status-LED improvisiert über einen Radio-button

                radioButton1.BackColor = Color.White;
                radioButton1.ForeColor = Color.Black;
                radioButton1.Text = "warte";


            }


            private void button1_Click(object sender, EventArgs e)
            {
            
            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    
}
