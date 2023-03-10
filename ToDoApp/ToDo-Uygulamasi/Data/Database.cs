using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Uygulamasi.Data
{
    public class Database
    {
        private static List<Card> _cards;
        private static List<Person> _persons;
        static Database()
        {
            _cards = new List<Card>()
            {
                new Card()
                {
                    Header = "Frontend",
                    Content = "Butonların değiştirilmesi",
                    Size = "XL",
                    Person = "Emre",
                    Status = "InProgress"
                },
                new Card()
                {
                    Header = "Backend",
                    Content = "SQL kodlarının revize edilmesi",
                    Size = "L",
                    Person = "Enes",
                    Status = "Done"
                },
                new Card()
                {
                    Header = "QA",
                    Content = "Buton değişikliğinin kalite kontrol testinin yapılması",
                    Size = "S",
                    Person = "Eray",
                    Status = "ToDo"
                }
            };
            _persons = new List<Person>()
            {
                new Person()
                {
                    Name = "Enes",
                    Team = "Frontend",
                    ID = 1
                },
                new Person()
                {
                    Name = "Emre",
                    Team = "Backend",
                    ID = 2
                },
                new Person()
                {
                    Name = "Eray",
                    Team = "QA",
                    ID = 3
                }
            };
        }
        public static List<Card> Card => _cards;
        public static List<Person> Person => _persons;
    }
}
