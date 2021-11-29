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
    public partial class FormSelectFeature : Form
    {
        AppUser _currentAppUser;
        int _selectedProjectId;

        public int SelectedFeatureId;

        public FormSelectFeature(AppUser appuser)
        {
            InitializeComponent();
            _currentAppUser = appuser;
        }

        private void FormSelectFeature_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            string preferredProjectId = preferenceRepository.GetPreference(_currentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID);
            _selectedProjectId = Int32.Parse(preferredProjectId);

            FeatureDataGrid.ColumnCount = 2;

            FeatureDataGrid.Columns[0].Name = "Id";
            FeatureDataGrid.Columns[1].Name = "Feature";
            FeatureDataGrid.Columns[1].Width = 150;

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(_selectedProjectId);

            foreach (Feature f in features)
            {
                if (_selectedProjectId == f.ProjectId)
                {
                    string[] row = { f.Id.ToString(), f.Title };
                    FeatureDataGrid.Rows.Add(row);
                }
            }
        }

        private void FeatureCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FeatureSelect_Click(object sender, EventArgs e)
        {
            int index = FeatureDataGrid.SelectedRows[0].Index;

            SelectedFeatureId = Convert.ToInt32(FeatureDataGrid.Rows[index].Cells[0].Value);

            FormModifyFeature form = new FormModifyFeature(SelectedFeatureId, _currentAppUser);
            form.ShowDialog();

            form.Dispose();
            this.DialogResult = DialogResult.OK;
        }
    }
}
