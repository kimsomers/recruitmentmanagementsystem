using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;
using System.IO;

namespace RecruitmentManagementSystem
{
    public partial class AddCandidate : Form
    {
        public AddCandidate()
        {
            InitializeComponent();
        }

        private void btnCancelCandidate_Click(object sender, EventArgs e)
        {
            //Close the 'Add Candidate' form
            Close();
        }

        private void AddCandidate_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            //save data source link for the database in a string for easier use
            string oradb = "DATA SOURCE = larry.uopnet.plymouth.ac.uk:1521/orcl.fost.plymouth.ac.uk;PERSIST SECURITY INFO = True;USER ID = KIMSOMERS;password = ksPlymouth123!";
            string insertquery = "Insert into Candidate VALUES (:1, :2, :3, :4, :5, :6, :7, :8, :9, :10, :11, :12, :13)";
            string filePath = txtBoxCandidateCV.Text;


            //Set up Oracle Connection via the Connection String
            //Open Oracle Connection to execute the SQL command
            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = insertquery;
        
            try
            {
                //check if Candidate CV textbox is empty to skip the file reader task
                if (string.IsNullOrEmpty(filePath))
                {
                    //add parameters for binding the variables
                    //source for code http://stackoverflow.com/questions/43106359/how-to-insert-text-box-values-from-c-sharp-into-oracle-database
                    cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Decimal, ParameterDirection.ReturnValue));
                    cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, txtBoxCandidateName.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, txtBoxCandidateJobTitle.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, txtBoxCandidateCompany.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, txtBoxCandidateCity.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("6", OracleDbType.Varchar2, txtBoxCandidateCountry.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("7", OracleDbType.Varchar2, txtBoxCandidateEmail.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("8", OracleDbType.Varchar2, txtBoxCandidateNumber.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("9", OracleDbType.Varchar2, txtBoxCandidateURL.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("10", OracleDbType.Varchar2, comboCandidateStatus.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("11", OracleDbType.Blob, null, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("12", OracleDbType.Varchar2, txtBoxCandidateNotes.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("13", OracleDbType.Varchar2, "No", ParameterDirection.Input));

                    cmd.ExecuteNonQuery();

                    //Pop up notification message box based on entered data
                    MessageBox.Show("Candidate has been added");
                    con.Close();
                    Close();
                }
                else
                {
                    //convert file into binary information to be stored into the database
                    // declare and initialize FileStream object
                    //source for code https://codistic.wordpress.com/2009/01/02/how-to-store-word-documents-in-database-using-c/
                    FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    // declare and initialize BinaryReader object
                    BinaryReader reader = new BinaryReader(stream);
                    //Read bytes from  the file
                    byte[] file = reader.ReadBytes((int)stream.Length);
                    //close reader
                    reader.Close();
                    stream.Close();

                    //add parameters for binding the variables
                    //source for code http://stackoverflow.com/questions/43106359/how-to-insert-text-box-values-from-c-sharp-into-oracle-database
                    cmd.Parameters.Add(new OracleParameter("1", OracleDbType.Decimal, ParameterDirection.ReturnValue));
                    cmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, txtBoxCandidateName.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, txtBoxCandidateJobTitle.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("4", OracleDbType.Varchar2, txtBoxCandidateCompany.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("5", OracleDbType.Varchar2, txtBoxCandidateCity.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("6", OracleDbType.Varchar2, txtBoxCandidateCountry.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("7", OracleDbType.Varchar2, txtBoxCandidateEmail.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("8", OracleDbType.Varchar2, txtBoxCandidateNumber.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("9", OracleDbType.Varchar2, txtBoxCandidateURL.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("10", OracleDbType.Varchar2, comboCandidateStatus.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("11", OracleDbType.Blob, file, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("12", OracleDbType.Varchar2, txtBoxCandidateNotes.Text, ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("13", OracleDbType.Varchar2, "Yes", ParameterDirection.Input));

                    cmd.ExecuteNonQuery();

                    //Pop up notification message box based on entered data
                    MessageBox.Show("Candidate has been added");
                    con.Close();
                    Close();
                }


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

        private void txtBoxCandidateCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCandidateCV_Click(object sender, EventArgs e)
        {
            //Allow user to only see PDF and Word files in the open file prompt
            OpenFileDialog OpenCV = new OpenFileDialog();
            OpenCV.Filter = "PDF files|*.pdf|Office Files|*.doc;*.docx;";
            //convert filepath into string and to be stored in the textbox
            if (OpenCV.ShowDialog() == DialogResult.OK)
            {
                string filePath = OpenCV.FileName.ToString();
                txtBoxCandidateCV.Text = filePath;
            }
            else MessageBox.Show("No file selected");
        }
    }
}
