using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connected_Database
{

    public partial class Form1 : Form
    {

        String connectionstring;
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\richa\Documents\WindowsForms\Connected_Database\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionstring);

            sqlConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
        }

        private void create_Button_Click(object sender, EventArgs e)
        {
            SqlParameter parameter_1 = new SqlParameter();
            parameter_1.ParameterName = "rollno_p";
            parameter_1.Value = int.Parse(rollNo_TextBox.Text);

            SqlParameter parameter_2 = new SqlParameter();
            parameter_2.ParameterName = "name_p";
            parameter_2.Value = Name_TextBox.Text;

            SqlParameter parameter_3 = new SqlParameter();
            parameter_3.ParameterName = "branch_p";
            parameter_3.Value = Branch_TextBox.Text;


            SqlCommand sqlCommand = new SqlCommand("INSERT INTO student VALUES(@rollno_p,@name_p,@branch_p)");
            sqlCommand.Connection = sqlConnection;


            sqlCommand.Parameters.Add(parameter_1);
            sqlCommand.Parameters.Add(parameter_2);
            sqlCommand.Parameters.Add(parameter_3);

            sqlCommand.ExecuteNonQuery();


        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            SqlParameter parameter_1 = new SqlParameter();
            parameter_1.ParameterName = "rollno_p";
            parameter_1.Value = int.Parse(rollNo_TextBox.Text);

            SqlParameter parameter_2 = new SqlParameter();
            parameter_2.ParameterName = "name_p";
            parameter_2.Value = Name_TextBox.Text;

            SqlParameter parameter_3 = new SqlParameter();
            parameter_3.ParameterName = "branch_p";
            parameter_3.Value = Branch_TextBox.Text;

            SqlCommand sqlCommand = new SqlCommand("UPDATE student Set name = @name_p,branch = @branch_p WHERE rollno = @rollno_p");
            sqlCommand.Connection = sqlConnection;


            sqlCommand.Parameters.Add(parameter_1);
            sqlCommand.Parameters.Add(parameter_2);
            sqlCommand.Parameters.Add(parameter_3);

            sqlCommand.ExecuteNonQuery();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            SqlParameter parameter_1 = new SqlParameter();
            parameter_1.ParameterName = "rollno_p";
            parameter_1.Value = int.Parse(rollNo_TextBox.Text);

            SqlCommand sqlCommand = new SqlCommand("DELETE FRom student WHERE rollno = @rollno_p");
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.Add(parameter_1);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
