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
    public partial class FormModifyIssue : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        FakeIssueRepository issueRepository = new FakeIssueRepository();

        public FormModifyIssue(int selectedIssueId)
        {
            InitializeComponent();
            _selectedProjectId = selectedIssueId;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();

//            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
//            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
//            _selectedProjectId = Int32.Parse(preferredProjectId);

            List<Issue> issues = issueRepository.GetAll();
            Issue selectedIssue = new Issue();

            foreach (Issue i in issues)
                if (i.Id == _selectedProjectId)
                    selectedIssue = i;

            ModifyIdTextbox.Text = selectedIssue.Id.ToString();

            FakeAppUserRepository users = new FakeAppUserRepository();
            List<AppUser> appUsers = users.GetAll();

            foreach (AppUser a in appUsers)
            {
                ModifyDiscovererComboBox.Items.Add(a.FirstName + " " + a.LastName);
                if (selectedIssue.Discoverer.Contains(a.FirstName) && selectedIssue.Discoverer.Contains(a.LastName))
                    ModifyDiscovererComboBox.SelectedItem = a.FirstName + " " + a.LastName;
            }

            FakeIssueStatusRepository statusRepository = new FakeIssueStatusRepository();
            List<IssueStatus> statuses = statusRepository.GetAll();

            foreach (IssueStatus s in statuses)
            {
                ModifyStatusComboBox.Items.Add(s.Value);
                if (selectedIssue.IssueStatusId == s.Id)
                    ModifyStatusComboBox.SelectedItem = s.Value;
            }

            ModifyTitleTextbox.Text = selectedIssue.Title;
            ModifyComponentTextbox.Text = selectedIssue.Component;
            ModifyDescriptionTextBox.Text = selectedIssue.InitialDescription;
            ModifyDatePicker.Value = selectedIssue.DiscoveryDate;

        }

        private void ModifyIssueButton_Click(object sender, EventArgs e)
        {
            issueRepository = new FakeIssueRepository();

            string result;

            Issue issue = new Issue();
            issue.Title = ModifyTitleTextbox.Text;
            issue.Id = Int32.Parse(ModifyIdTextbox.Text);
            issue.InitialDescription = ModifyDescriptionTextBox.Text;
            issue.Discoverer = ModifyDiscovererComboBox.Text;
            issue.DiscoveryDate = ModifyDatePicker.Value;
            issue.Component = ModifyComponentTextbox.Text;

            string status = ModifyStatusComboBox.Text;
            FakeIssueStatusRepository statusRepository = new FakeIssueStatusRepository();
            issue.IssueStatusId = statusRepository.GetIdByStatus(status);

            issue.ProjectId = _selectedProjectId;
            result = issueRepository.Add(issue);

            if (result != "")
                MessageBox.Show(result, "Error");

            else
            {
                MessageBox.Show("Issue modified successfully");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ModifyCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
