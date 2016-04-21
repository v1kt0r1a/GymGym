namespace GymGym
{
    partial class AddClientFormcs
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
            this.programmTrainingBox = new System.Windows.Forms.ComboBox();
            this.yearTermBox = new System.Windows.Forms.NumericUpDown();
            this.monthTermBox = new System.Windows.Forms.NumericUpDown();
            this.dayTermBox = new System.Windows.Forms.NumericUpDown();
            this.typeAbonBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberClientBox = new System.Windows.Forms.TextBox();
            this.yearClient = new System.Windows.Forms.NumericUpDown();
            this.monthClient = new System.Windows.Forms.NumericUpDown();
            this.dayClient = new System.Windows.Forms.NumericUpDown();
            this.surnameClientBox = new System.Windows.Forms.TextBox();
            this.nameClientBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearTermBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTermBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTermBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayClient)).BeginInit();
            this.SuspendLayout();
            // 
            // programmTrainingBox
            // 
            this.programmTrainingBox.FormattingEnabled = true;
            this.programmTrainingBox.Location = new System.Drawing.Point(178, 264);
            this.programmTrainingBox.Name = "programmTrainingBox";
            this.programmTrainingBox.Size = new System.Drawing.Size(121, 21);
            this.programmTrainingBox.TabIndex = 60;
            // 
            // yearTermBox
            // 
            this.yearTermBox.Location = new System.Drawing.Point(303, 232);
            this.yearTermBox.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.yearTermBox.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.yearTermBox.Name = "yearTermBox";
            this.yearTermBox.Size = new System.Drawing.Size(40, 20);
            this.yearTermBox.TabIndex = 59;
            this.yearTermBox.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // monthTermBox
            // 
            this.monthTermBox.Location = new System.Drawing.Point(256, 232);
            this.monthTermBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthTermBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthTermBox.Name = "monthTermBox";
            this.monthTermBox.Size = new System.Drawing.Size(35, 20);
            this.monthTermBox.TabIndex = 58;
            this.monthTermBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayTermBox
            // 
            this.dayTermBox.Location = new System.Drawing.Point(211, 232);
            this.dayTermBox.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayTermBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayTermBox.Name = "dayTermBox";
            this.dayTermBox.Size = new System.Drawing.Size(36, 20);
            this.dayTermBox.TabIndex = 57;
            this.dayTermBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // typeAbonBox
            // 
            this.typeAbonBox.FormattingEnabled = true;
            this.typeAbonBox.Items.AddRange(new object[] {
            "Дневной ",
            "Вечерний",
            "Безлимит"});
            this.typeAbonBox.Location = new System.Drawing.Point(137, 201);
            this.typeAbonBox.Name = "typeAbonBox";
            this.typeAbonBox.Size = new System.Drawing.Size(121, 21);
            this.typeAbonBox.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Программа тренировок:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Срок действия абонемента до:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Тип абонемента";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(94, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Заполните данные";
            // 
            // numberClientBox
            // 
            this.numberClientBox.Location = new System.Drawing.Point(164, 168);
            this.numberClientBox.Name = "numberClientBox";
            this.numberClientBox.Size = new System.Drawing.Size(127, 20);
            this.numberClientBox.TabIndex = 51;
            // 
            // yearClient
            // 
            this.yearClient.Location = new System.Drawing.Point(297, 136);
            this.yearClient.Maximum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.yearClient.Minimum = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            this.yearClient.Name = "yearClient";
            this.yearClient.Size = new System.Drawing.Size(46, 20);
            this.yearClient.TabIndex = 50;
            this.yearClient.Value = new decimal(new int[] {
            1970,
            0,
            0,
            0});
            // 
            // monthClient
            // 
            this.monthClient.Location = new System.Drawing.Point(244, 136);
            this.monthClient.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthClient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthClient.Name = "monthClient";
            this.monthClient.Size = new System.Drawing.Size(47, 20);
            this.monthClient.TabIndex = 49;
            this.monthClient.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dayClient
            // 
            this.dayClient.Location = new System.Drawing.Point(189, 136);
            this.dayClient.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayClient.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayClient.Name = "dayClient";
            this.dayClient.Size = new System.Drawing.Size(49, 20);
            this.dayClient.TabIndex = 48;
            this.dayClient.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // surnameClientBox
            // 
            this.surnameClientBox.Location = new System.Drawing.Point(103, 102);
            this.surnameClientBox.Name = "surnameClientBox";
            this.surnameClientBox.Size = new System.Drawing.Size(240, 20);
            this.surnameClientBox.TabIndex = 47;
            // 
            // nameClientBox
            // 
            this.nameClientBox.Location = new System.Drawing.Point(76, 70);
            this.nameClientBox.Name = "nameClientBox";
            this.nameClientBox.Size = new System.Drawing.Size(267, 20);
            this.nameClientBox.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Номер телефона: +38";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Дата рождения: dd/mm/yy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Имя";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddClientFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(391, 347);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.programmTrainingBox);
            this.Controls.Add(this.yearTermBox);
            this.Controls.Add(this.monthTermBox);
            this.Controls.Add(this.dayTermBox);
            this.Controls.Add(this.typeAbonBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberClientBox);
            this.Controls.Add(this.yearClient);
            this.Controls.Add(this.monthClient);
            this.Controls.Add(this.dayClient);
            this.Controls.Add(this.surnameClientBox);
            this.Controls.Add(this.nameClientBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClientFormcs";
            this.Text = "AddClientFormcs";
            this.Load += new System.EventHandler(this.AddClientFormcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearTermBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthTermBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayTermBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox programmTrainingBox;
        private System.Windows.Forms.NumericUpDown yearTermBox;
        private System.Windows.Forms.NumericUpDown monthTermBox;
        private System.Windows.Forms.NumericUpDown dayTermBox;
        private System.Windows.Forms.ComboBox typeAbonBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberClientBox;
        private System.Windows.Forms.NumericUpDown yearClient;
        private System.Windows.Forms.NumericUpDown monthClient;
        private System.Windows.Forms.NumericUpDown dayClient;
        private System.Windows.Forms.TextBox surnameClientBox;
        private System.Windows.Forms.TextBox nameClientBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}