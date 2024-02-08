using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailInterop;
using Microsoft.Office.Interop.Outlook;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
        private MailReader _mailReader = new MailReader();
        public SDReparatur()
            {
                InitializeComponent();
            }


        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            const int kNotFound = -1;

            var startIdx = strSource.IndexOf(strStart);
            if (startIdx != kNotFound)
            {
                startIdx += strStart.Length;
                var endIdx = strSource.IndexOf(strEnd, startIdx);
                if (endIdx > startIdx)
                {
                    return strSource.Substring(startIdx, endIdx - startIdx);
                }
            }

            // Wenn nicht gefunden unbedingt Fehlermeldung und loggen!
            return "string";
        }

        private void Form1_Load(object sender, EventArgs e)
            {
            int itemcount = 0;
            ListItemRep.Items.Add("Datum , " + "RepNr , " + "RM , " + "count");
            LabelStatus.Text = "Status: lese Mails von Outlook ein";

           // auf Mails checken, ListItem befüllen, Count-Variable mitzählen
            _mailReader.ReadMail();

            foreach (var returnMessage in _mailReader.ReturnMessages)
            {
                string source = returnMessage.Message;
                string RepNr = getBetween(source, "RepNr.:", "-");
                string RmNr = getBetween(source, "RM:", "Rep");
                itemcount++;
                ListItemRep.Items.Add($"{returnMessage.ReceivedTime} , " + $"{RepNr} , " + $"{RmNr} , " + itemcount);
            }
            LabelStatus.Text = "Mails fertig eingelesen, verbinde zu ProFile";

            //Button erst wenn auch Profile und Penta eingelesen ist! Globale Statusvariable irgendwie umgehen?
            
            if (itemcount > 0)
            {
                ButtonStart.Enabled = true;
            }
            else
            {
                ButtonStart.Enabled = false;
                LabelStatus.Text = "Konnte keine neuen Mails finden!";
            }
       // Status-LED improvisiert über einen Radio-button
            radioButton1.BackColor = Color.White;
            radioButton1.ForeColor = Color.Black;
            radioButton1.Text = "warte";


            }

            private void Button1_Click(object sender, EventArgs e)
            {
            var process_id_profile = Start_Process_Test.StartProcess("notepad.exe");
            //var process_id_profile = Start_Process_Test.StartProcess("C:/Program Files (x86)/Citrix/ICA Client/SelfServicePlugin/SelfService.exe" - launch - reg "Software/Microsoft/Windows/CurrentVersion/Uninstall/passthroug-694b9c6e1@@VAD.PSIpenta XA19" - startmenuShortcut);
             }

            private void RadioButton1_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    
}
