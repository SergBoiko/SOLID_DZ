using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_DZ.D
{
    public class Email
    {
        public void Send()
        {
            
        }
    }
    public class Notification
    {
        private Email email;
        public Notification()
        {
            email = new Email();
        }

        public void EmailDistribution()
        {
            email.Send();
        }
    }
}
