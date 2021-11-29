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
    public partial class FormCreateFeature : Form
    {
        AppUser _CurrentAppUser;
        int _SelectedProjectId;

        public FormCreateFeature(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void FormCreateFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();  
        }

        private void FeatureCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FeatureCreateButton_Click(object sender, EventArgs e)
        {
            FakeFeatureRepository featureRepository = new FakeFeatureRepository();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _SelectedProjectId = Int32.Parse(preferredProjectId);

            Feature feature = new Feature();
            feature.Title = FeatureTitleTextbox.Text.Trim();
            feature.Id = featureRepository.GetNextId(_SelectedProjectId);
            feature.ProjectId = _SelectedProjectId;

            string result = featureRepository.Add(feature);
            if (result != "")
                MessageBox.Show(result, "Error");
            this.Close();
        }
    }
}
