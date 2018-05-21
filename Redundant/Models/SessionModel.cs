using System.Collections.ObjectModel;

namespace Redundant.Models {
    public class SessionModel {
        private ObservableCollection<JobModel> sessionJobs;

        public SessionModel() {
            sessionJobs = new ObservableCollection<JobModel>();
        }

        public SessionModel(ObservableCollection<JobModel> sessionJobs) {
            this.sessionJobs = sessionJobs;
        }

        public ObservableCollection<JobModel> Jobs {
            get { return sessionJobs; }
            set { sessionJobs = value; }
        }
    }
}
