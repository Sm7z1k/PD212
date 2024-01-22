namespace PD_212_ADO
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.lbStudCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.tbPrep = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStudents);
            this.tabControl1.Controls.Add(this.tbPrep);
            this.tabControl1.Location = new System.Drawing.Point(-4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // tpStudents
            // 
            this.tpStudents.Controls.Add(this.textBox1);
            this.tpStudents.Controls.Add(this.lbStudCount);
            this.tpStudents.Controls.Add(this.btnAdd);
            this.tpStudents.Controls.Add(this.cbGroup);
            this.tpStudents.Controls.Add(this.dgvStudents);
            this.tpStudents.Location = new System.Drawing.Point(4, 22);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudents.Size = new System.Drawing.Size(792, 420);
            this.tpStudents.TabIndex = 0;
            this.tpStudents.Text = "Студенты";
            this.tpStudents.UseVisualStyleBackColor = true;
            // 
            // lbStudCount
            // 
            this.lbStudCount.AutoSize = true;
            this.lbStudCount.Location = new System.Drawing.Point(580, 15);
            this.lbStudCount.Name = "lbStudCount";
            this.lbStudCount.Size = new System.Drawing.Size(95, 13);
            this.lbStudCount.TabIndex = 3;
            this.lbStudCount.Text = "Кол-во студентов";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(720, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbGroup
            // 
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(434, 8);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(140, 21);
            this.cbGroup.TabIndex = 1;
            this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(-4, 33);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(789, 382);
            this.dgvStudents.TabIndex = 0;
            // 
            // tbPrep
            // 
            this.tbPrep.Location = new System.Drawing.Point(4, 22);
            this.tbPrep.Name = "tbPrep";
            this.tbPrep.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrep.Size = new System.Drawing.Size(792, 420);
            this.tbPrep.TabIndex = 1;
            this.tbPrep.Text = "Преподаватели";
            this.tbPrep.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpStudents.ResumeLayout(false);
            this.tpStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TabPage tbPrep;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbStudCount;
        private System.Windows.Forms.TextBox textBox1;
    }
}

