using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Client
    {
        public Client()
        {

        }

        public Client(int clientId)
        {
            this.clientId = clientId;
        }
        public static int Licznik { get; set; }


        private string _surname;
        public string Surname{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int clientId { get; private set; }
        public string nameSurname 
        { get 
            {
                string namesurname = Name;
                if (!string.IsNullOrWhiteSpace(Surname))
                {
                    if (!string.IsNullOrWhiteSpace(namesurname))
                    {
                        namesurname += ", ";
                    }
                    namesurname += Surname;
                }
                return namesurname; 
            }
        }
        public bool zwaliduj()
        {
            var poprawne = true;
            if (string .IsNullOrWhiteSpace(Surname))
            {
                poprawne = false;
            }
            if (string.IsNullOrWhiteSpace(Email))
            {
                poprawne = false;
            }
            return poprawne;
        }
        public bool save()
        {
            return true;
        }
        public Client Pobierz(int clientId)
        {
            return new Client();
        }
        public List<Client> Pobierz()
        {
            return new List<Client>();
        }
    }
}
