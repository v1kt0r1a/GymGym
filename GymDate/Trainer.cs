using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDate
{
    public class Trainer 
    {
        public static Dictionary<Guid, Trainer> Trainers = new Dictionary<Guid, Trainer>();

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public string MobNumber { get; set; }
        public string Category { get; set; }
        public string Experience { get; set; }

        public Guid Id { get; private set; }

        public List<Client> Clients
        {
            get
            {
                var res = new List<Client>();
                foreach (var item in TrainerClient.TrainerClients)
                {
                    if (item.Trainer == this) res.Add(item.Client);
                }
                return res;
            }
        }

        public Trainer(string fName, string sName, string category, string mobNumber, string experience, string date)
        {
            Name = fName;
            Surname = sName;
            Date = date;
            MobNumber = mobNumber;
            Experience = experience;
            Id = Guid.NewGuid();

            Trainers.Add(Id, this);
        }

        public override string ToString()
        {
            return Name + " " + Surname + " Дата рождения:" + Date + " Телефон:" + MobNumber + " Стаж работы:" + Experience + " Категория:" + Category;
        }
    }
}
