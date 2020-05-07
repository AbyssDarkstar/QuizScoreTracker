namespace QuizScoreTracker.Forms
{
    partial class TotalsDialog
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
            this.ScoreTotalsTitle = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ScoresFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ScoreTotalsTitle
            // 
            this.ScoreTotalsTitle.AutoSize = true;
            this.ScoreTotalsTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTotalsTitle.Location = new System.Drawing.Point(12, 9);
            this.ScoreTotalsTitle.Name = "ScoreTotalsTitle";
            this.ScoreTotalsTitle.Size = new System.Drawing.Size(198, 33);
            this.ScoreTotalsTitle.TabIndex = 3;
            this.ScoreTotalsTitle.Text = "Score Totals";
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(239, 390);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(150, 39);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ScoresFlowLayout
            // 
            this.ScoresFlowLayout.AutoScroll = true;
            this.ScoresFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScoresFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ScoresFlowLayout.Location = new System.Drawing.Point(18, 45);
            this.ScoresFlowLayout.Name = "ScoresFlowLayout";
            this.ScoresFlowLayout.Size = new System.Drawing.Size(600, 339);
            this.ScoresFlowLayout.TabIndex = 9;
            this.ScoresFlowLayout.WrapContents = false;
            // 
            // TotalsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(628, 441);
            this.Controls.Add(this.ScoresFlowLayout);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ScoreTotalsTitle);
            this.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TotalsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Totals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreTotalsTitle;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.FlowLayoutPanel ScoresFlowLayout;
    }
}