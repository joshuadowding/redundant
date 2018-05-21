using System.Collections.ObjectModel;

namespace Redundant.Models {
    public class Session {
        private ObservableCollection<Job> sessionJobs;

        public Session() {
            sessionJobs = new ObservableCollection<Job>();
        }

        public Session(ObservableCollection<Job> sessionJobs) {
            this.sessionJobs = sessionJobs;
        }

        public ObservableCollection<Job> Jobs {
            get { return sessionJobs; }
            set { sessionJobs = value; }
        }
    }
}
