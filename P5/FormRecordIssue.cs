using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecordIssue : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        FakeIssueRepository issueRepository = new FakeIssueRepository();

        public FormRecordIssue(AppUser appUser)
        {
            InitializeComponent();
            _currentAppUser = appUser;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _selectedProjectId = Int32.Parse(preferredProjectId);

            List<Issue> issues = issueRepository.GetAll();
            int nextId = issues.Count + 1;
            RecordIdTextbox.Text = nextId.ToString();

            FakeAppUserRepository users = new FakeAppUserRepository();
            List<AppUser> appUsers = users.GetAll();

            foreach (AppUser a in appUsers)
                RecordDiscovererComboBox.Items.Add(a.FirstName + " " + a.LastName);

            FakeIssueStatusRepository statusRepository = new FakeIssueStatusRepository();
            List<IssueStatus> statuses = statusRepository.GetAll();

            foreach (IssueStatus s in statuses)
                RecordStatusComboBox.Items.Add(s.Value);

        }

        private void RecordCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void RecordCreateButton_Click(object sender, EventArgs e)
        {
            issueRepository = new FakeIssueRepository();

            string result;

            Issue issue = new Issue();
            issue.Title = RecordTitleTextbox.Text;
            issue.Id = Int32.Parse(RecordIdTextbox.Text);
            issue.InitialDescription = RecordDescriptionTextBox.Text;
            issue.Discoverer = RecordDiscovererComboBox.Text;
            issue.DiscoveryDate = RecordDatePicker.Value;
            issue.Component = RecordComponentTextbox.Text;

            string status = RecordStatusComboBox.Text;
            FakeIssueStatusRepository statusRepository = new FakeIssueStatusRepository();
            issue.IssueStatusId = statusRepository.GetIdByStatus(status);

            issue.ProjectId = _selectedProjectId;
            result = issueRepository.Add(issue);

            if (result != "")
                MessageBox.Show(result, "Error");

            else
            {
                MessageBox.Show("Issue recorded successfully");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
