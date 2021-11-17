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
    public partial class FormSelectIssue : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        public int SelectedIssueId;

        public FormSelectIssue(AppUser appUser)
        {
            InitializeComponent();
            _currentAppUser = appUser;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _selectedProjectId = Int32.Parse(preferredProjectId);

            FakeIssueRepository issueRepository = new FakeIssueRepository();

            List<Issue> issues = issueRepository.GetAll();
            FakeIssueStatusRepository statusRepository = new FakeIssueStatusRepository();

            CurrentIssuesGrid.ColumnCount = 7;

            CurrentIssuesGrid.Columns[0].Name = "id";
            CurrentIssuesGrid.Columns[0].Width = 30;
            CurrentIssuesGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            CurrentIssuesGrid.Columns[1].Name = "Title";
            CurrentIssuesGrid.Columns[1].Width = 150;
            CurrentIssuesGrid.Columns[2].Name = "Discovery Date";
            CurrentIssuesGrid.Columns[2].Width = 130;
            CurrentIssuesGrid.Columns[3].Name = "Discoverer";
            CurrentIssuesGrid.Columns[4].Name = "Initial Description";
            CurrentIssuesGrid.Columns[5].Name = "Component";
            CurrentIssuesGrid.Columns[6].Name = "Status";

            foreach (Issue i in issues)
            {
                if (_selectedProjectId == i.ProjectId)
                {
                    string[] row = { i.Id.ToString(), i.Title, i.DiscoveryDate.ToString("yyyy/mm/dd hh:mm"), i.Discoverer, i.InitialDescription, i.Component, statusRepository.GetValueById(i.IssueStatusId) };
                    CurrentIssuesGrid.Rows.Add(row);
                }
            }
        }

        private void CancelIssueSelectionButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SelectIssueButton_Click(object sender, EventArgs e)
        {
            SelectedIssueId = CurrentIssuesGrid.SelectedRows[0].Index;
            this.DialogResult = DialogResult.OK;
        }
    }
}
