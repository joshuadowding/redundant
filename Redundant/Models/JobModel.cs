using System;

namespace Redundant.Models {
    public class JobModel {
        private JobStatus jobStatus;
        private string jobPosition;
        private string jobCompnay;
        private string jobAgency;
        private string jobLocation;
        private string jobLink;
        private string jobNotes;
        private int jobCalls;
        private int jobInterviews;
        private int jobTests;
        private int jobID;
        private bool defaultExpiry;
        private DateTime jobCreated;
        private DateTime jobUpdated;
        private DateTime jobFinalized;
        private DateTime jobExpired;

        public JobModel() {
            
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
            get { return jobCompnay; }
            set { jobCompnay = value; }
        }

        public string Agency {
            get { return jobAgency; }
            set { jobAgency = value; }
        }

        public string Location {
            get { return jobLocation; }
            set { jobLocation = value; }
        }

        public string Link {
            get { return jobLink; }
            set { jobLink = value; }
        }

        public string Notes {
            get { return jobNotes; }
            set { jobNotes = value; }
        }

        public int Calls {
            get { return jobCalls; }
            set { jobCalls = value; }
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

        public bool DefaultExpiry {
            get { return defaultExpiry; }
            set { defaultExpiry = value; }
        }

        public DateTime Created {
            get { return jobCreated; }
            set { jobCreated = value; }
        }

        public DateTime Updated {
            get { return jobUpdated; }
            set { jobUpdated = value; }
        }

        public DateTime Finalized {
            get { return jobFinalized; }
            set { jobFinalized = value; }
        }

        public DateTime Expiry {
            get { return jobExpired; }
            set { jobExpired = value; }
        }
    }

    public enum JobStatus {
        All = 0,
        Accepted = 1,
        Active = 2,
        Hold = 3,
        Rejected = 4
    }

    public enum JobTerm {
        Full = 0,      //Hours Required, Length Required.
        Part = 1,      //Hours Required, Length Required.
        Zero = 4,      //No Hours or Length Required.
        Freelance = 5, //No Hours or Length Required.
        Agency = 6     //No Hours or Length Required.
    }

    public enum JobLength {
        Fixed = 0,
        Temporary = 1,
        Permenent = 2
    }
}
