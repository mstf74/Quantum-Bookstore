using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quantum_Bookstore.Interfaces;

namespace Quantum_Bookstore.Services
{
    public class MailService : ISendableByMail
    {
        public static readonly MailService Instance = new MailService();

        private MailService() { }

        public void SendToMail(string mail)
        {
            Console.WriteLine($"sending the book to {mail}");
            ;
        }
    }
}
