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
using Oracle.DataAccess.Types;

namespace RecruitmentManagementSystem
{
    public partial class Search : Form
    {
        string oradb = "DATA SOURCE = larry.uopnet.plymouth.ac.uk:1521/orcl.fost.plymouth.ac.uk;PERSIST SECURITY INFO = True;USER ID = KIMSOMERS;password = ksPlymouth123!";
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            //carry textbox input data from the main menu form over to the search form
            txtBoxSearchData.Text = MainHub.searchText;
            //set combobox value in Search form to "Candidate" on form start up
            comboSearchFilter.SelectedIndex = 0;

            string selectcandidatequery = "select CandidateID, CandidateName, CandidateJobTitle, CandidateCompany, CandidateCity, CandidateCountry, CandidateEmail, CandidateNumber, CandidateURL, CandidateStatus, CandidateNotes, CandidateCVAdded from Candidate where CandidateName like '" + txtBoxSearchData.Text + "'";

            dgvSearchCandidate.Show();
            dgvSearchClient.Hide();
            dgvSearchContact.Hide();
            dgvSearchJob.Hide();

            OracleConnection con = new OracleConnection(oradb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = selectcandidatequery;
            cmd.CommandType = CommandType.Text;

            OracleDataAdapter orada = new OracleDataAdapter(selectcandidatequery, con);

            //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

            DataSetSearch dataSet = new DataSetSearch();
            orada.Fill(dataSet, "Candidate");
            dgvSearchCandidate.DataSource = dataSet.Tables["Candidate"];

            con.Close();
        }

        private void btnSearchClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxSearchData_TextChanged(object sender, EventArgs e)
        {
            string selectcandidatequery = "select CandidateID, CandidateName, CandidateJobTitle, CandidateCompany, CandidateCity, CandidateCountry, CandidateEmail, CandidateNumber, CandidateURL, CandidateStatus, CandidateNotes, CandidateCVAdded from Candidate where CandidateName like '" + txtBoxSearchData.Text + "'";
            string selectclientquery = "select * from Client where ClientName like '" + txtBoxSearchData.Text + "'";
            string selectcontactquery = "select * from Contact where ContactName like '" + txtBoxSearchData.Text + "'";
            string selectjobquery = "select * from Job where JobTitle like '" + txtBoxSearchData.Text + "'";
            //Set up Oracle Connection via the Connection String
            //Open Oracle Connection to execute the SQL command
            OracleConnection con = new OracleConnection(oradb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            try
            {
                //create if statement to search the different tables depending on the selected combobox value
                if (comboSearchFilter.Text == "Candidate")
                {
                    dgvSearchCandidate.Show();
                    dgvSearchClient.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Hide();
                
                    cmd.CommandText = selectcandidatequery;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectcandidatequery, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Candidate");
                    dgvSearchCandidate.DataSource = dataSet.Tables["Candidate"];
                }
                if (comboSearchFilter.Text == "Client")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Hide();
                    dgvSearchClient.Show();
                    
                    cmd.CommandText = selectclientquery;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectclientquery, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Client");
                    dgvSearchClient.DataSource = dataSet.Tables["Client"];
                }
                if (comboSearchFilter.Text == "Contact")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchClient.Hide();
                    dgvSearchJob.Hide();
                    dgvSearchContact.Show();

                    cmd.CommandText = selectcontactquery;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectcontactquery, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Contact");
                    dgvSearchContact.DataSource = dataSet.Tables["Contact"];
                }
                if (comboSearchFilter.Text == "Job")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchClient.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Show();

                    cmd.CommandText = selectjobquery;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectjobquery, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Job");
                    dgvSearchJob.DataSource = dataSet.Tables["Job"];
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (OracleException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Dispose();
            }
        }

