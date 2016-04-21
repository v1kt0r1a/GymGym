using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymDate
{
    public class TrainerClient
    {
        static public List<TrainerClient> TrainerClients = new List<TrainerClient>();
        private Guid _clientId;
        private Guid _trainerId;
        public Client Client
        {
            get { return Client.Clients[_clientId]; }
            set { _clientId = value.Id; }
        }
        public Trainer Trainer
        {
            get { return Trainer.Trainers[_trainerId]; }
            set { _trainerId = value.Id; }
        }

        public TrainerClient(Client client, Trainer trainer)
        {
            Client = client;
            Trainer = trainer;
            TrainerClients.Add(this);
        }
    }
}
