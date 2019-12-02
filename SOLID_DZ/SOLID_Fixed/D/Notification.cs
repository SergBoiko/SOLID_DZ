using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Fixed.D
{
    public class Notification
    {
        private IMessenger _messenger;
        public Notification()
        {
            _messenger = new Email();
        }

        public void DoNotify()
        {
            _messenger.Send();
        }
    }
}
