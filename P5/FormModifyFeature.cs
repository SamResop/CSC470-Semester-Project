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
    public partial class FormModifyFeature : Form
    {
        int selectedFeatureId;
        int projectId;
        AppUser user;

        public static string newTitle;

        public FormModifyFeature(int selectedId, AppUser app)
        {
            InitializeComponent();
            selectedFeatureId = selectedId;
            user = app;
        }

        private void FormModifyFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(user.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            projectId = Int32.Parse(preferredProjectId);
        }

        private void FeatureModifyCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FeatureModifyAccept_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();

            Feature feature = featureRepository.GetFeatureById(projectId, selectedFeatureId);

            newTitle = FeatureModifyTextbox.Text.Trim();

            string result = featureRepository.Modify(feature);

            if (result != "")
            {
                MessageBox.Show(result, "Error");
                this.DialogResult = DialogResult.Cancel;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
