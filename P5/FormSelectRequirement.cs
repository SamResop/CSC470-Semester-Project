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
    public partial class FormSelectRequirement : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        public static int SelectedRequirementId;
        public static string SelectedFeature;

        public FormSelectRequirement(AppUser app)
        {
            InitializeComponent();
            _currentAppUser = app;
        }

        private void FormSelectRequirement_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _selectedProjectId = Int32.Parse(preferredProjectId);

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(_selectedProjectId);

            foreach (Feature f in features)
            {
                FeatureDropDown.Items.Add(f.Title);
            }
        }

        private void FeatureDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequirementDataGrid.Enabled = true;
            RequirementAccept.Enabled = true;

            RequirementDataGrid.Rows.Clear();

            RequirementDataGrid.ColumnCount = 2;
            RequirementDataGrid.Columns[0].Name = "Id";
            RequirementDataGrid.Columns[1].Name = "Requirement";
            RequirementDataGrid.Columns[1].Width = 150;

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(_selectedProjectId);

            int featureId = featureRepository.GetFeatureByTitle(_selectedProjectId, FeatureDropDown.SelectedItem.ToString()).Id;

            FakeRequirementRepository requirementRepository = new FakeRequirementRepository();
            List<Requirement> requirements = requirementRepository.GetAll(_selectedProjectId);

            foreach (Requirement r in requirements)
            {
                if (featureId == r.FeatureId)
                {
                    string[] row = { r.Id.ToString(), r.Statement };
                    RequirementDataGrid.Rows.Add(row);
                }

            }
        }

        private void RequirementAccept_Click(object sender, EventArgs e)
        {
            int index = RequirementDataGrid.SelectedRows[0].Index;

            SelectedRequirementId = Convert.ToInt32(RequirementDataGrid.Rows[index].Cells[0].Value);
            SelectedFeature = FeatureDropDown.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void RequirementCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
