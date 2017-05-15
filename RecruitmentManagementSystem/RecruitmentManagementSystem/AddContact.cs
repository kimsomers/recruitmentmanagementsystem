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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnContactCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnContactSave_Click(object sender, EventArgs e)
        {
            //save data source link for the database in a string for easier use
            string oradb = "DATA SOURCE = larry.uopnet.plymouth.ac.uk:1521/orcl.fost.plymouth.ac.uk;PERSIST SECURITY INFO = True;USER ID = KIMSOMERS;password = ksPlymouth123!";
            string insertquery = "Insert into Contact VALUES (:1, :2, :3, :4, :5, :6, :7, :8)";

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
                cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, txtBoxContactName.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, txtBoxContactJobTitle.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, txtBoxContactCompany.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, txtBoxContactCity.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("6", OracleDbType.Varchar2, txtBoxContactCountry.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("7", OracleDbType.Varchar2, txtBoxContactEmail.Text, ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("8", OracleDbType.Varchar2, txtBoxContactNumber.Text, ParameterDirection.Input));

                cmd.ExecuteNonQuery();

                //Pop up notification message box based on entered data
                MessageBox.Show("Contact has been added");
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
