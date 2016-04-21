using GymDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymGym
{
    public partial class MainForm : Form
    {
        private static AddClientFormcs _client;
        private static AddTrainerForm _trainer;
        private static ClientTrainingsForm _clientTrainer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTrainerButton_Click(object sender, EventArgs e)
        {
            if (_trainer != null)
            {
                _trainer.Close();
            }
            _trainer = new AddTrainerForm { Owner = this };
            _trainer.Show();
        }

        public void lbRefreshTrainer()
        {
            lbTrainer.DataSource = null;
            lbTrainer.DataSource = Trainer.Trainers.Values.ToList();
        }
        public void lbRefreshClient()
        {
            lbClient.DataSource = null;
            lbClient.DataSource = Client.Clients.Values.ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var t1 = new Trainer("Zalypa", "Konskaia", "Atletika", "0965325159", "opitniy", DateTime.Now.ToString());
            var t2 = new Trainer("Zalypa1", "Konskaia", "Atletika", "0965325159", "opitniy", DateTime.Now.ToString());
            var t3 = new Trainer("Zalypa2", "Konskaia", "Atletika", "0965325159", "opitniy", DateTime.Now.ToString());
            var t4 = new Trainer("Zalypa3", "Konskaia", "Atletika", "0965325159", "opitniy", DateTime.Now.ToString());

            var c1 = new Client("Sraka", "Govnodelov", DateTime.Now.ToString(), "0993313333", "dnevnoi", "mesiac", "dliaJirnix");
            var c2 = new Client("Sraka1", "Govnodelov", DateTime.Now.ToString(), "0993313333", "dnevnoi", "mesiac", "dliaJirnix");
            var c3 = new Client("Sraka2", "Govnodelov", DateTime.Now.ToString(), "0993313333", "dnevnoi", "mesiac", "dliaJirnix");
            var c4 = new Client("Sraka3", "Govnodelov", DateTime.Now.ToString(), "0993313333", "dnevnoi", "mesiac", "dliaJirnix");

            new TrainerClient(c1, t1);
            new TrainerClient(c1, t2);
            new TrainerClient(c2, t3);
            new TrainerClient(c2, t1);
            new TrainerClient(c3, t1);
            new TrainerClient(c3, t2);
            new TrainerClient(c3, t4);
            lbTrainer.DataSource = Trainer.Trainers.Values.ToList();
            lbClient.DataSource = Client.Clients.Values.ToList();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (_client != null)
            {
                _client.Close();
            }
            _client = new AddClientFormcs { Owner = this };
            _client.Show();
        }

        private void lbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbClient_Click(object sender, EventArgs e)
        {
            //if (_clientSelected != lbClient.SelectedItem as Client && _clientSelected!=null)
            //{
            //    lbClient.SelectedItems.Remove(_clientSelected);
            //    _clientSelected = lbClient.SelectedItem as Client;
            //}
            //Client temp = lbClient.SelectedItem as Client;
            //if (temp != null)
            //{
            //    lbTrainer.SelectedItems.Clear();
            //    foreach (var trainer in temp.Trainers)
            //    {
            //        lbTrainer.SelectedItems.Add(trainer);
            //    }
            //}

        }

        private void lbTrainer_Click(object sender, EventArgs e)
        {
            Trainer temp = lbTrainer.SelectedItem as Trainer;
            if (temp != null)
            {
                lbClient.SelectedItems.Clear();
                foreach (var client in temp.Clients)
                {
                    lbClient.SelectedItems.Add(client);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_clientTrainer != null)
            {
                _clientTrainer.Close();
            }
            _clientTrainer = new ClientTrainingsForm { Owner = this };
            _clientTrainer.Show();
        }
    }
}
