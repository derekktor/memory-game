
namespace Memory
{
    partial class SettingsForm
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
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.initMemoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.afterClickLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.initMemoBar = new System.Windows.Forms.TrackBar();
            this.afterClickBar = new System.Windows.Forms.TrackBar();
            this.boardSizeBar = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initMemoBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterClickBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(200, 22);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(29, 13);
            this.boardSizeLabel.TabIndex = 1;
            this.boardSizeLabel.Text = "label";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Board size:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Memorization:";
            // 
            // initMemoLabel
            // 
            this.initMemoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initMemoLabel.AutoSize = true;
            this.initMemoLabel.Location = new System.Drawing.Point(200, 80);
            this.initMemoLabel.Name = "initMemoLabel";
            this.initMemoLabel.Size = new System.Drawing.Size(29, 13);
            this.initMemoLabel.TabIndex = 4;
            this.initMemoLabel.Text = "label";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "After-Click Time:";
            // 
            // afterClickLabel
            // 
            this.afterClickLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.afterClickLabel.AutoSize = true;
            this.afterClickLabel.Location = new System.Drawing.Point(200, 138);
            this.afterClickLabel.Name = "afterClickLabel";
            this.afterClickLabel.Size = new System.Drawing.Size(29, 13);
            this.afterClickLabel.TabIndex = 7;
            this.afterClickLabel.Text = "label";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.boardSizeLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.boardSizeBar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.afterClickLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.afterClickBar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.initMemoLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.initMemoBar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 177);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // initMemoBar
            // 
            this.initMemoBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.initMemoBar.LargeChange = 10;
            this.initMemoBar.Location = new System.Drawing.Point(261, 64);
            this.initMemoBar.Maximum = 12;
            this.initMemoBar.Minimum = 1;
            this.initMemoBar.Name = "initMemoBar";
            this.initMemoBar.Size = new System.Drawing.Size(166, 45);
            this.initMemoBar.TabIndex = 3;
            this.initMemoBar.Value = 6;
            this.initMemoBar.Scroll += new System.EventHandler(this.initMemoBar_Scroll);
            // 
            // afterClickBar
            // 
            this.afterClickBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.afterClickBar.LargeChange = 1;
            this.afterClickBar.Location = new System.Drawing.Point(261, 122);
            this.afterClickBar.Maximum = 8;
            this.afterClickBar.Minimum = 1;
            this.afterClickBar.Name = "afterClickBar";
            this.afterClickBar.Size = new System.Drawing.Size(166, 45);
            this.afterClickBar.TabIndex = 6;
            this.afterClickBar.Value = 6;
            this.afterClickBar.Scroll += new System.EventHandler(this.afterClickBar_Scroll);
            // 
            // boardSizeBar
            // 
            this.boardSizeBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardSizeBar.LargeChange = 1;
            this.boardSizeBar.Location = new System.Drawing.Point(261, 6);
            this.boardSizeBar.Maximum = 3;
            this.boardSizeBar.Name = "boardSizeBar";
            this.boardSizeBar.Size = new System.Drawing.Size(166, 45);
            this.boardSizeBar.TabIndex = 0;
            this.boardSizeBar.Value = 1;
            this.boardSizeBar.Scroll += new System.EventHandler(this.boardSizeBar_Scroll);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initMemoBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterClickBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardSizeBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label initMemoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label afterClickLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar boardSizeBar;
        private System.Windows.Forms.TrackBar afterClickBar;
        private System.Windows.Forms.TrackBar initMemoBar;
    }
}