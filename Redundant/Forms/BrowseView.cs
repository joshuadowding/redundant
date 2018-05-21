using Redundant.Forms.Dialogs;
using Redundant.Models;

using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Redundant.Forms {

    public partial class BrowseView : Form {
        private const string EXPIRY_WARNING = " has expired. Changing it's status to 'Rejected'.";

        private ObservableCollection<JobModel> currentJobs;

        public BrowseView() {
            InitializeComponent();
        }

        public void Open(object sender, EventArgs args) {
            currentJobs = App.Local.Jobs;
            currentJobs.CollectionChanged += Refresh;
            this.filterAll.Checked = true;
        }

        public void Refresh(object sender, EventArgs args) {
            foreach(ListViewItem item in this.viewList.Items) {
                this.viewList.Items.Remove(item);
            }

            DateTime currentDate = DateTime.Now;
            foreach(JobModel job in currentJobs) {
                if(job.Expiry.Date == currentDate.Date) {
                    MessageBox.Show(job.Position + EXPIRY_WARNING);
                    job.Status = JobStatus.Rejected;
                }

                ListViewItem item = new ListViewItem(new string[] {
                    job.Status.ToString(),
                    job.Position,
                    job.Company,
                    job.Agency,
                    job.Location,
                    job.Interviews.ToString(),
                    job.Tests.ToString()
                });

                item.Tag = job.ID;
                this.viewList.Items.Add(item);
            }
        }

        public void About(object sender, EventArgs args) {
            AboutDialog about = new AboutDialog();
            about.ShowDialog(this);
        }

        public void Exit(object sender, EventArgs args) {
            Close();
        }
         
        public void Add(object sender, EventArgs args) {
            EditView editView = new EditView();
            editView.ShowDialog(this);
        }

        public void Edit(object sender, EventArgs args) {
            if(this.viewList.SelectedItems.Count > 0) {
                int currentID = Convert.ToInt32(this.viewList.SelectedItems[0].Tag);
                JobModel selectedJob = new JobModel();
                for(int index = 0; index < currentJobs.Count; index++) {
                    if(currentJobs[index].ID == currentID) {
                        selectedJob = currentJobs[index];
                    }
                }
                
                EditView editView = new EditView(selectedJob);
                editView.ShowDialog(this);
            }
        }

        public void Remove(object sender, EventArgs args) {
            if(MessageBox.Show("Are you sure you'd like to remove this job?",
                "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if(this.viewList.SelectedItems.Count > 0) {
                    int currentID = Convert.ToInt32(this.viewList.SelectedItems[0].Tag);
                    for(int index = 0; index < currentJobs.Count; index++) {
                        if(currentJobs[index].ID == currentID) {
                            currentJobs.Remove(currentJobs[index]);
                        }
                    }
                }
            }
        }

        public void Serialize(object sender, EventArgs args) {
            saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = @"C:\Users\joshd\Desktop";
            saveDialog.Filter = "json files (*.json)|*.json";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if(saveDialog.ShowDialog() == DialogResult.OK) {
                App.Save(saveDialog.FileName);
            }
        }

        public void Deserialize(object sender, EventArgs args) {
            openDialog = new OpenFileDialog();
            openDialog.InitialDirectory = @"C:\Users\joshd\Desktop";
            openDialog.Filter = "json files (*.json)|*.json";
            openDialog.FilterIndex = 1;
            openDialog.RestoreDirectory = true;

            if(openDialog.ShowDialog() == DialogResult.OK) {
                App.Load(openDialog.FileName);
            }

            currentJobs = new ObservableCollection<JobModel>();
            currentJobs.CollectionChanged += Refresh;

            foreach(JobModel job in App.Local.Jobs) {
                currentJobs.Add(job);
            }
        }

        public void Filter(JobStatus status) {
            foreach(ToolStripMenuItem item in filterStatus.DropDownItems) {
                if(item.Text == status.ToString()) {
                    item.Checked = true;
                }
                else {
                    item.Checked = false;
                }
            }

            //Reset:
            currentJobs = new ObservableCollection<JobModel>();
            currentJobs.CollectionChanged += Refresh;

            foreach(JobModel job in App.Local.Jobs) {
                if(job.Status == status || status == JobStatus.All) {
                    currentJobs.Add(job);
                }
            }
        }

        public void FilterToggle_OnClick(object sender, EventArgs args) {
            string toggle = (sender as ToolStripMenuItem).Text;
            if(toggle == JobStatus.All.ToString()) {
                Filter(JobStatus.All);
            }
            else if(toggle == JobStatus.Accepted.ToString()) {
                Filter(JobStatus.Accepted);
            }
            else if(toggle == JobStatus.Active.ToString()) {
                Filter(JobStatus.Active);
            }
            else if(toggle == JobStatus.Hold.ToString()) {
                Filter(JobStatus.Hold);
            }
            else if(toggle == JobStatus.Rejected.ToString()) {
                Filter(JobStatus.Rejected);
            }
        }
    }
}
