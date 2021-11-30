using System.Windows.Forms;
using System;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();

        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormDashboard form = new FormDashboard(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRecordIssue form = new FormRecordIssue(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();

            int selectedId = form.SelectedIssueId;

            if (form.DialogResult == DialogResult.OK)
            {
                //Modify form
                FormModifyIssue modifyForm = new FormModifyIssue(selectedId);
            }

            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser);
            form.ShowDialog();

            int selectedId = form.SelectedIssueId;

            if (form.DialogResult == DialogResult.OK)
            {
                //Remove form
                FormRemoveProject removeForm = new FormRemoveProject(_CurrentAppUser);
            }

            form.Dispose();
        }

        private void createToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormCreateFeature form = new FormCreateFeature(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void modifyToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                FormModifyFeature form2 = new FormModifyFeature(FormSelectFeature.SelectedFeatureId, _CurrentAppUser);
                form2.ShowDialog();

                form2.Dispose();
            }

            form.Dispose();
        }

        private void removeToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            FormSelectFeature form = new FormSelectFeature(_CurrentAppUser);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
                int projectId = Int32.Parse(preferredProjectId);


                int id = FormSelectFeature.SelectedFeatureId;
                FakeFeatureRepository featureRepository = new FakeFeatureRepository();

                Feature feature = featureRepository.GetFeatureById(projectId, id);

                var confirmation = MessageBox.Show("Are you sure you want to remove: " + feature.Title, "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    string result = featureRepository.Remove(feature);
                }
            }

            form.Dispose();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateRequirement form = new FormCreateRequirement(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectRequirement form = new FormSelectRequirement(_CurrentAppUser);
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                FormModifyRequirement form2 = new FormModifyRequirement(FormSelectRequirement.SelectedRequirementId, FormSelectRequirement.SelectedFeature,_CurrentAppUser);
                form2.ShowDialog();

                form2.Dispose();
            }

            form.Dispose();
        }
    }
}
