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
    public partial class FormModifyRequirement : Form
    {
        int requirementId, projectId;
        string feature;
        AppUser currentUser;

        public FormModifyRequirement(int SelectedId, string selectedFeature, AppUser appUser)
        {
            InitializeComponent();
            currentUser = appUser;
            requirementId = SelectedId;
            feature = selectedFeature;
        }

        private void FormModifyRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(currentUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            projectId = Int32.Parse(preferredProjectId);

            FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
            List<Requirement> requirements = requirementRepository.GetAll(projectId);

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            Feature chosenFeature = featureRepository.GetFeatureByTitle(projectId, feature);
            List<Feature> features = featureRepository.GetAll(projectId);

            foreach (Feature f in features)
            {
                FeatureDropDown.Items.Add(f.Title);
                if (f.Title == feature)
                    FeatureDropDown.SelectedItem = feature;
            }

            foreach (Requirement r in requirements)
                if (r.Id == requirementId)
                    StatementTextBox.Text = r.Statement;

        }

        private void RequirementAccept_Click(object sender, EventArgs e)
        {
            Requirement requirement = new Requirement();

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            FakeRequirementRepository requirementRepository = new FakeRequirementRepository();

            requirement.FeatureId = featureRepository.GetFeatureByTitle(projectId, FeatureDropDown.SelectedItem.ToString()).Id;
            requirement.Id = requirementId;
            requirement.Statement = StatementTextBox.Text.Trim();
            requirement.ProjectId = projectId;

            string result = requirementRepository.Modify(requirement);
            if (result == "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show(result, "Error");
        }
    }
}
