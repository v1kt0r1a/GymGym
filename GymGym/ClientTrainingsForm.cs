using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymDate;
namespace GymGym
{
    public partial class ClientTrainingsForm : Form
    {
        MainForm mainForm;
        public ClientTrainingsForm()
        {
            InitializeComponent();
        }

        private void ClientTrainingsForm_Load(object sender, EventArgs e)
        {
            lbClients.DataSource = Client.Clients.Values.ToList();
            cbTrainers.DataSource = Trainer.Trainers.Values.ToList();
            mainForm = this.Owner as MainForm;
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            Client tempC = lbClients.SelectedItem as Client;
            Trainer tempT = cbTrainers.SelectedItem as Trainer;
            new TrainerClient(tempC, tempT);
            mainForm.lbRefreshClient();
            mainForm.lbRefreshTrainer();
            this.Close();
        }
    }
}
