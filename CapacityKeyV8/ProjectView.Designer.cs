namespace CapacityKeyV8
{
    partial class ProjectView
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
            this.exitPVbutton = new System.Windows.Forms.Button();
            this.cKFSTdbDataSet = new CapacityKeyV8.CKFSTdbDataSet();
            this.projectViewLabel = new System.Windows.Forms.Label();
            this.projectsViewListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cKFSTdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // exitPVbutton
            // 
            this.exitPVbutton.Location = new System.Drawing.Point(425, 400);
            this.exitPVbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitPVbutton.Name = "exitPVbutton";
            this.exitPVbutton.Size = new System.Drawing.Size(67, 29);
            this.exitPVbutton.TabIndex = 3;
            this.exitPVbutton.Text = "Exit";
            this.exitPVbutton.UseVisualStyleBackColor = true;
            this.exitPVbutton.Click += new System.EventHandler(this.exitPVbutton_Click);
            // 
            // cKFSTdbDataSet
            // 
            this.cKFSTdbDataSet.DataSetName = "CKFSTdbDataSet";
            this.cKFSTdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectViewLabel
            // 
            this.projectViewLabel.AutoSize = true;
            this.projectViewLabel.Location = new System.Drawing.Point(423, 41);
            this.projectViewLabel.Name = "projectViewLabel";
            this.projectViewLabel.Size = new System.Drawing.Size(70, 23);
            this.projectViewLabel.TabIndex = 4;
            this.projectViewLabel.Text = "Projects";
            // 
            // projectsViewListBox
            // 
            this.projectsViewListBox.FormattingEnabled = true;
            this.projectsViewListBox.ItemHeight = 23;
            this.projectsViewListBox.Location = new System.Drawing.Point(36, 93);
            this.projectsViewListBox.Name = "projectsViewListBox";
            this.projectsViewListBox.Size = new System.Drawing.Size(845, 280);
            this.projectsViewListBox.TabIndex = 5;
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 449);
            this.Controls.Add(this.projectsViewListBox);
            this.Controls.Add(this.projectViewLabel);
            this.Controls.Add(this.exitPVbutton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProjectView";
            this.Text = "Capacity Key for Software Teams";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cKFSTdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitPVbutton;
        private CKFSTdbDataSet cKFSTdbDataSet;
        private System.Windows.Forms.Label projectViewLabel;
        private System.Windows.Forms.ListBox projectsViewListBox;
    }
}