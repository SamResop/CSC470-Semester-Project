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
    public partial class FormCreateRequirement : Form
    {

        int projectId;
        AppUser user;

        public FormCreateRequirement(AppUser appUser)
        {
            InitializeComponent();
            user = appUser;
        }

        private void FormCreateRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            projectId = Int32.Parse(preferredProjectId);

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(projectId);

            foreach (Feature f in features)
            {
                FeatureSelectBox.Items.Add(f.Title);
            }
        }

        private void FeatureSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            if (FeatureSelectBox.Focused)     //Add later
            {
                StatementTextbox.Enabled = false;
                RequirementAcceptButton.Enabled = false;
            }*/
            
                StatementTextbox.Enabled = true;
                RequirementAcceptButton.Enabled = true;
        }

        private void RequirementAcceptButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            FakeRequirementRepository requirementRepository = new FakeRequirementRepository();

            Requirement requirement = new Requirement();
            requirement.ProjectId = projectId;
            requirement.FeatureId = featureRepository.GetFeatureByTitle(projectId, FeatureSelectBox.SelectedItem.ToString()).Id;
            requirement.Statement = StatementTextbox.Text.Trim();

            string result = requirementRepository.Add(requirement);
            if (result != "")
            {
                MessageBox.Show(result, "Error");
            }
            else
                this.DialogResult = DialogResult.OK;
        }
    }
}
