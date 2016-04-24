namespace GymGym
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.addTrainerButton = new System.Windows.Forms.Button();
            this.lbTrainer = new System.Windows.Forms.ListBox();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Клиенты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Тренера:";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(25, 460);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(105, 23);
            this.aboutButton.TabIndex = 24;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(148, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 23);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(560, 445);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(134, 38);
            this.addClientButton.TabIndex = 22;
            this.addClientButton.Text = "Добавить клиента";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // addTrainerButton
            // 
            this.addTrainerButton.Location = new System.Drawing.Point(560, 222);
            this.addTrainerButton.Name = "addTrainerButton";
            this.addTrainerButton.Size = new System.Drawing.Size(134, 38);
            this.addTrainerButton.TabIndex = 21;
            this.addTrainerButton.Text = "Добавить тренера";
            this.addTrainerButton.UseVisualStyleBackColor = true;
            this.addTrainerButton.Click += new System.EventHandler(this.addTrainerButton_Click);
            // 
            // lbTrainer
            // 
            this.lbTrainer.FormattingEnabled = true;
            this.lbTrainer.Location = new System.Drawing.Point(24, 43);
            this.lbTrainer.Name = "lbTrainer";
            this.lbTrainer.Size = new System.Drawing.Size(670, 160);
            this.lbTrainer.TabIndex = 30;
            this.lbTrainer.Click += new System.EventHandler(this.lbTrainer_Click);
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.Location = new System.Drawing.Point(28, 283);
            this.lbClient.Name = "lbClient";
            this.lbClient.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbClient.Size = new System.Drawing.Size(666, 147);
            this.lbClient.TabIndex = 31;
         
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить программу тренировок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbTrainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.addTrainerButton);
            this.Name = "MainForm";
            this.Text = "Gym";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button addTrainerButton;
        private System.Windows.Forms.ListBox lbTrainer;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.Button button1;
    }
}