        private void btnSearchShowAll_Click(object sender, EventArgs e)
        {
            string selectallcandidate = "SELECT CandidateID, CandidateName, CandidateJobTitle, CandidateCompany, CandidateCity, CandidateCountry, CandidateEmail, CandidateNumber, CandidateURL, CandidateStatus, CandidateNotes, CandidateCVAdded FROM Candidate";
            string selectallclient = "SELECT * FROM Client";
            string selectallcontact = "SELECT * FROM Contact";
            string selectalljob = "SELECT * FROM Job";

            OracleConnection con = new OracleConnection(oradb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            try
            {
                //create if statement to search the different tables depending on the selected combobox value
                if (comboSearchFilter.Text == "Candidate")
                {
                    dgvSearchCandidate.Show();
                    dgvSearchClient.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Hide();

                    cmd.CommandText = selectallcandidate;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectallcandidate, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Candidate");
                    dgvSearchCandidate.DataSource = dataSet.Tables["Candidate"];
                }
                if (comboSearchFilter.Text == "Client")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Hide();
                    dgvSearchClient.Show();

                    cmd.CommandText = selectallclient;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectallclient, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Client");
                    dgvSearchClient.DataSource = dataSet.Tables["Client"];
                }
                if (comboSearchFilter.Text == "Contact")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchClient.Hide();
                    dgvSearchJob.Hide();
                    dgvSearchContact.Show();

                    cmd.CommandText = selectallcontact;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectallcontact, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Contact");
                    dgvSearchContact.DataSource = dataSet.Tables["Contact"];
                }
                if (comboSearchFilter.Text == "Job")
                {
                    dgvSearchCandidate.Hide();
                    dgvSearchClient.Hide();
                    dgvSearchContact.Hide();
                    dgvSearchJob.Show();

                    cmd.CommandText = selectalljob;
                    cmd.CommandType = CommandType.Text;

                    OracleDataAdapter orada = new OracleDataAdapter(selectalljob, con);

                    //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral

                    DataSetSearch dataSet = new DataSetSearch();
                    orada.Fill(dataSet, "Job");
                    dgvSearchJob.DataSource = dataSet.Tables["Job"];
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (OracleException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Dispose();
            }
        }

        private void dgvSearchCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSearchCandidate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btnSearchRemove_Click(object sender, EventArgs e)
        {
            //create an int to store the ID of the data row to use in the Delete query
            int id = 0;

            OracleConnection con = new OracleConnection(oradb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            try
            {
                //prompt user with warning message before deleting data row
                if (MessageBox.Show("Are you sure you want to delete this record", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    //code found at http://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                    if (comboSearchFilter.Text == "Candidate")
                        foreach (DataGridViewCell selectedCell in dgvSearchCandidate.SelectedCells)
                        {
                            if (selectedCell.Selected)
                                //code found at http://stackoverflow.com/questions/34704959/c-sharp-how-to-get-the-selected-column-id-value-from-datagridview
                                //take the ID of the data entry and store it in the declared int
                                id = Convert.ToInt32(dgvSearchCandidate.CurrentRow.Cells[0].Value);
                                dgvSearchCandidate.Rows.RemoveAt(selectedCell.RowIndex);
                                
                                cmd.CommandText = "DELETE FROM Candidate WHERE CandidateID like '" + id + "'";
                                cmd.CommandType = CommandType.Text;

                                cmd.ExecuteNonQuery();
                        }
                    if (comboSearchFilter.Text == "Client")
                        foreach (DataGridViewCell selectedCell in dgvSearchClient.SelectedCells)
                        {
                            if (selectedCell.Selected)
                                id = Convert.ToInt32(dgvSearchClient.CurrentRow.Cells[0].Value);
                                dgvSearchClient.Rows.RemoveAt(selectedCell.RowIndex);

                                cmd.CommandText = "DELETE FROM Client WHERE ClientID like '" + id + "'";
                                cmd.CommandType = CommandType.Text;

                                cmd.ExecuteNonQuery();
                        }
                    if (comboSearchFilter.Text == "Contact")
                        foreach (DataGridViewCell selectedCell in dgvSearchContact.SelectedCells)
                        {
                            if (selectedCell.Selected)
                                id = Convert.ToInt32(dgvSearchContact.CurrentRow.Cells[0].Value);
                                dgvSearchContact.Rows.RemoveAt(selectedCell.RowIndex);

                                cmd.CommandText = "DELETE FROM Contact WHERE ContactID like '" + id + "'";
                                cmd.CommandType = CommandType.Text;

                                cmd.ExecuteNonQuery();
                        }
                    if (comboSearchFilter.Text == "Job")
                        foreach (DataGridViewCell selectedCell in dgvSearchJob.SelectedCells)
                        {
                            if (selectedCell.Selected)
                                id = Convert.ToInt32(dgvSearchJob.CurrentRow.Cells[0].Value);
                                dgvSearchJob.Rows.RemoveAt(selectedCell.RowIndex);

                                cmd.CommandText = "DELETE FROM Job WHERE JobID like '" + id + "'";
                                cmd.CommandType = CommandType.Text;

                                cmd.ExecuteNonQuery();
                        }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (OracleException ex1)
            {
                MessageBox.Show("Error: " + ex1.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Dispose();
            }           
        }
    }
}
