namespace PD_212_ADO
{
    partial class AddStudent
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
            this.lbFullName = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lbBirthDate = new System.Windows.Forms.Label();
            this.lbGroupName = new System.Windows.Forms.Label();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(13, 13);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(97, 13);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Ф. И. О студента:";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(16, 29);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(238, 20);
            this.tbFullName.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(16, 81);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(238, 20);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // lbBirthDate
            // 
            this.lbBirthDate.AutoSize = true;
            this.lbBirthDate.Location = new System.Drawing.Point(16, 56);
            this.lbBirthDate.Name = "lbBirthDate";
            this.lbBirthDate.Size = new System.Drawing.Size(89, 13);
            this.lbBirthDate.TabIndex = 5;
            this.lbBirthDate.Text = "Дата рождения:";
            // 
            // lbGroupName
            // 
            this.lbGroupName.AutoSize = true;
            this.lbGroupName.Location = new System.Drawing.Point(16, 114);
            this.lbGroupName.Name = "lbGroupName";
            this.lbGroupName.Size = new System.Drawing.Size(45, 13);
            this.lbGroupName.TabIndex = 6;
            this.lbGroupName.Text = "Группа:";
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(19, 140);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(235, 21);
            this.cbGroup.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(97, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbGroup);
            this.Controls.Add(this.lbGroupName);
            this.Controls.Add(this.lbBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lbFullName);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lbBirthDate;
        private System.Windows.Forms.Label lbGroupName;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
    }
}