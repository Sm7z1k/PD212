using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PD_212_ADO
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        DataTable table;
        SqlDataReader reader;
        string textTextBox1;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            //LoadTablesToComboBox();
            LoadGroupsToComboBox(cbGroup);
            SelectAllStudents();
        }
        void LoadTablesToComboBox()
        {
            string commandLine = @"SELECT table_name FROM information_schema.tables";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbGroup.Items.Add(reader[0]);
            }
            connection.Close();
            reader.Close();
        }
        public void LoadGroupsToComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            string commandLine = @"SELECT group_name FROM Groups";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox.Items.Add(reader[0]);
            }
            connection.Close();
            reader.Close();
        }

        void SelectAllStudents(string group = "")
        {
            string commandLine = @"SELECT last_name, first_name, middle_name, birth_date, group_name FROM Students JOIN Groups ON Students.[group]=Groups.group_id";
            if (group.Length != 0) commandLine += $" WHERE [group_name]='{group}'";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                table.Columns.Add(reader.GetName(i));
            }
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                row["birth_date"] = Convert.ToDateTime(reader["birth_date"]).ToString("yyyy.MM.dd");
                table.Rows.Add(row);
            }
            dgvStudents.DataSource = table;
            reader.Close();

            if (group.Length > 0)
            {
                cmd.CommandText = $@"SELECT COUNT(stud_id) FROM Students JOIN Groups ON Students.[group]=Groups.group_id WHERE [group_name]='{group}' GROUP BY group_name";
            }
            else
            {
                cmd.CommandText = $@"SELECT COUNT(stud_id) FROM Students JOIN Groups ON Students.[group]=Groups.group_id";
            }
            lbStudCount.Text = $"Кол-во студентов: {Convert.ToInt32(cmd.ExecuteScalar()).ToString()}";
            connection.Close();
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectAllStudents(cbGroup.SelectedItem.ToString().Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent add_student = new AddStudent();
            LoadGroupsToComboBox(add_student.GroupCombo);
            DialogResult result = add_student.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.Parameters.Add("@last_name", add_student.FullName.Split(' ')[0]);
                cmd.Parameters.Add("@first_name", add_student.FullName.Split(' ')[1]);
                if (add_student.FullName.Split(' ').Length == 3)
                    cmd.Parameters.Add("@middle_name", add_student.FullName.Split(' ')[2]);
                cmd.Parameters.Add("@birth_date", add_student.BirthDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.Add("@group", add_student.Group);
                cmd.CommandText = @"IF NOT EXISTS (SELECT stud_id FROM Students WHERE last_name=@last_name AND first_name=first_name AND middle_name=@middle_name) BEGIN INSERT INTO Students(last_name, first_name, middle_name, birth_date, [group]) VALUES (@last_name, @first_name, @middle_name, @birth_date, (SELECT group_id FROM Groups WHERE group_name=@group)) END";
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                cbGroup.SelectedItem = add_student.Group;
                SelectAllStudents();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                string commandLine = @"SELECT last_name, first_name, middle_name, birth_date, group_name FROM Students JOIN Groups ON Students.[group]=Groups.group_id";
                SqlCommand cmd = new SqlCommand(commandLine, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                table = new DataTable();
                int countSymbols = textBox1.TextLength;

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    table.Columns.Add(reader.GetName(i));
                }

                while (reader.Read())
                {
                    DataRow row = table.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader[0].ToString().Length >= countSymbols)
                        {
                            if (reader[0].ToString().ToLower().Substring(0, countSymbols) == textBox1.Text.ToLower()) row[i] = reader[i];
                        }

                        if (reader[1].ToString().Length >= countSymbols)
                        {
                            if (reader[1].ToString().ToLower().Substring(0, countSymbols) == textBox1.Text.ToLower()) row[i] = reader[i];
                        }

                        if (reader[2].ToString().Length >= countSymbols)
                        {
                            if (reader[2].ToString().ToLower().Substring(0, countSymbols) == textBox1.Text.ToLower()) row[i] = reader[i];
                        }
                    }
                    table.Rows.Add(row);
                }
                dgvStudents.DataSource = table;

                reader.Close();
                connection.Close();
            }
            else
            {
                SelectAllStudents();
            }
        }
    }
}
