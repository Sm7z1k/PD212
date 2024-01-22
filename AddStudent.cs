using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD_212_ADO
{
    public partial class AddStudent : Form
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Group { get; set; }
        public ComboBox GroupCombo 
        {
            get
            {
                return cbGroup;
            }
        }
        public AddStudent()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullName = tbFullName.Text;
            BirthDate = dtpBirthDate.Value;
            Group = cbGroup.SelectedItem.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
