namespace CapacityKeyV8
{
    partial class SDLCCalUserModule
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
            this.sdlcCalUExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sdlcCalUExitButton
            // 
            this.sdlcCalUExitButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdlcCalUExitButton.Location = new System.Drawing.Point(361, 387);
            this.sdlcCalUExitButton.Name = "sdlcCalUExitButton";
            this.sdlcCalUExitButton.Size = new System.Drawing.Size(75, 27);
            this.sdlcCalUExitButton.TabIndex = 0;
            this.sdlcCalUExitButton.Text = "Exit";
            this.sdlcCalUExitButton.UseVisualStyleBackColor = true;
            this.sdlcCalUExitButton.Click += new System.EventHandler(this.sdlcCalUExitButton_Click);
            // 
            // SDLCCalUserModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.sdlcCalUExitButton);
            this.Name = "SDLCCalUserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Key for Software Teams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sdlcCalUExitButton;
    }
}