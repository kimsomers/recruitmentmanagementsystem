using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace RecruitmentManagementSystem
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClientSave_Click(object sender, EventArgs e)
        {
            //save data source link for the database in a string for easier use
            string oradb = "DATA SOURCE = larry.uopnet.plymouth.ac.uk:1521/orcl.fost.plymouth.ac.uk;PERSIST SECURITY INFO = True;USER ID = KIMSOMERS;password = ksPlymouth123!";
            string insertquery = "Insert into Client VALUES (:1, :2, :3, :4, :5, :6, :7)";
            
            //Set up Oracle Connection via the Connection String
            //Open Oracle Connection to execute the SQL command
            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = insertquery;
            try
            {
                //add parameters for binding the variables
                //source for code http://stackoverflow.com/questions/43106359/how-to-insert-text-box-values-from-c-sharp-into-oracle-database
                cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Decimal, ParameterDirection.ReturnValue));
                cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, txtBoxClientName.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, txtBoxClientCity.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, txtBoxClientCountry.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, txtBoxClientNumber.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("6", OracleDbType.Varchar2, txtBoxClientURL.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("7", OracleDbType.Varchar2, comboClientStatus.Text, ParameterDirection.Input));
                                
                cmd.ExecuteNonQuery();

                //Pop up notification message box based on entered data
                MessageBox.Show("Client has been added");
                con.Close();
                Close();
            }
            catch (OracleException e1)
            {
                MessageBox.Show("Error: " + e1.Message);
            }
            catch (ArgumentException e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
            finally
            {                
                cmd.Dispose();
                con.Dispose();
            }
            
        }
    }
}
