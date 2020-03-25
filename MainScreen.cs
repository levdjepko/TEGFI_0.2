using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TEGFI_3
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ConnectionString { get; set; }
        //this is the main connection string to our database
        public string UserName { get; set; }
        //SELECT ALL command here
        private void loadExpenses_button_Click(object sender, EventArgs e)
        {
            if (userName.TextLength == 0)
            {
                userName.Text = "Admin";
                UserName = userName.Text;
            }
            else
            {
                UserName = userName.Text;
            }
            
            MySqlConnection cnn;
            ConnectionString = "Server=3.227.166.251; database=U053QS; UID=U053QS; password=53688416942";
            cnn = new MySqlConnection(ConnectionString);

            // Your sql command
            MySqlCommand selectData;

            // Create the sql command
            selectData = cnn.CreateCommand();

            //\"admin\"

            // Declare the sript of sql command
            selectData.CommandText = $"SELECT id, expense, date, Type, ten_year FROM U053QS.expenses WHERE user = \"{UserName}\"";

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectData.CommandText, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        //INSERT EXPENSE command here
        private void addExpense_Button_Click(object sender, EventArgs e)
        {
            //check the user name associated with this command
            if (userName.TextLength == 0)
            {
                userName.Text = "Admin";
                UserName = userName.Text;
            }
            else
            {
                UserName = userName.Text;
            }
            
            try
            {
                //This is my connection string i have assigned the database file address path  
                 string MyConnection2 = "Server=3.227.166.251; database=U053QS; UID=U053QS; password=53688416942";
                //This is my insert query in which i am taking input from the user through windows forms 
                if (Double.TryParse(amountBox.Text, out double result))
                {
                    //get the amount of this expense in ten years
                    double tenYearsAmount = 0.0;
                    if (oneTime_Button.Checked)
                    {
                        tenYearsAmount = WealthEstimator.EstimateTenYearsAmount_OneTime(Double.Parse(amountBox.Text));
                        tenYears_Amount.Text = tenYearsAmount.ToString("C0"); 
                    }
                    if (monthlyButton.Checked)
                    {
                        tenYearsAmount = WealthEstimator.EstimateTenYearsAmount_Monthly(Double.Parse(amountBox.Text));
                        tenYears_Amount.Text = tenYearsAmount.ToString("C0");
                    }

                    string Query = $"INSERT INTO `U053QS`.`expenses` (`user`, `expense`, `date`) VALUES (\"{UserName}\", '{amountBox.Text}', CURRENT_DATE());";
                    //This is  MySqlConnection here i have created the object and pass my connection string.  
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    //This is command class which will handle the query and connection object.  
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Expense added");
                    
                    MyConn2.Close();
                }
                else
                {
                    MessageBox.Show("The data is in incorrect format");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int SelectedID { get; set; }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //do nothing
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show(SelectedID.ToString());
        }

        private void modifyExpense_Button_Click(object sender, EventArgs e)
        {
            //nothing here yet
        }

        private void deleteExpense_Button_Click(object sender, EventArgs e)
        {
                Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    SelectedID = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                }
            }
            else { MessageBox.Show("Please select only one row for this operation"); }

            try { 
                string MyConnection2 = "Server=3.227.166.251; database=U053QS; UID=U053QS; password=53688416942";
                if (SelectedID != 0)
                {
                    string Query = $"DELETE FROM `U053QS`.`expenses` WHERE (`id` = {SelectedID});";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                    MessageBox.Show("Expense deleted");
                    
                    MyConn2.Close();
                }
                else
                {
                    MessageBox.Show("The data is in incorrect format");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectedRowsButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    sb.Append("Row: ");
                    sb.Append(dataGridView1.SelectedRows[i].Index.ToString());
                    sb.Append(Environment.NewLine);
                }

                sb.Append("Total: " + selectedRowCount.ToString());
                MessageBox.Show(sb.ToString(), "Selected Rows");
            }
        }
    }
}
