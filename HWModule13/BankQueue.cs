using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule13
{
    public class BankQueue
    {
        private Queue<Client> clientsQueue = new Queue<Client>();

        public int Count => clientsQueue.Count;

        public void Enqueue(Client client)
        {
            clientsQueue.Enqueue(client);
        }

        public Client Dequeue()
        {
            return clientsQueue.Dequeue();
        }
    }
}
