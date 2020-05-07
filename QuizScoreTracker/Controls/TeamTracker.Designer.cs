namespace QuizScoreTracker.Controls
{
    partial class TeamTracker
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
            this.components = new System.ComponentModel.Container();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.FullNameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddScore = new System.Windows.Forms.Button();
            this.RemoveScore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PositiveTally = new System.Windows.Forms.FlowLayoutPanel();
            this.NegativeTally = new System.Windows.Forms.FlowLayoutPanel();
            this.PositiveScore = new System.Windows.Forms.Label();
            this.NegativeScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoEllipsis = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.Location = new System.Drawing.Point(16, 27);
            this.TeamNameLabel.MaximumSize = new System.Drawing.Size(150, 21);
            this.TeamNameLabel.MinimumSize = new System.Drawing.Size(150, 21);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(150, 21);
            this.TeamNameLabel.TabIndex = 0;
            this.TeamNameLabel.Text = "Extra Long Team Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 50);
            this.panel1.TabIndex = 1;
            // 
            // AddScore
            // 
            this.AddScore.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddScore.Location = new System.Drawing.Point(172, 12);
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(50, 50);
            this.AddScore.TabIndex = 2;
            this.AddScore.Text = "+1";
            this.AddScore.UseVisualStyleBackColor = true;
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // RemoveScore
            // 
            this.RemoveScore.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveScore.Location = new System.Drawing.Point(436, 12);
            this.RemoveScore.Name = "RemoveScore";
            this.RemoveScore.Size = new System.Drawing.Size(50, 50);
            this.RemoveScore.TabIndex = 4;
            this.RemoveScore.Text = "-1";
            this.RemoveScore.UseVisualStyleBackColor = true;
            this.RemoveScore.Click += new System.EventHandler(this.RemoveScore_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(428, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 50);
            this.panel2.TabIndex = 3;
            // 
            // PositiveTally
            // 
            this.PositiveTally.AutoScroll = true;
            this.PositiveTally.Location = new System.Drawing.Point(228, 12);
            this.PositiveTally.Name = "PositiveTally";
            this.PositiveTally.Size = new System.Drawing.Size(158, 50);
            this.PositiveTally.TabIndex = 5;
            // 
            // NegativeTally
            // 
            this.NegativeTally.AutoScroll = true;
            this.NegativeTally.Location = new System.Drawing.Point(492, 12);
            this.NegativeTally.Name = "NegativeTally";
            this.NegativeTally.Size = new System.Drawing.Size(158, 50);
            this.NegativeTally.TabIndex = 6;
            // 
            // PositiveScore
            // 
            this.PositiveScore.AutoSize = true;
            this.PositiveScore.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.PositiveScore.Location = new System.Drawing.Point(388, 27);
            this.PositiveScore.Name = "PositiveScore";
            this.PositiveScore.Size = new System.Drawing.Size(22, 21);
            this.PositiveScore.TabIndex = 7;
            this.PositiveScore.Text = "0";
            // 
            // NegativeScore
            // 
            this.NegativeScore.AutoSize = true;
            this.NegativeScore.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.NegativeScore.Location = new System.Drawing.Point(655, 27);
            this.NegativeScore.Name = "NegativeScore";
            this.NegativeScore.Size = new System.Drawing.Size(22, 21);
            this.NegativeScore.TabIndex = 8;
            this.NegativeScore.Text = "0";
            // 
            // TeamTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NegativeTally);
            this.Controls.Add(this.PositiveTally);
            this.Controls.Add(this.NegativeScore);
            this.Controls.Add(this.PositiveScore);
            this.Controls.Add(this.RemoveScore);
            this.Controls.Add(this.AddScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TeamNameLabel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TeamTracker";
            this.Size = new System.Drawing.Size(700, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.ToolTip FullNameTooltip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddScore;
        private System.Windows.Forms.Button RemoveScore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel PositiveTally;
        private System.Windows.Forms.FlowLayoutPanel NegativeTally;
        private System.Windows.Forms.Label PositiveScore;
        private System.Windows.Forms.Label NegativeScore;
    }
}
