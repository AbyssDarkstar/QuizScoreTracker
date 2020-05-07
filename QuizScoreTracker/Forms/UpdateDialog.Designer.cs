namespace QuizScoreTracker.Forms
{
    partial class UpdateDialog
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
            this.UpdateAvailableTitle = new System.Windows.Forms.Label();
            this.ChangeLogTextbox = new System.Windows.Forms.RichTextBox();
            this.Skip = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // UpdateAvailableTitle
            // 
            this.UpdateAvailableTitle.AutoSize = true;
            this.UpdateAvailableTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAvailableTitle.Location = new System.Drawing.Point(12, 9);
            this.UpdateAvailableTitle.Name = "UpdateAvailableTitle";
            this.UpdateAvailableTitle.Size = new System.Drawing.Size(254, 33);
            this.UpdateAvailableTitle.TabIndex = 4;
            this.UpdateAvailableTitle.Text = "Update Available";
            // 
            // ChangeLogTextbox
            // 
            this.ChangeLogTextbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLogTextbox.Location = new System.Drawing.Point(18, 45);
            this.ChangeLogTextbox.Name = "ChangeLogTextbox";
            this.ChangeLogTextbox.ReadOnly = true;
            this.ChangeLogTextbox.Size = new System.Drawing.Size(519, 345);
            this.ChangeLogTextbox.TabIndex = 5;
            this.ChangeLogTextbox.Text = "";
            // 
            // Skip
            // 
            this.Skip.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Skip.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skip.Location = new System.Drawing.Point(387, 396);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(150, 39);
            this.Skip.TabIndex = 9;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(231, 396);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(150, 39);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(18, 396);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(207, 39);
            this.DownloadProgress.Step = 1;
            this.DownloadProgress.TabIndex = 11;
            this.DownloadProgress.Visible = false;
            // 
            // UpdateDialog
            // 
            this.AcceptButton = this.UpdateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Skip;
            this.ClientSize = new System.Drawing.Size(549, 447);
            this.ControlBox = false;
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.ChangeLogTextbox);
            this.Controls.Add(this.UpdateAvailableTitle);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateAvailableTitle;
        private System.Windows.Forms.RichTextBox ChangeLogTextbox;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ProgressBar DownloadProgress;
    }
}