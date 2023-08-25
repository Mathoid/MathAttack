
namespace MathAttack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Easy", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Medium", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Hard", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Add Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Subtract Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Multiply Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Divide Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Add Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Subtract Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Multiply Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Divide Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Add Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Subtract Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Multiply Two Numbers");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Divide Two Numbers");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionList = new System.Windows.Forms.ListView();
            this.Question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Response = new System.Windows.Forms.TextBox();
            this.Reward = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RewardText = new System.Windows.Forms.Label();
            this.Skip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetTimer = new System.Windows.Forms.Button();
            this.QPerMinute = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TimerText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.QStreak = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.QPercent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.QCorrect = new System.Windows.Forms.Label();
            this.QAttempt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reward)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.viewHistoryToolStripMenuItem.Text = "Statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Type of Problem:";
            // 
            // QuestionList
            // 
            listViewGroup1.Header = "Easy";
            listViewGroup1.Name = "EasyQuestions";
            listViewGroup2.Header = "Medium";
            listViewGroup2.Name = "MediumQuestions";
            listViewGroup3.Header = "Hard";
            listViewGroup3.Name = "HardQuestions";
            this.QuestionList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.QuestionList.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup2;
            listViewItem6.Group = listViewGroup2;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup3;
            listViewItem11.Group = listViewGroup3;
            listViewItem12.Group = listViewGroup3;
            this.QuestionList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.QuestionList.Location = new System.Drawing.Point(12, 54);
            this.QuestionList.MultiSelect = false;
            this.QuestionList.Name = "QuestionList";
            this.QuestionList.Size = new System.Drawing.Size(171, 565);
            this.QuestionList.TabIndex = 3;
            this.QuestionList.UseCompatibleStateImageBehavior = false;
            this.QuestionList.View = System.Windows.Forms.View.Tile;
            this.QuestionList.SelectedIndexChanged += new System.EventHandler(this.QuestionList_SelectedIndexChanged);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(232, 54);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(205, 51);
            this.Question.TabIndex = 4;
            this.Question.Text = "2 + 4 = ???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(232, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Here\'s the Question!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(232, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "What\'s Your Answer?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Response
            // 
            this.Response.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Response.Location = new System.Drawing.Point(232, 152);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(268, 57);
            this.Response.TabIndex = 7;
            this.Response.Text = "6";
            this.Response.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Response.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Response_KeyPress);
            // 
            // Reward
            // 
            this.Reward.Location = new System.Drawing.Point(232, 245);
            this.Reward.Name = "Reward";
            this.Reward.Size = new System.Drawing.Size(350, 350);
            this.Reward.TabIndex = 8;
            this.Reward.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(232, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hit ENTER to Submit Your Answer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RewardText
            // 
            this.RewardText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardText.Location = new System.Drawing.Point(232, 598);
            this.RewardText.Name = "RewardText";
            this.RewardText.Size = new System.Drawing.Size(350, 21);
            this.RewardText.TabIndex = 10;
            this.RewardText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Skip
            // 
            this.Skip.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Skip.Location = new System.Drawing.Point(510, 152);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(72, 57);
            this.Skip.TabIndex = 11;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = true;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ResetTimer);
            this.panel1.Controls.Add(this.QPerMinute);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.TimerText);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.QStreak);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.QPercent);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.QCorrect);
            this.panel1.Controls.Add(this.QAttempt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(637, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 570);
            this.panel1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(138, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "minutes";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ResetTimer
            // 
            this.ResetTimer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetTimer.Location = new System.Drawing.Point(225, 298);
            this.ResetTimer.Name = "ResetTimer";
            this.ResetTimer.Size = new System.Drawing.Size(101, 36);
            this.ResetTimer.TabIndex = 13;
            this.ResetTimer.Text = "Reset";
            this.ResetTimer.UseVisualStyleBackColor = true;
            this.ResetTimer.Click += new System.EventHandler(this.ResetTimer_Click);
            // 
            // QPerMinute
            // 
            this.QPerMinute.AutoSize = true;
            this.QPerMinute.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QPerMinute.Location = new System.Drawing.Point(260, 246);
            this.QPerMinute.Name = "QPerMinute";
            this.QPerMinute.Size = new System.Drawing.Size(50, 25);
            this.QPerMinute.TabIndex = 24;
            this.QPerMinute.Text = "0.00";
            this.QPerMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(35, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 21);
            this.label16.TabIndex = 23;
            this.label16.Text = "Percentage Correct Answers:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimerText.Location = new System.Drawing.Point(102, 305);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(36, 25);
            this.TimerText.TabIndex = 22;
            this.TimerText.Text = "---";
            this.TimerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(26, 308);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Timer:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QStreak
            // 
            this.QStreak.AutoSize = true;
            this.QStreak.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QStreak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QStreak.Location = new System.Drawing.Point(260, 153);
            this.QStreak.Name = "QStreak";
            this.QStreak.Size = new System.Drawing.Size(23, 25);
            this.QStreak.TabIndex = 20;
            this.QStreak.Text = "0";
            this.QStreak.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(61, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Correct in a Row:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QPercent
            // 
            this.QPercent.AutoSize = true;
            this.QPercent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QPercent.Location = new System.Drawing.Point(260, 212);
            this.QPercent.Name = "QPercent";
            this.QPercent.Size = new System.Drawing.Size(39, 25);
            this.QPercent.TabIndex = 18;
            this.QPercent.Text = "0%";
            this.QPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Correct Answers per Minute:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QCorrect
            // 
            this.QCorrect.AutoSize = true;
            this.QCorrect.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QCorrect.Location = new System.Drawing.Point(260, 120);
            this.QCorrect.Name = "QCorrect";
            this.QCorrect.Size = new System.Drawing.Size(23, 25);
            this.QCorrect.TabIndex = 16;
            this.QCorrect.Text = "0";
            this.QCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QAttempt
            // 
            this.QAttempt.AutoSize = true;
            this.QAttempt.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QAttempt.Location = new System.Drawing.Point(260, 85);
            this.QAttempt.Name = "QAttempt";
            this.QAttempt.Size = new System.Drawing.Size(23, 25);
            this.QAttempt.TabIndex = 15;
            this.QAttempt.Text = "0";
            this.QAttempt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(61, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Questions Attempted:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(61, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Correct Answers:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 51);
            this.label5.TabIndex = 13;
            this.label5.Text = "Current Streak";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Skip);
            this.Controls.Add(this.RewardText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Reward);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.QuestionList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Math Attack!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Reward)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView QuestionList;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Response;
        private System.Windows.Forms.PictureBox Reward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RewardText;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResetTimer;
        private System.Windows.Forms.Label QPerMinute;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label TimerText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label QStreak;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label QPercent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label QCorrect;
        private System.Windows.Forms.Label QAttempt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}

