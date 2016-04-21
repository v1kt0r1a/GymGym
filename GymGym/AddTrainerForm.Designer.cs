namespace GymGym
{
    partial class AddTrainerForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.addTrainerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.experienceBox = new System.Windows.Forms.TextBox();
            this.numberTrainerBox = new System.Windows.Forms.TextBox();
            this.yearTrainer = new System.Windows.Forms.NumericUpDown();
            this.monthTrainer = new System.Windows.Forms.NumericUpDown();
            this.dayTrainer = new System.Windows.Forms.NumericUpDown();
            this.surnameTrainerBox = new System.Windows.Forms.TextBox();
            this.nameTrainerBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTrainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTrainer)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(297, 317);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 33;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // addTrainerButton
            // 
            this.addTrainerButton.Location = new System.Drawing.Point(73, 317);
            this.addTrainerButton.Name = "addTrainerButton";
            this.addTrainerButton.Size = new System.Drawing.Size(75, 23);
            this.addTrainerButton.TabIndex = 32;
            this.addTrainerButton.Text = "Добавить";
            this.addTrainerButton.UseVisualStyleBackColor = true;
            this.addTrainerButton.Click += new System.EventHandler(this.addTrainerButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(123, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Заполните данные";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Location = new System.Drawing.Point(146, 268);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(226, 21);
            this.categoryBox.TabIndex = 30;
            // 
            // experienceBox
            // 
            this.experienceBox.Location = new System.Drawing.Point(176, 233);
            this.experienceBox.Name = "experienceBox";
            this.experienceBox.Size = new System.Drawing.Size(34, 20);
            this.experienceBox.TabIndex = 29;
            // 
            // numberTrainerBox
            // 
            this.numberTrainerBox.Location = new System.Drawing.Point(193, 200);
            this.numberTrainerBox.Name = "numberTrainerBox";
            this.numberTrainerBox.Size = new System.Drawing.Size(127, 20);
            this.numberTrainerBox.TabIndex = 28;
            // 
            // yearTrainer
            // 
            this.yearTrainer.Location = new System.Drawing.Point(326, 168);
            this.yearTrainer.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.yearTrainer.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.yearTrainer.Name = "yearTrainer";
            this.yearTrainer.Size = new System.Drawing.Size(46, 20);
            this.yearTrainer.TabIndex = 27;
            this.yearTrainer.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // monthTrainer
            // 
            this.monthTrainer.Location = new System.Drawing.Point(273, 168);
            this.monthTrainer.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthTrainer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthTrainer.Name = "monthTrainer";
            this.monthTrainer.Size = new System.Drawing.Size(47, 20);
            this.monthTrainer.TabIndex = 26;
            this.monthTrainer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayTrainer
            // 
            this.dayTrainer.Location = new System.Drawing.Point(218, 168);
            this.dayTrainer.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayTrainer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayTrainer.Name = "dayTrainer";
            this.dayTrainer.Size = new System.Drawing.Size(49, 20);
            this.dayTrainer.TabIndex = 25;
            this.dayTrainer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // surnameTrainerBox
            // 
            this.surnameTrainerBox.Location = new System.Drawing.Point(132, 134);
            this.surnameTrainerBox.Name = "surnameTrainerBox";
            this.surnameTrainerBox.Size = new System.Drawing.Size(240, 20);
            this.surnameTrainerBox.TabIndex = 24;
            // 
            // nameTrainerBox
            // 
            this.nameTrainerBox.Location = new System.Drawing.Point(105, 102);
            this.nameTrainerBox.Name = "nameTrainerBox";
            this.nameTrainerBox.Size = new System.Drawing.Size(267, 20);
            this.nameTrainerBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Стаж работы (лет)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Номер телефона: +38";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата рождения: dd/mm/yy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя";
            // 
            // AddTrainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(442, 399);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.addTrainerButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.experienceBox);
            this.Controls.Add(this.numberTrainerBox);
            this.Controls.Add(this.yearTrainer);
            this.Controls.Add(this.monthTrainer);
            this.Controls.Add(this.dayTrainer);
            this.Controls.Add(this.surnameTrainerBox);
            this.Controls.Add(this.nameTrainerBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTrainerForm";
            this.Text = "AddTrainerForm";
            this.Load += new System.EventHandler(this.AddTrainerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTrainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTrainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button addTrainerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox experienceBox;
        private System.Windows.Forms.TextBox numberTrainerBox;
        private System.Windows.Forms.NumericUpDown yearTrainer;
        private System.Windows.Forms.NumericUpDown monthTrainer;
        private System.Windows.Forms.NumericUpDown dayTrainer;
        private System.Windows.Forms.TextBox surnameTrainerBox;
        private System.Windows.Forms.TextBox nameTrainerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}