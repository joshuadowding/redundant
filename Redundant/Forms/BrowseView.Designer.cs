namespace Redundant.Forms {
    partial class BrowseView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseView));
            this.viewMenu = new System.Windows.Forms.MenuStrip();
            this.viewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.viewView = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSort = new System.Windows.Forms.ToolStripMenuItem();
            this.sortStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.statusAscending = new System.Windows.Forms.ToolStripMenuItem();
            this.statusDescending = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.filterAll = new System.Windows.Forms.ToolStripMenuItem();
            this.filterActive = new System.Windows.Forms.ToolStripMenuItem();
            this.filterHold = new System.Windows.Forms.ToolStripMenuItem();
            this.filterRejected = new System.Windows.Forms.ToolStripMenuItem();
            this.viewJobs = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatus = new System.Windows.Forms.StatusStrip();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.viewList = new System.Windows.Forms.ListView();
            this.listStatus = new System.Windows.Forms.ColumnHeader();
            this.listPosition = new System.Windows.Forms.ColumnHeader();
            this.listCompany = new System.Windows.Forms.ColumnHeader();
            this.listAgency = new System.Windows.Forms.ColumnHeader();
            this.listLocation = new System.Windows.Forms.ColumnHeader();
            this.listInterviews = new System.Windows.Forms.ColumnHeader();
            this.listTests = new System.Windows.Forms.ColumnHeader();
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSeparator = new System.Windows.Forms.PictureBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.viewMenu.SuspendLayout();
            this.viewPanel.SuspendLayout();
            this.listMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.SystemColors.Control;
            this.viewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewFile,
            this.viewView,
            this.filterToolStripMenuItem,
            this.viewJobs});
            this.viewMenu.Location = new System.Drawing.Point(0, 0);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.viewMenu.Size = new System.Drawing.Size(784, 24);
            this.viewMenu.TabIndex = 0;
            this.viewMenu.Text = "menuStrip1";
            // 
            // viewFile
            // 
            this.viewFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileLoad,
            this.fileSave,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.toolStripSeparator2,
            this.fileClose});
            this.viewFile.Name = "viewFile";
            this.viewFile.Size = new System.Drawing.Size(37, 20);
            this.viewFile.Text = "File";
            // 
            // fileLoad
            // 
            this.fileLoad.Name = "fileLoad";
            this.fileLoad.Size = new System.Drawing.Size(207, 22);
            this.fileLoad.Text = "Load List";
            this.fileLoad.Click += new System.EventHandler(this.Deserialize);
            // 
            // fileSave
            // 
            this.fileSave.Name = "fileSave";
            this.fileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fileSave.Size = new System.Drawing.Size(207, 22);
            this.fileSave.Text = "Save List";
            this.fileSave.Click += new System.EventHandler(this.SerialiseAuto);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.toolStripMenuItem1.Text = "Save List As";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Serialize);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.About);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // fileClose
            // 
            this.fileClose.Name = "fileClose";
            this.fileClose.Size = new System.Drawing.Size(207, 22);
            this.fileClose.Text = "Close";
            this.fileClose.Click += new System.EventHandler(this.Exit);
            // 
            // viewView
            // 
            this.viewView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSort});
            this.viewView.Name = "viewView";
            this.viewView.Size = new System.Drawing.Size(44, 20);
            this.viewView.Text = "View";
            // 
            // viewSort
            // 
            this.viewSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortStatus});
            this.viewSort.Name = "viewSort";
            this.viewSort.Size = new System.Drawing.Size(95, 22);
            this.viewSort.Text = "Sort";
            // 
            // sortStatus
            // 
            this.sortStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusAscending,
            this.statusDescending});
            this.sortStatus.Name = "sortStatus";
            this.sortStatus.Size = new System.Drawing.Size(106, 22);
            this.sortStatus.Text = "Status";
            // 
            // statusAscending
            // 
            this.statusAscending.Name = "statusAscending";
            this.statusAscending.Size = new System.Drawing.Size(136, 22);
            this.statusAscending.Text = "Ascending";
            // 
            // statusDescending
            // 
            this.statusDescending.Name = "statusDescending";
            this.statusDescending.Size = new System.Drawing.Size(136, 22);
            this.statusDescending.Text = "Descending";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterStatus});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // filterStatus
            // 
            this.filterStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterAll,
            this.filterActive,
            this.filterHold,
            this.filterRejected});
            this.filterStatus.Name = "filterStatus";
            this.filterStatus.Size = new System.Drawing.Size(106, 22);
            this.filterStatus.Text = "Status";
            // 
            // filterAll
            // 
            this.filterAll.Name = "filterAll";
            this.filterAll.Size = new System.Drawing.Size(119, 22);
            this.filterAll.Text = "All";
            this.filterAll.Click += new System.EventHandler(this.FilterToggle_OnClick);
            // 
            // filterActive
            // 
            this.filterActive.Name = "filterActive";
            this.filterActive.Size = new System.Drawing.Size(119, 22);
            this.filterActive.Text = "Active";
            this.filterActive.Click += new System.EventHandler(this.FilterToggle_OnClick);
            // 
            // filterHold
            // 
            this.filterHold.Name = "filterHold";
            this.filterHold.Size = new System.Drawing.Size(119, 22);
            this.filterHold.Text = "Hold";
            this.filterHold.Click += new System.EventHandler(this.FilterToggle_OnClick);
            // 
            // filterRejected
            // 
            this.filterRejected.Name = "filterRejected";
            this.filterRejected.Size = new System.Drawing.Size(119, 22);
            this.filterRejected.Text = "Rejected";
            this.filterRejected.Click += new System.EventHandler(this.FilterToggle_OnClick);
            // 
            // viewJobs
            // 
            this.viewJobs.BackColor = System.Drawing.SystemColors.Control;
            this.viewJobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewJobs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jobsAdd,
            this.jobsEdit,
            this.jobsRemove});
            this.viewJobs.Name = "viewJobs";
            this.viewJobs.Size = new System.Drawing.Size(42, 20);
            this.viewJobs.Text = "Jobs";
            // 
            // jobsAdd
            // 
            this.jobsAdd.BackColor = System.Drawing.SystemColors.Control;
            this.jobsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.jobsAdd.Name = "jobsAdd";
            this.jobsAdd.Size = new System.Drawing.Size(117, 22);
            this.jobsAdd.Text = "Add";
            this.jobsAdd.Click += new System.EventHandler(this.Add);
            // 
            // jobsEdit
            // 
            this.jobsEdit.Name = "jobsEdit";
            this.jobsEdit.Size = new System.Drawing.Size(117, 22);
            this.jobsEdit.Text = "Edit";
            this.jobsEdit.Click += new System.EventHandler(this.Edit);
            // 
            // jobsRemove
            // 
            this.jobsRemove.Name = "jobsRemove";
            this.jobsRemove.Size = new System.Drawing.Size(117, 22);
            this.jobsRemove.Text = "Remove";
            this.jobsRemove.Click += new System.EventHandler(this.Remove);
            // 
            // viewStatus
            // 
            this.viewStatus.Location = new System.Drawing.Point(0, 539);
            this.viewStatus.Name = "viewStatus";
            this.viewStatus.Size = new System.Drawing.Size(784, 22);
            this.viewStatus.TabIndex = 1;
            // 
            // viewPanel
            // 
            this.viewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPanel.Controls.Add(this.viewList);
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 24);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Padding = new System.Windows.Forms.Padding(6);
            this.viewPanel.Size = new System.Drawing.Size(784, 515);
            this.viewPanel.TabIndex = 2;
            // 
            // viewList
            // 
            this.viewList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listStatus,
            this.listPosition,
            this.listCompany,
            this.listAgency,
            this.listLocation,
            this.listInterviews,
            this.listTests});
            this.viewList.ContextMenuStrip = this.listMenu;
            this.viewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewList.FullRowSelect = true;
            this.viewList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.viewList.HideSelection = false;
            this.viewList.LabelWrap = false;
            this.viewList.Location = new System.Drawing.Point(6, 6);
            this.viewList.MultiSelect = false;
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(772, 503);
            this.viewList.TabIndex = 0;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            // 
            // listStatus
            // 
            this.listStatus.Text = "Status";
            this.listStatus.Width = 80;
            // 
            // listPosition
            // 
            this.listPosition.Text = "Position";
            this.listPosition.Width = 120;
            // 
            // listCompany
            // 
            this.listCompany.Text = "Company";
            this.listCompany.Width = 120;
            // 
            // listAgency
            // 
            this.listAgency.Text = "Agency";
            this.listAgency.Width = 120;
            // 
            // listLocation
            // 
            this.listLocation.Text = "Location";
            this.listLocation.Width = 120;
            // 
            // listInterviews
            // 
            this.listInterviews.Text = "Interviews";
            this.listInterviews.Width = 80;
            // 
            // listTests
            // 
            this.listTests.Text = "Tests";
            this.listTests.Width = 80;
            // 
            // listMenu
            // 
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem2,
            this.removeToolStripMenuItem1});
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.Add);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.Edit);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.Remove);
            // 
            // viewSeparator
            // 
            this.viewSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewSeparator.Location = new System.Drawing.Point(0, 24);
            this.viewSeparator.Name = "viewSeparator";
            this.viewSeparator.Size = new System.Drawing.Size(784, 1);
            this.viewSeparator.TabIndex = 4;
            this.viewSeparator.TabStop = false;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "Test";
            this.openDialog.Title = "Open";
            // 
            // saveDialog
            // 
            this.saveDialog.FileName = "Test";
            this.saveDialog.Title = "Save";
            // 
            // BrowseView
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.viewSeparator);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.viewStatus);
            this.Controls.Add(this.viewMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.viewMenu;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "BrowseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redundant";
            this.Load += new System.EventHandler(this.Open);
            this.viewMenu.ResumeLayout(false);
            this.viewMenu.PerformLayout();
            this.viewPanel.ResumeLayout(false);
            this.listMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewSeparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip viewMenu;
        private System.Windows.Forms.StatusStrip viewStatus;
        private System.Windows.Forms.ToolStripMenuItem viewFile;
        private System.Windows.Forms.ToolStripMenuItem fileClose;
        private System.Windows.Forms.ToolStripMenuItem viewView;
        private System.Windows.Forms.ToolStripMenuItem viewJobs;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.ListView viewList;
        private System.Windows.Forms.ColumnHeader listPosition;
        private System.Windows.Forms.ColumnHeader listCompany;
        private System.Windows.Forms.ColumnHeader listAgency;
        private System.Windows.Forms.ColumnHeader listLocation;
        private System.Windows.Forms.ColumnHeader listInterviews;
        private System.Windows.Forms.ColumnHeader listTests;
        private System.Windows.Forms.ColumnHeader listStatus;
        private System.Windows.Forms.PictureBox viewSeparator;
        private System.Windows.Forms.ToolStripMenuItem jobsAdd;
        private System.Windows.Forms.ToolStripMenuItem jobsEdit;
        private System.Windows.Forms.ToolStripMenuItem jobsRemove;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileLoad;
        private System.Windows.Forms.ToolStripMenuItem fileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.ToolStripMenuItem viewSort;
        private System.Windows.Forms.ToolStripMenuItem sortStatus;
        private System.Windows.Forms.ToolStripMenuItem statusAscending;
        private System.Windows.Forms.ToolStripMenuItem statusDescending;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterStatus;
        private System.Windows.Forms.ToolStripMenuItem filterAll;
        private System.Windows.Forms.ToolStripMenuItem filterActive;
        private System.Windows.Forms.ToolStripMenuItem filterHold;
        private System.Windows.Forms.ToolStripMenuItem filterRejected;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

