namespace Redundant.Models {
    public class Job {
        private JobStatus jobStatus;
        private string jobPosition;
        private string jobCompany;
        private string jobAgency;
        private string jobLocation;
        private string jobURL;
        private string jobNotes;
        private int jobInterviews;
        private int jobTests;
        private int jobID;

        public Job()
        {

        }

        public JobStatus Status {
            get { return jobStatus; }
            set { jobStatus = value; }
        }

        public string Position {
            get { return jobPosition; }
            set { jobPosition = value; }
        }

        public string Company {
            get { return jobCompany; }
            set { jobCompany = value; }
        }

        public string Agency {
            get { return jobAgency; }
            set { jobAgency = value; }
        }

        public string Location {
            get { return jobLocation; }
            set { jobLocation = value; }
        }

        public string URL {
            get { return jobURL; }
            set { jobURL = value; }
        }

        public string Notes {
            get { return jobNotes; }
            set { jobNotes = value; }
        }

        public int Interviews {
            get { return jobInterviews; }
            set { jobInterviews = value; }
        }

        public int Tests {
            get { return jobTests; }
            set { jobTests = value; }
        }

        public int ID {
            get { return jobID; }
            set { jobID = value; }
        }
    }

    public enum JobStatus
    {
        All = 0,
        Active = 1,
        Reject = 2,
        None = 3
    } 
}
