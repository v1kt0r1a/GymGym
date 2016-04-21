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
    public partial class AddTrainerForm : Form
    {
        MainForm _mainForm;
        public AddTrainerForm()
        {
            InitializeComponent();
        }

        private void addTrainerButton_Click(object sender, EventArgs e)
        {
            string date = dayTrainer.Text + "." + monthTrainer.Text + "." + yearTrainer.Text;
            new Trainer(nameTrainerBox.Text, surnameTrainerBox.Text,date, numberTrainerBox.Text, experienceBox.Text,categoryBox.Text);

            _mainForm.lbRefreshTrainer();
            Close();
        }

        private void AddTrainerForm_Load(object sender, EventArgs e)
        {
            _mainForm = (MainForm)this.Owner;
            categoryBox.DataSource = Enum.GetValues(typeof(TrainingType));
        }

    }
}
