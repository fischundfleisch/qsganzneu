using Oberfläche;
using System;
using System.Collections.Generic;
using System.Reflection;  

using Outlook = Microsoft.Office.Interop.Outlook;

namespace MailInterop
{
    public class MailReader
    {
        private List<ReturnMessage> _returnMessages = new List<ReturnMessage>();

        public List<ReturnMessage> ReturnMessages
        {
            get { return _returnMessages; }
        }
        public void ReadMail()  
        {
            try
            {

                Outlook.Application oApp = new Outlook.Application();

                Outlook.NameSpace oNS = oApp.GetNamespace("mapi");

                // Log on by using the default profile or existing session (no dialog box).
                oNS.Logon(Missing.Value, Missing.Value, false, true);

                // Alternate logon method that uses a specific profile name.
                // TODO: If you use this logon method, specify the correct profile name
                // and comment the previous Logon line.
                //oNS.Logon("profilename",Missing.Value,false,true);

                //Get the Inbox folder.
                Outlook.MAPIFolder oInbox = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);

                //Get the Items collection in the Inbox folder.
                Outlook.Items oItems = oInbox.Items;

                foreach (Object Item in oInbox.Items)
                {
                    Outlook.MailItem oMsg = (Outlook.MailItem)oItems.GetNext();
                    _returnMessages.Add(new ReturnMessage(oMsg.ReceivedTime, oMsg.Body));
                    oMsg = null;

                }

                //Log off.
                oNS.Logoff();

                //Explicitly release objects.
                
                oItems = null;
                oInbox = null;
                oNS = null;
                oApp = null;
            }

            //Error handler.
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught: ", e);
            }

        }
    }
}