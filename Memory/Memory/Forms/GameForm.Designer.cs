
namespace Memory
{
    partial class GameForm
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
            this.board = new System.Windows.Forms.TableLayoutPanel();
            this.infoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.timePassedLabel = new System.Windows.Forms.Label();
            this.numMistakesLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainContrainer = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.infoContainer.SuspendLayout();
            this.mainContrainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.AutoSize = true;
            this.board.ColumnCount = 1;
            this.mainContrainer.SetColumnSpan(this.board, 2);
            this.board.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(3, 59);
            this.board.Name = "board";
            this.board.RowCount = 1;
            this.board.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.board.Size = new System.Drawing.Size(778, 499);
            this.board.TabIndex = 0;
            // 
            // infoContainer
            // 
            this.infoContainer.AutoSize = true;
            this.infoContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoContainer.ColumnCount = 2;
            this.infoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.infoContainer.Controls.Add(this.label4, 1, 0);
            this.infoContainer.Controls.Add(this.timePassedLabel, 0, 1);
            this.infoContainer.Controls.Add(this.numMistakesLabel, 1, 1);
            this.infoContainer.Controls.Add(this.label3, 0, 0);
            this.infoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoContainer.Location = new System.Drawing.Point(0, 0);
            this.infoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.infoContainer.Name = "infoContainer";
            this.infoContainer.Padding = new System.Windows.Forms.Padding(2);
            this.infoContainer.RowCount = 2;
            this.infoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.infoContainer.Size = new System.Drawing.Size(627, 56);
            this.infoContainer.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(435, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mistakes:";
            // 
            // timePassedLabel
            // 
            this.timePassedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timePassedLabel.AutoSize = true;
            this.timePassedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePassedLabel.Location = new System.Drawing.Point(151, 32);
            this.timePassedLabel.Name = "timePassedLabel";
            this.timePassedLabel.Size = new System.Drawing.Size(13, 17);
            this.timePassedLabel.TabIndex = 1;
            this.timePassedLabel.Text = "-";
            // 
            // numMistakesLabel
            // 
            this.numMistakesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numMistakesLabel.AutoSize = true;
            this.numMistakesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMistakesLabel.Location = new System.Drawing.Point(462, 32);
            this.numMistakesLabel.Name = "numMistakesLabel";
            this.numMistakesLabel.Size = new System.Drawing.Size(13, 17);
            this.numMistakesLabel.TabIndex = 2;
            this.numMistakesLabel.Text = "-";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Time Passed:";
            // 
            // mainContrainer
            // 
            this.mainContrainer.ColumnCount = 2;
            this.mainContrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.mainContrainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainContrainer.Controls.Add(this.board, 0, 1);
            this.mainContrainer.Controls.Add(this.infoContainer, 0, 0);
            this.mainContrainer.Controls.Add(this.button1, 1, 0);
            this.mainContrainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContrainer.Location = new System.Drawing.Point(0, 0);
            this.mainContrainer.Name = "mainContrainer";
            this.mainContrainer.RowCount = 2;
            this.mainContrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.mainContrainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.mainContrainer.Size = new System.Drawing.Size(784, 561);
            this.mainContrainer.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(668, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InGameSettingsBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainContrainer);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.infoContainer.ResumeLayout(false);
            this.infoContainer.PerformLayout();
            this.mainContrainer.ResumeLayout(false);
            this.mainContrainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board;
        private System.Windows.Forms.TableLayoutPanel infoContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timePassedLabel;
        private System.Windows.Forms.Label numMistakesLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel mainContrainer;
        private System.Windows.Forms.Button button1;
    }
}