namespace CapacityKeyV8
{
    partial class UserModule
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDLCCalendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacityKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userModuleTitleLabel = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sDLCCalendarToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // sDLCCalendarToolStripMenuItem
            // 
            this.sDLCCalendarToolStripMenuItem.Name = "sDLCCalendarToolStripMenuItem";
            this.sDLCCalendarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sDLCCalendarToolStripMenuItem.Text = "SDLC Calendar";
            this.sDLCCalendarToolStripMenuItem.Click += new System.EventHandler(this.sDLCCalendarToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capacityKeyToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // capacityKeyToolStripMenuItem
            // 
            this.capacityKeyToolStripMenuItem.Name = "capacityKeyToolStripMenuItem";
            this.capacityKeyToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.capacityKeyToolStripMenuItem.Text = "Capacity Key";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userModuleTitleLabel
            // 
            this.userModuleTitleLabel.AutoSize = true;
            this.userModuleTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userModuleTitleLabel.Location = new System.Drawing.Point(315, 64);
            this.userModuleTitleLabel.Name = "userModuleTitleLabel";
            this.userModuleTitleLabel.Size = new System.Drawing.Size(171, 29);
            this.userModuleTitleLabel.TabIndex = 19;
            this.userModuleTitleLabel.Text = "User Dashboard";
            this.userModuleTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamCapacityLabel
            // 
            this.teamCapacityLabel.AutoSize = true;
            this.teamCapacityLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamCapacityLabel.Location = new System.Drawing.Point(503, 323);
            this.teamCapacityLabel.Name = "teamCapacityLabel";
            this.teamCapacityLabel.Size = new System.Drawing.Size(114, 21);
            this.teamCapacityLabel.TabIndex = 35;
            this.teamCapacityLabel.Text = "Team Capacity:";
            // 
            // projectDaysLabel
            // 
            this.projectDaysLabel.AutoSize = true;
            this.projectDaysLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDaysLabel.Location = new System.Drawing.Point(310, 320);
            this.projectDaysLabel.Name = "projectDaysLabel";
            this.projectDaysLabel.Size = new System.Drawing.Size(101, 21);
            this.projectDaysLabel.TabIndex = 34;
            this.projectDaysLabel.Text = "Project Days:";
            // 
            // projectHoursLabel
            // 
            this.projectHoursLabel.AutoSize = true;
            this.projectHoursLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectHoursLabel.Location = new System.Drawing.Point(301, 284);
            this.projectHoursLabel.Name = "projectHoursLabel";
            this.projectHoursLabel.Size = new System.Drawing.Size(110, 21);
            this.projectHoursLabel.TabIndex = 33;
            this.projectHoursLabel.Text = "Project Hours:";
            // 
            // projectCountLabel
            // 
            this.projectCountLabel.AutoSize = true;
            this.projectCountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCountLabel.Location = new System.Drawing.Point(301, 244);
            this.projectCountLabel.Name = "projectCountLabel";
            this.projectCountLabel.Size = new System.Drawing.Size(110, 21);
            this.projectCountLabel.TabIndex = 32;
            this.projectCountLabel.Text = "Project Count:";
            // 
            // resourceCountLabel
            // 
            this.resourceCountLabel.AutoSize = true;
            this.resourceCountLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceCountLabel.Location = new System.Drawing.Point(141, 242);
            this.resourceCountLabel.Name = "resourceCountLabel";
            this.resourceCountLabel.Size = new System.Drawing.Size(85, 21);
            this.resourceCountLabel.TabIndex = 29;
            this.resourceCountLabel.Text = "Resources:";
            // 
            // availableHoursLabel
            // 
            this.availableHoursLabel.AutoSize = true;
            this.availableHoursLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableHoursLabel.Location = new System.Drawing.Point(102, 284);
            this.availableHoursLabel.Name = "availableHoursLabel";
            this.availableHoursLabel.Size = new System.Drawing.Size(124, 21);
            this.availableHoursLabel.TabIndex = 30;
            this.availableHoursLabel.Text = "Available Hours:";
            // 
            // availableDaysLabel
            // 
            this.availableDaysLabel.AutoSize = true;
            this.availableDaysLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableDaysLabel.Location = new System.Drawing.Point(114, 323);
            this.availableDaysLabel.Name = "availableDaysLabel";
            this.availableDaysLabel.Size = new System.Drawing.Size(115, 21);
            this.availableDaysLabel.TabIndex = 31;
            this.availableDaysLabel.Text = "Available Days:";
            // 
            // executionTimeLabel
            // 
            this.executionTimeLabel.AutoSize = true;
            this.executionTimeLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executionTimeLabel.Location = new System.Drawing.Point(267, 184);
            this.executionTimeLabel.Name = "executionTimeLabel";
            this.executionTimeLabel.Size = new System.Drawing.Size(167, 21);
            this.executionTimeLabel.TabIndex = 28;
            this.executionTimeLabel.Text = "Execution Time Frame:";
            // 
            // releasePickerDDBox
            // 
            this.releasePickerDDBox.FormattingEnabled = true;
            this.releasePickerDDBox.Location = new System.Drawing.Point(382, 132);
            this.releasePickerDDBox.Name = "releasePickerDDBox";
            this.releasePickerDDBox.Size = new System.Drawing.Size(123, 26);
            this.releasePickerDDBox.TabIndex = 27;
            // 
            // releasePickerLabel
            // 
            this.releasePickerLabel.AutoSize = true;
            this.releasePickerLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releasePickerLabel.Location = new System.Drawing.Point(296, 132);
            this.releasePickerLabel.Name = "releasePickerLabel";
            this.releasePickerLabel.Size = new System.Drawing.Size(67, 21);
            this.releasePickerLabel.TabIndex = 26;
            this.releasePickerLabel.Text = "Release:";
            this.releasePickerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
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
            this.Controls.Add(this.userModuleTitleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Key for Software Teams";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDLCCalendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capacityKeyToolStripMenuItem;
        private System.Windows.Forms.Label userModuleTitleLabel;
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