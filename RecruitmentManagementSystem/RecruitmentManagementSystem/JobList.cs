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
    public partial class JobList : Form
    {
        string oradb = "DATA SOURCE = larry.uopnet.plymouth.ac.uk:1521/orcl.fost.plymouth.ac.uk;PERSIST SECURITY INFO = True;USER ID = KIMSOMERS;password = ksPlymouth123!";
        public JobList()
        {
            InitializeComponent();
        }

        private void JobList_Load(object sender, EventArgs e)
        {
            string selectjobquery = "select * from Job";
            //Set up Oracle Connection via the Connection String
            //Open Oracle Connection to execute the SQL command
            OracleConnection con = new OracleConnection(oradb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;

            cmd.CommandText = selectjobquery;
            cmd.CommandType = CommandType.Text;

            try
            {
                //set up oracle data reader to display the table data
                //OracleDataReader oradr = cmd.ExecuteReader();
                //oradr.Read();
                OracleDataAdapter orada = new OracleDataAdapter(selectjobquery, con);

                //Source for code https://social.msdn.microsoft.com/Forums/en-US/07c74036-6448-4fbd-a8c1-98846a1b8a61/filling-datagridview-from-dataset-table?forum=csharpgeneral
                //DataTable dataTable = new DataTable("Job");
                //dataTable.Load(oradr);
                DataSetSearch dataSet = new DataSetSearch();
                //dataSet.Tables.Add(dataTable);
                orada.Fill(dataSet, "Job");
                dgvJobList.DataSource = dataSet.Tables["Job"];
                
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

        private void btnJobListClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
