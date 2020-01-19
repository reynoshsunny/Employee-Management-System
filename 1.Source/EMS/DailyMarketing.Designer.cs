namespace EMS
{
    partial class DailyMarketing
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtWorkDescription = new System.Windows.Forms.RichTextBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txtWorkName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.work_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWorkDescription
            // 
            this.txtWorkDescription.Location = new System.Drawing.Point(131, 107);
            this.txtWorkDescription.Name = "txtWorkDescription";
            this.txtWorkDescription.Size = new System.Drawing.Size(374, 199);
            this.txtWorkDescription.TabIndex = 3;
            this.txtWorkDescription.Text = "";
            this.txtWorkDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkDescription_KeyDown);
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(131, 327);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(75, 20);
            this.txt_Time.TabIndex = 4;
            this.txt_Time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Time_KeyDown);
            // 
            // txtWorkName
            // 
            this.txtWorkName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtWorkName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtWorkName.Location = new System.Drawing.Point(131, 69);
            this.txtWorkName.Name = "txtWorkName";
            this.txtWorkName.Size = new System.Drawing.Size(374, 20);
            this.txtWorkName.TabIndex = 2;
            this.txtWorkName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time (minute)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Work Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DATE";
            // 
            // work_Date
            // 
            this.work_Date.Location = new System.Drawing.Point(131, 26);
            this.work_Date.Name = "work_Date";
            this.work_Date.Size = new System.Drawing.Size(200, 20);
            this.work_Date.TabIndex = 1;
            this.work_Date.KeyDown += new System.Windows.Forms.KeyEventHandler(this.work_Date_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox1.Location = new System.Drawing.Point(406, 327);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Completed";
            // 
            // DailyMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtWorkDescription);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.txtWorkName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.work_Date);
            this.Name = "DailyMarketing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Marketing";
            this.Load += new System.EventHandler(this.DailyMarketing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtWorkDescription;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txtWorkName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker work_Date;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}