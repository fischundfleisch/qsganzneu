using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oberfläche
{
    public class ReturnMessage
    {
        private DateTime _receivedTime;
        private string _message;

        public ReturnMessage(DateTime receivedTime,string message)
        {
            _receivedTime = receivedTime;
            _message = message;
        }

        public string Message =>  _message;

        //DateOnly!!!
        // var today = DateOnly.FromDateTime(DateTime.Now);
        public DateTime ReceivedTime => _receivedTime;
    }
}

