using System.Collections.Generic;
using System;
namespace ABC.BL
{
    public class ClientRepository
    {
        public bool Save()
        {
            return true;
        }
        public Client Pobierz(int clientId)
        {
            Client client = new Client(clientId);

            if (clientId == 1)
            {
                client.Email = "patryk@wp.pl";
                client.Name = "Patryk";
                client.Surname = "Nowak";
            }
            return client;
        }
        public List<Client> Pobierz()
        {
            return new List<Client>();
        }
    }
}
