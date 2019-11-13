namespace CapacityKeyV8
{
    partial class ManageTeamModule
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
            this.mngTeamExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mngTeamExitButton
            // 
            this.mngTeamExitButton.Location = new System.Drawing.Point(361, 519);
            this.mngTeamExitButton.Name = "mngTeamExitButton";
            this.mngTeamExitButton.Size = new System.Drawing.Size(75, 23);
            this.mngTeamExitButton.TabIndex = 0;
            this.mngTeamExitButton.Text = "Exit";
            this.mngTeamExitButton.UseVisualStyleBackColor = true;
            this.mngTeamExitButton.Click += new System.EventHandler(this.mngTeamExitButton_Click);
            // 
            // ManageTeamModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.mngTeamExitButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageTeamModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Key for Software Teams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mngTeamExitButton;
    }
}