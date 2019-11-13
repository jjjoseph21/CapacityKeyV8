namespace CapacityKeyV8
{
    partial class AdminModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseCycleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDLCCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacityKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminModuleTitleLabel = new System.Windows.Forms.Label();
            this.teamCapacityLabel = new System.Windows.Forms.Label();
            this.projectDaysLabel = new System.Windows.Forms.Label();
            this.projectHoursLabel = new System.Windows.Forms.Label();
            this.projectCountLabel = new System.Windows.Forms.Label();
            this.resourceCountLabel = new System.Windows.Forms.Label();
            this.availableHoursLabel = new System.Windows.Forms.Label();
            this.availableDaysLabel = new System.Windows.Forms.Label();
            this.executionTimeLabel = new System.Windows.Forms.Label();
            this.releasePickerDDBox = new System.Windows.Forms.ComboBox();
            this.releasePickerLabel = new System.Windows.Forms.Label();
            this.adminMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminMenuStrip
            // 
            this.adminMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.adminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.adminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.adminMenuStrip.Name = "adminMenuStrip";
            this.adminMenuStrip.Size = new System.Drawing.Size(800, 33);
            this.adminMenuStrip.TabIndex = 0;
            this.adminMenuStrip.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.releaseCycleToolStripMenuItem,
            this.sDLCCalendarToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // releaseCycleToolStripMenuItem
            // 
            this.releaseCycleToolStripMenuItem.Name = "releaseCycleToolStripMenuItem";
            this.releaseCycleToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.releaseCycleToolStripMenuItem.Text = "Release Cycle";
            this.releaseCycleToolStripMenuItem.Click += new System.EventHandler(this.releaseCycleToolStripMenuItem_Click);
            // 
            // sDLCCalendarToolStripMenuItem
            // 
            this.sDLCCalendarToolStripMenuItem.Name = "sDLCCalendarToolStripMenuItem";
            this.sDLCCalendarToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.sDLCCalendarToolStripMenuItem.Text = "SDLC Calendar";
            this.sDLCCalendarToolStripMenuItem.Click += new System.EventHandler(this.sDLCCalendarToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.teamToolStripMenuItem.Text = "Team";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capacityKeyToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // capacityKeyToolStripMenuItem
            // 
            this.capacityKeyToolStripMenuItem.Name = "capacityKeyToolStripMenuItem";
            this.capacityKeyToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.capacityKeyToolStripMenuItem.Text = "Capacity Key";
            // 
            // adminModuleTitleLabel
            // 
            this.adminModuleTitleLabel.AutoSize = true;
            this.adminModuleTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminModuleTitleLabel.Location = new System.Drawing.Point(267, 64);
            this.adminModuleTitleLabel.Name = "adminModuleTitleLabel";
            this.adminModuleTitleLabel.Size = new System.Drawing.Size(218, 35);
            this.adminModuleTitleLabel.TabIndex = 18;
            this.adminModuleTitleLabel.Text = "Admin Dashboard";
            this.adminModuleTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamCapacityLabel
            // 
            this.teamCapacityLabel.AutoSize = true;
            this.teamCapacityLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamCapacityLabel.Location = new System.Drawing.Point(503, 323);
            this.teamCapacityLabel.Name = "teamCapacityLabel";
            this.teamCapacityLabel.Size = new System.Drawing.Size(141, 26);
            this.teamCapacityLabel.TabIndex = 35;
            this.teamCapacityLabel.Text = "Team Capacity:";
            // 
            // projectDaysLabel
            // 
            this.projectDaysLabel.AutoSize = true;
            this.projectDaysLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDaysLabel.Location = new System.Drawing.Point(310, 320);
            this.projectDaysLabel.Name = "projectDaysLabel";
            this.projectDaysLabel.Size = new System.Drawing.Size(124, 26);
            this.projectDaysLabel.TabIndex = 34;
            this.projectDaysLabel.Text = "Project Days:";
            // 
            // projectHoursLabel
            // 
            this.projectHoursLabel.AutoSize = true;
            this.projectHoursLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectHoursLabel.Location = new System.Drawing.Point(301, 284);
            this.projectHoursLabel.Name = "projectHoursLabel";
            this.projectHoursLabel.Size = new System.Drawing.Size(133, 26);
            this.projectHoursLabel.TabIndex = 33;
            this.projectHoursLabel.Text = "Project Hours:";
            // 
            // projectCountLabel
            // 
            this.projectCountLabel.AutoSize = true;
            this.projectCountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCountLabel.Location = new System.Drawing.Point(301, 244);
            this.projectCountLabel.Name = "projectCountLabel";
            this.projectCountLabel.Size = new System.Drawing.Size(134, 26);
            this.projectCountLabel.TabIndex = 32;
            this.projectCountLabel.Text = "Project Count:";
            // 
            // resourceCountLabel
            // 
            this.resourceCountLabel.AutoSize = true;
            this.resourceCountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceCountLabel.Location = new System.Drawing.Point(141, 242);
            this.resourceCountLabel.Name = "resourceCountLabel";
            this.resourceCountLabel.Size = new System.Drawing.Size(103, 26);
            this.resourceCountLabel.TabIndex = 29;
            this.resourceCountLabel.Text = "Resources:";
            // 
            // availableHoursLabel
            // 
            this.availableHoursLabel.AutoSize = true;
            this.availableHoursLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableHoursLabel.Location = new System.Drawing.Point(102, 284);
            this.availableHoursLabel.Name = "availableHoursLabel";
            this.availableHoursLabel.Size = new System.Drawing.Size(150, 26);
            this.availableHoursLabel.TabIndex = 30;
            this.availableHoursLabel.Text = "Available Hours:";
            // 
            // availableDaysLabel
            // 
            this.availableDaysLabel.AutoSize = true;
            this.availableDaysLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableDaysLabel.Location = new System.Drawing.Point(114, 323);
            this.availableDaysLabel.Name = "availableDaysLabel";
            this.availableDaysLabel.Size = new System.Drawing.Size(141, 26);
            this.availableDaysLabel.TabIndex = 31;
            this.availableDaysLabel.Text = "Available Days:";
            // 
            // executionTimeLabel
            // 
            this.executionTimeLabel.AutoSize = true;
            this.executionTimeLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionTimeLabel.Location = new System.Drawing.Point(267, 184);
            this.executionTimeLabel.Name = "executionTimeLabel";
            this.executionTimeLabel.Size = new System.Drawing.Size(206, 26);
            this.executionTimeLabel.TabIndex = 28;
            this.executionTimeLabel.Text = "Execution Time Frame:";
            // 
            // releasePickerDDBox
            // 
            this.releasePickerDDBox.FormattingEnabled = true;
            this.releasePickerDDBox.Location = new System.Drawing.Point(353, 132);
            this.releasePickerDDBox.Name = "releasePickerDDBox";
            this.releasePickerDDBox.Size = new System.Drawing.Size(123, 31);
            this.releasePickerDDBox.TabIndex = 27;
            // 
            // releasePickerLabel
            // 
            this.releasePickerLabel.AutoSize = true;
            this.releasePickerLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasePickerLabel.Location = new System.Drawing.Point(267, 132);
            this.releasePickerLabel.Name = "releasePickerLabel";
            this.releasePickerLabel.Size = new System.Drawing.Size(82, 26);
            this.releasePickerLabel.TabIndex = 26;
            this.releasePickerLabel.Text = "Release:";
            this.releasePickerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AdminModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.teamCapacityLabel);
            this.Controls.Add(this.projectDaysLabel);
            this.Controls.Add(this.projectHoursLabel);
            this.Controls.Add(this.projectCountLabel);
            this.Controls.Add(this.resourceCountLabel);
            this.Controls.Add(this.availableHoursLabel);
            this.Controls.Add(this.availableDaysLabel);
            this.Controls.Add(this.executionTimeLabel);
            this.Controls.Add(this.releasePickerDDBox);
            this.Controls.Add(this.releasePickerLabel);
            this.Controls.Add(this.adminModuleTitleLabel);
            this.Controls.Add(this.adminMenuStrip);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.adminMenuStrip;
            this.Name = "AdminModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Key for Software Teams";
            this.Load += new System.EventHandler(this.AdminModule_Load);
            this.adminMenuStrip.ResumeLayout(false);
            this.adminMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip adminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseCycleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDLCCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacityKeyToolStripMenuItem;
        private System.Windows.Forms.Label adminModuleTitleLabel;
        private System.Windows.Forms.Label teamCapacityLabel;
        private System.Windows.Forms.Label projectDaysLabel;
        private System.Windows.Forms.Label projectHoursLabel;
        private System.Windows.Forms.Label projectCountLabel;
        private System.Windows.Forms.Label resourceCountLabel;
        private System.Windows.Forms.Label availableHoursLabel;
        private System.Windows.Forms.Label availableDaysLabel;
        private System.Windows.Forms.Label executionTimeLabel;
        private System.Windows.Forms.ComboBox releasePickerDDBox;
        private System.Windows.Forms.Label releasePickerLabel;
    }
}