namespace Memory.Forms
{
    partial class InGameSettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numMistakesLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pairsFoundLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.initMemoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timePassedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.afterClickBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterClickBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.numMistakesLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pairsFoundLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.initMemoLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.boardSizeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timePassedLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.afterClickBar, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 279);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // numMistakesLabel
            // 
            this.numMistakesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMistakesLabel.AutoSize = true;
            this.numMistakesLabel.Location = new System.Drawing.Point(186, 248);
            this.numMistakesLabel.Name = "numMistakesLabel";
            this.numMistakesLabel.Size = new System.Drawing.Size(10, 13);
            this.numMistakesLabel.TabIndex = 11;
            this.numMistakesLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mistakes:";
            // 
            // pairsFoundLabel
            // 
            this.pairsFoundLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pairsFoundLabel.AutoSize = true;
            this.pairsFoundLabel.Location = new System.Drawing.Point(186, 200);
            this.pairsFoundLabel.Name = "pairsFoundLabel";
            this.pairsFoundLabel.Size = new System.Drawing.Size(10, 13);
            this.pairsFoundLabel.TabIndex = 9;
            this.pairsFoundLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pairs Found:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "After-Click Time:";
            // 
            // initMemoLabel
            // 
            this.initMemoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initMemoLabel.AutoSize = true;
            this.initMemoLabel.Location = new System.Drawing.Point(186, 108);
            this.initMemoLabel.Name = "initMemoLabel";
            this.initMemoLabel.Size = new System.Drawing.Size(10, 13);
            this.initMemoLabel.TabIndex = 5;
            this.initMemoLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Initial Memorization:";
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(186, 62);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(10, 13);
            this.boardSizeLabel.TabIndex = 3;
            this.boardSizeLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Board Size:";
            // 
            // timePassedLabel
            // 
            this.timePassedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePassedLabel.AutoSize = true;
            this.timePassedLabel.Location = new System.Drawing.Point(186, 16);
            this.timePassedLabel.Name = "timePassedLabel";
            this.timePassedLabel.Size = new System.Drawing.Size(10, 13);
            this.timePassedLabel.TabIndex = 1;
            this.timePassedLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Passed:";
            // 
            // afterClickBar
            // 
            this.afterClickBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.afterClickBar.Location = new System.Drawing.Point(130, 141);
            this.afterClickBar.Maximum = 8;
            this.afterClickBar.Minimum = 1;
            this.afterClickBar.Name = "afterClickBar";
            this.afterClickBar.Size = new System.Drawing.Size(122, 40);
            this.afterClickBar.TabIndex = 12;
            this.afterClickBar.Value = 1;
            this.afterClickBar.Scroll += new System.EventHandler(this.afterClickBar_Scroll);
            // 
            // InGameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 279);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "InGameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InGameSettingsForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterClickBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label numMistakesLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label pairsFoundLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label initMemoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timePassedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar afterClickBar;
    }
}