namespace QuizScoreTracker.Controls
{
    partial class TeamScores
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Position = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.Label();
            this.Maths = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position.Location = new System.Drawing.Point(3, 13);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(36, 24);
            this.Position.TabIndex = 0;
            this.Position.Text = "#0";
            // 
            // TeamName
            // 
            this.TeamName.AutoSize = true;
            this.TeamName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamName.Location = new System.Drawing.Point(45, 13);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(137, 24);
            this.TeamName.TabIndex = 1;
            this.TeamName.Text = "Team Name";
            // 
            // Maths
            // 
            this.Maths.AutoSize = true;
            this.Maths.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maths.Location = new System.Drawing.Point(342, 13);
            this.Maths.Name = "Maths";
            this.Maths.Size = new System.Drawing.Size(159, 24);
            this.Maths.TabIndex = 2;
            this.Maths.Text = "10 - 50 = -40";
            // 
            // TeamScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Maths);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.Position);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeamScores";
            this.Size = new System.Drawing.Size(550, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label TeamName;
        private System.Windows.Forms.Label Maths;
    }
}
