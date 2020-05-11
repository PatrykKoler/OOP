using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BL
{
    public class Client
    {
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
    }
}
