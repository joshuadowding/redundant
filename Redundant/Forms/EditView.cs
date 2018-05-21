using Redundant.Models;

using System;
using System.Windows.Forms;

namespace Redundant.Forms {
    public partial class EditView : Form {
        private const string CANCEL_WARNING = "Are you sure you'd like to finish editing?";
        private const string CANCEL_HEADING = "Cancel";
        private const string INPUT_WARNING = "Please complete all mandatory fields.";

        private JobModel selectedModel;

        public EditView() {
            InitializeComponent();
            selectedModel = new JobModel();
            selectedModel.Created = DateTime.Now;
            selectedModel.ID = 0;
        }

        public EditView(JobModel model) {
            InitializeComponent();
            selectedModel = model;
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Awake(object sender, EventArgs args) {
            this.ActiveControl = this.positionInput;

            this.statusInput.Items.Add(JobStatus.Active);
            this.statusInput.Items.Add(JobStatus.Hold);
            this.statusInput.Items.Add(JobStatus.Rejected);
            this.statusInput.SelectedItem = this.statusInput.Items[0];
            this.idLabel.Text = App.GenerateID().ToString();

            //Populate fields with selected model data if present:
            if(selectedModel.ID != 0) {
                this.positionInput.Text = selectedModel.Position;
                this.companyInput.Text = selectedModel.Company;
                this.agencyInput.Text = selectedModel.Agency;
                this.locationInput.Text = selectedModel.Location;
                this.callsInput.Value = selectedModel.Calls;
                this.meetingsInput.Value = selectedModel.Interviews;
                this.testsInput.Value = selectedModel.Tests;
                this.statusInput.SelectedItem = selectedModel.Status;
                this.expiryInput.Value = selectedModel.Expiry;
                this.linkInput.Text = selectedModel.Link;
                this.notesInput.Text = selectedModel.Notes;
                this.idLabel.Text = selectedModel.ID.ToString();
                this.defaultExpiryInput.Checked = selectedModel.DefaultExpiry;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Confirm(object sender, EventArgs args) {
            if (String.IsNullOrWhiteSpace(this.positionInput.Text) ||
                String.IsNullOrWhiteSpace(this.companyInput.Text) ||
                String.IsNullOrWhiteSpace(this.locationInput.Text)) {
                MessageBox.Show(INPUT_WARNING);
                selectedModel = null;
                return;
            }

            selectedModel.ID = Convert.ToInt32(this.idLabel.Text);
            selectedModel.Status = (JobStatus)Enum.Parse(typeof(JobStatus), this.statusInput.Text);
            selectedModel.Position = this.positionInput.Text;
            selectedModel.Company = this.companyInput.Text;
            selectedModel.Agency = this.agencyInput.Text;
            selectedModel.Location = this.locationInput.Text;
            selectedModel.Calls = (int)this.callsInput.Value;
            selectedModel.Interviews = (int)this.meetingsInput.Value;
            selectedModel.Tests = (int)this.testsInput.Value;
            selectedModel.Link = this.linkInput.Text;
            selectedModel.Notes = this.notesInput.Text;
            selectedModel.Updated = DateTime.Now;
            selectedModel.Expiry = this.expiryInput.Value;

            bool found = false;
            for(int index = 0; index < App.Local.Jobs.Count; index++) {
                if(App.Local.Jobs[index].ID == selectedModel.ID) {
                    found = true;
                }
            }

            if(found) {
                App.Local.Jobs[App.Local.Jobs.IndexOf(selectedModel)] = selectedModel;
            }
            else {
                App.Local.Jobs.Add(selectedModel);
            }

            this.Close();
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void Cancel(object sender, EventArgs args) {
            DialogResult result = MessageBox.Show(CANCEL_WARNING, CANCEL_HEADING, MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void DefaultExpiryChecked(object sender, EventArgs args) {
            if(this.defaultExpiryInput.Checked) {
                DateTime advanceTime = DateTime.Now.AddDays(21);
                this.expiryInput.Value = advanceTime;
                this.expiryInput.Enabled = false;
                selectedModel.DefaultExpiry = true;
            }
            else {
                //Reset:
                this.expiryInput.Value = DateTime.Now;
                this.expiryInput.Enabled = true;
                selectedModel.DefaultExpiry = false;
            }
        }
    }
}
