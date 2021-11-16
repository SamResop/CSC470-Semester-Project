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
    public partial class FormDashboard : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        public FormDashboard(AppUser appUser)
        {
            InitializeComponent();
            _currentAppUser = appUser;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            FakeIssueRepository issueRepository = new FakeIssueRepository();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _selectedProjectId = Int32.Parse(preferredProjectId);

            int issuesCount = issueRepository.GetTotalNumberOfIssues(_selectedProjectId);
            IssueNumLabel.Text = "Total Number of Issues:    " + issuesCount;

            List<string> MonthlyIssues = issueRepository.GetIssuesByMonth(_selectedProjectId);
            foreach (string s in MonthlyIssues)
                IssueMonthListBox.Items.Add(s);

            List<string> DiscovererIssues = issueRepository.GetIssuesByDiscoverer(_selectedProjectId);
            foreach (string s in DiscovererIssues)
                IssueDiscovererListBox.Items.Add(s);
        }
    }
}
