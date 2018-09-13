using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace SQLBumbleBee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ToolTip toolTip1 = new ToolTip();
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string Server1 = this.Server.Text;
            string Username = this.UserID.Text;
            string Password = this.Pin.Text;
            string Database = this.Database.Text;
            string Table = this.Table.Text;

 
            string ConnectionString = "Data Source=" + Server1 + ";";
            ConnectionString += "User ID=" + Username + ";";
            ConnectionString += "Password=" + Password + ";";
            ConnectionString += "Initial Catalog=" + Database;

            SqlConnection SQLConnection = new SqlConnection();
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Working...");
            try
            {
                SQLConnection.ConnectionString = ConnectionString;
                SQLConnection.Open();
            }
            catch (Exception Ex)
            {
                // Try to close the connection
                if (SQLConnection != null)
                    SQLConnection.Dispose();

                this.listBox1.Items.Add(ConnectionString);
                this.listBox1.Items.Add(Server1);
                this.listBox1.Items.Add(UserID);
                this.listBox1.Items.Add(Pin);
                this.listBox1.Items.Add(Database);
                this.listBox1.Items.Add(Col);

                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Ex.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return;
            }

            string SQLStatement = "SELECT * FROM " + Table;
 
            // Create a SqlDataAdapter to get the results as DataTable
            SqlDataAdapter SQLDataAdapter = new SqlDataAdapter(SQLStatement, SQLConnection);
 
            // Create a new DataTable
            this.listBox1.Items.Clear();
            DataTable dtResult = new DataTable();
          
            // Fill the DataTable with the result of the SQL statement
            SQLDataAdapter.Fill(dtResult);
 
            // Loop through all entries
            foreach (DataRow drRow in dtResult.Rows)
                {
                // Show a message box with the content of 
                // the "Name" column
                    listBox1.Items.Add(drRow[this.Col.Text]);
                }
 
            // We don't need the data adapter any more

            //DataTable tblSchema = SQLConnection.GetSchema();
            DataTable tblSchema = SQLConnection.GetSchema(SqlClientMetaDataCollectionNames.Columns);
          
            foreach (DataRow drCol in tblSchema.Rows)
                {
                    //this.listBox2.Items.Add(drRow[drCol]);
                    this.listBox2.Items.Add(drCol[3].ToString());
                }

            SQLDataAdapter.Dispose();
 
            SQLConnection.Close();
            SQLConnection.Dispose();
            }

        private void ManualQuery_DoubleClick(object sender, EventArgs e)
        {
            string Server1 = this.Server.Text;
            string Username = this.UserID.Text;
            string Password = this.Pin.Text;
            string Database = this.Database.Text;
            string Table = this.Table.Text;

            string concatstring = "";

            string ConnectionString = "Data Source=" + Server1 + ";";
            ConnectionString += "User ID=" + Username + ";";
            ConnectionString += "Password=" + Password + ";";
            ConnectionString += "Initial Catalog=" + Database;

            SqlConnection SQLConnection = new SqlConnection();

            try
            {
                SQLConnection.ConnectionString = ConnectionString;
                SQLConnection.Open();

                // You can get the server version 
                // SQLConnection.ServerVersion
            }
            catch (Exception Ex)
            {
                // Try to close the connection
                if (SQLConnection != null)
                    SQLConnection.Dispose();

                this.listBox1.Items.Add(ConnectionString);
                this.listBox1.Items.Add(Server1);
                this.listBox1.Items.Add(UserID);
                this.listBox1.Items.Add(Pin);
                this.listBox1.Items.Add(Database);
                this.listBox1.Items.Add(Col);

                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Ex.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return;
            }

            string SQLStatement = this.ManualQuery.Text;

            // Create a SqlDataAdapter to get the results as DataTable
            SqlDataAdapter SQLDataAdapter = new SqlDataAdapter(SQLStatement, SQLConnection);

            // Create a new DataTable
            DataTable dtResult = new DataTable();
                         
            try
            {
                // Fill the DataTable with the result of the SQL statement
                SQLDataAdapter.Fill(dtResult);
                this.listBox1.Items.Clear();

                // Loop through all entries
                foreach (DataRow drRow in dtResult.Rows)
                {
                  //listBox1.Items.Add(drRow[this.Col.Text]);
                  //listBox1.Items.Add(drRow);
                    foreach (var item in drRow.ItemArray)
                    {
                        concatstring = concatstring + item + ", ";
                    }
                    listBox1.Items.Add(concatstring);
                    concatstring = "";
                }
             }
            catch (Exception Ex)
            {
                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Ex.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return;
            }
            // We don't need the data adapter any more
            SQLDataAdapter.Dispose();

            SQLConnection.Close();
            SQLConnection.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Greetings I was created by Paul R. Heintz as a demo program");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Server1 = this.Server.Text;
            string Username = this.UserID.Text;
            string Password = this.Pin.Text;
            string Database = this.Database.Text;
            string Table = this.Table.Text;
            this.Col.Text = this.listBox2.SelectedItem.ToString();

            string ConnectionString = "Data Source=" + Server1 + ";";
            ConnectionString += "User ID=" + Username + ";";
            ConnectionString += "Password=" + Password + ";";
            ConnectionString += "Initial Catalog=" + Database;

            SqlConnection SQLConnection = new SqlConnection();

            try
            {
                SQLConnection.ConnectionString = ConnectionString;
                SQLConnection.Open();
                listBox1.Items.Clear();
            }
            catch (Exception Ex)
            {
                // Try to close the connection
                if (SQLConnection != null)
                    SQLConnection.Dispose();

                this.listBox1.Items.Add(ConnectionString);
                this.listBox1.Items.Add(Server1);
                this.listBox1.Items.Add(UserID);
                this.listBox1.Items.Add(Pin);
                this.listBox1.Items.Add(Database);
                this.listBox1.Items.Add(Col);

                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Ex.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return;
            }

            string SQLStatement = "SELECT * FROM " + Table;
            
            // Create a SqlDataAdapter to get the results as DataTable
            SqlDataAdapter SQLDataAdapter = new SqlDataAdapter(SQLStatement, SQLConnection);

            // Create a new DataTable
            DataTable dtResult = new DataTable();

            // Fill the DataTable with the result of the SQL statement
            SQLDataAdapter.Fill(dtResult);

            try
            {
                // Loop through all entries
                foreach (DataRow drRow in dtResult.Rows)
                {
                    // Show a message box with the content of 
                    // the "Name" column
                    //MessageBox.Show(drRow["Name"].ToString());
                    listBox1.Items.Add(drRow[this.Col.Text]);
                }
            }
            catch (Exception Ex)
            {
                // Create a (useful) error message
                string ErrorMessage = "A error occurred while trying to connect to the server.";
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Environment.NewLine;
                ErrorMessage += Ex.Message;

                // Show error message (this = the parent Form object)
                MessageBox.Show(this, ErrorMessage, "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Stop here
                return;
            }
            SQLDataAdapter.Dispose();
            SQLConnection.Close();
            SQLConnection.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox2_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
                    
  }

}