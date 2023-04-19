using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonExamen3
{
    internal class Hotel
    {
        public ArrayList clients = new ArrayList();

        public Hotel() { }

        public void ajouterClient(Clients client)
        {
            clients.Add(client);
        }
    }
}
