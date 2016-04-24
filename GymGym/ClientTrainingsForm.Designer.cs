namespace GymGym
{
    partial class ClientTrainingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.cbTrainers = new System.Windows.Forms.ComboBox();
            this.btnAddTraining = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTrainings = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тренировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тренер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиенты";
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(12, 37);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(303, 121);
            this.lbClients.TabIndex = 4;
            // 
            // cbTrainers
            // 
            this.cbTrainers.AllowDrop = true;
            this.cbTrainers.BackColor = System.Drawing.Color.White;
            this.cbTrainers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainers.Location = new System.Drawing.Point(117, 209);
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(198, 21);
            this.cbTrainers.TabIndex = 5;
            // 
            // btnAddTraining
            // 
            this.btnAddTraining.Location = new System.Drawing.Point(15, 287);
            this.btnAddTraining.Name = "btnAddTraining";
            this.btnAddTraining.Size = new System.Drawing.Size(154, 23);
            this.btnAddTraining.TabIndex = 6;
            this.btnAddTraining.Text = "Добавить тренировку";
            this.btnAddTraining.UseVisualStyleBackColor = true;
            this.btnAddTraining.Click += new System.EventHandler(this.btnAddTraining_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.trainerBindingSource;
            // 
            // cbTrainings
            // 
            this.cbTrainings.AllowDrop = true;
            this.cbTrainings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrainings.FormattingEnabled = true;
            this.cbTrainings.Location = new System.Drawing.Point(117, 171);
            this.cbTrainings.Name = "cbTrainings";
            this.cbTrainings.Size = new System.Drawing.Size(198, 21);
            this.cbTrainings.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(209, 287);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataSource = typeof(GymDate.Trainer);
            // 
            // ClientTrainingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(324, 322);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.cbTrainings);
            this.Controls.Add(this.btnAddTraining);
            this.Controls.Add(this.cbTrainers);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientTrainingsForm";
            this.Text = "ClientTrainingsForm";
            this.Load += new System.EventHandler(this.ClientTrainingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.ComboBox cbTrainers;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private System.Windows.Forms.Button btnAddTraining;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private System.Windows.Forms.ComboBox cbTrainings;
        private System.Windows.Forms.Button cancelBtn;
    }
}