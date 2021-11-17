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
    public partial class FormRemoveIssue : Form
    {
        public int _selectedId;
        public FormRemoveIssue(int selectedId)
        {
            InitializeComponent();
            _selectedId = selectedId;
        }

        private void FormRemoveIssue_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            List<Issue> issues = issueRepository.GetAll();

            foreach (Issue i in issues)
                if (i.Id == _selectedId)
                    issues.Remove(i);
        }

        private void RemoveIssueCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
