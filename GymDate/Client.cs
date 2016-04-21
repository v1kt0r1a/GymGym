using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDate
{
    public class Client 
    {
        public static Dictionary<Guid, Client> Clients = new Dictionary<Guid, Client>();
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Date { get; set; }
        public string MobNumber { get; set; }
        public string TypeAbon { get; set; }
        public string Term { get; set; }
        public string TrainingProg { get; set; }
        public Guid Id { get; private set; }

        public List<Trainer> Trainers
        {
            get
            {
                var res = new List<Trainer>();
                foreach (var item in TrainerClient.TrainerClients)
                {
                    if (item.Client == this)
                    {
                        res.Add(item.Trainer);
                    }
                }
                return res;
            }
        }

        public Client(string fName, string sName, string date, string mobNumber, string typeAbon, string term, string trainingProg)
        {
            Name = fName;
            Surname = sName;
            Date = date;
            MobNumber = mobNumber;
            TypeAbon = typeAbon;
            Term = term;
            TrainingProg = trainingProg;
            Id = Guid.NewGuid();

            Clients.Add(Id, this);
        }
        public override string ToString()
        {
            return Name + " " + Surname + " | " + Date + " | " + MobNumber + " | " + TypeAbon;
        } 
    }
}
