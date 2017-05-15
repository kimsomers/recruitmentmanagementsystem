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

namespace RecruitmentManagementSystem
{
    public partial class MainHub : Form
    {
        public static string searchText;
        public MainHub()
        {
            InitializeComponent();
        }

        private void MainHub_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit application
            Application.Exit();
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            //Create new instance of the 'Add Candidate' form
            AddCandidate AddCandidate = new AddCandidate();
            //Show the 'Add Candidate' form
            AddCandidate.Show();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //Create new instance of the 'Add Client' form
            AddClient AddClient = new AddClient();
            //Show the 'Add Client' form
            AddClient.Show();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            //Create new instance of the 'Add Contact' form
            AddContact AddContact = new AddContact();
            //Show the 'Add Contact' form
            AddContact.Show();
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            //Create new instance of the 'Add Job' form
            AddJob AddJob = new AddJob();
            //Show the 'Add Job' form
            AddJob.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchText = txtBoxSearch.Text;
            Search Search = new Search();
            Search.Show();
        }

        private void btnViewJobList_Click(object sender, EventArgs e)
        {
            JobList JobList = new JobList();
            JobList.Show();
        }
    }
}
