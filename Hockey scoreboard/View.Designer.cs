namespace Hockey_scoreboard
{
    partial class View
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
            this.team1_name = new System.Windows.Forms.Label();
            this.team2_name = new System.Windows.Forms.Label();
            this.team2_score = new System.Windows.Forms.Label();
            this.team1_score = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.lbl_colon = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.lbl_period = new System.Windows.Forms.Label();
            this.team2_shots = new System.Windows.Forms.Label();
            this.team1_shots = new System.Windows.Forms.Label();
            this.lbl_shots2 = new System.Windows.Forms.Label();
            this.lbl_shots1 = new System.Windows.Forms.Label();
            this.team1_p1 = new System.Windows.Forms.Label();
            this.team1_p2 = new System.Windows.Forms.Label();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.lbl_penalty1 = new System.Windows.Forms.Label();
            this.team1_p1_minutes = new System.Windows.Forms.Label();
            this.team1_p1_seconds = new System.Windows.Forms.Label();
            this.team1_p2_seconds = new System.Windows.Forms.Label();
            this.team1_p2_minutes = new System.Windows.Forms.Label();
            this.lbl_colon3 = new System.Windows.Forms.Label();
            this.lbl_colon2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.team2_p2_seconds = new System.Windows.Forms.Label();
            this.team2_p2_minutes = new System.Windows.Forms.Label();
            this.team2_p1_seconds = new System.Windows.Forms.Label();
            this.lbl_penalty2 = new System.Windows.Forms.Label();
            this.team2_p1_minutes = new System.Windows.Forms.Label();
            this.team2_p2 = new System.Windows.Forms.Label();
            this.lbl_player2 = new System.Windows.Forms.Label();
            this.team2_p1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // team1_name
            // 
            this.team1_name.AutoSize = true;
            this.team1_name.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_name.Location = new System.Drawing.Point(12, 9);
            this.team1_name.Name = "team1_name";
            this.team1_name.Size = new System.Drawing.Size(103, 32);
            this.team1_name.TabIndex = 0;
            this.team1_name.Text = "Team 1";
            // 
            // team2_name
            // 
            this.team2_name.AutoSize = true;
            this.team2_name.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_name.Location = new System.Drawing.Point(666, 9);
            this.team2_name.Name = "team2_name";
            this.team2_name.Size = new System.Drawing.Size(103, 32);
            this.team2_name.TabIndex = 1;
            this.team2_name.Text = "Team 2";
            // 
            // team2_score
            // 
            this.team2_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_score.AutoSize = true;
            this.team2_score.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_score.Location = new System.Drawing.Point(703, 41);
            this.team2_score.Name = "team2_score";
            this.team2_score.Size = new System.Drawing.Size(30, 32);
            this.team2_score.TabIndex = 3;
            this.team2_score.Text = "0";
            this.team2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_score
            // 
            this.team1_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_score.AutoSize = true;
            this.team1_score.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_score.Location = new System.Drawing.Point(48, 41);
            this.team1_score.Name = "team1_score";
            this.team1_score.Size = new System.Drawing.Size(30, 32);
            this.team1_score.TabIndex = 2;
            this.team1_score.Text = "0";
            this.team1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.minutes.Location = new System.Drawing.Point(326, 9);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(30, 32);
            this.minutes.TabIndex = 4;
            this.minutes.Text = "0";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.seconds.Location = new System.Drawing.Point(393, 9);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(68, 32);
            this.seconds.TabIndex = 5;
            this.seconds.Text = "00.0";
            // 
            // lbl_colon
            // 
            this.lbl_colon.AutoSize = true;
            this.lbl_colon.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_colon.Location = new System.Drawing.Point(363, 9);
            this.lbl_colon.Name = "lbl_colon";
            this.lbl_colon.Size = new System.Drawing.Size(23, 32);
            this.lbl_colon.TabIndex = 6;
            this.lbl_colon.Text = ":";
            // 
            // period
            // 
            this.period.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Arial", 20F);
            this.period.Location = new System.Drawing.Point(370, 113);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(30, 32);
            this.period.TabIndex = 8;
            this.period.Text = "0";
            this.period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_period.Location = new System.Drawing.Point(339, 81);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(92, 32);
            this.lbl_period.TabIndex = 7;
            this.lbl_period.Text = "Period";
            // 
            // team2_shots
            // 
            this.team2_shots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_shots.AutoSize = true;
            this.team2_shots.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_shots.Location = new System.Drawing.Point(666, 194);
            this.team2_shots.Name = "team2_shots";
            this.team2_shots.Size = new System.Drawing.Size(30, 32);
            this.team2_shots.TabIndex = 12;
            this.team2_shots.Text = "0";
            this.team2_shots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_shots
            // 
            this.team1_shots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_shots.AutoSize = true;
            this.team1_shots.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_shots.Location = new System.Drawing.Point(88, 194);
            this.team1_shots.Name = "team1_shots";
            this.team1_shots.Size = new System.Drawing.Size(30, 32);
            this.team1_shots.TabIndex = 11;
            this.team1_shots.Text = "0";
            this.team1_shots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_shots2
            // 
            this.lbl_shots2.AutoSize = true;
            this.lbl_shots2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_shots2.Location = new System.Drawing.Point(590, 162);
            this.lbl_shots2.Name = "lbl_shots2";
            this.lbl_shots2.Size = new System.Drawing.Size(182, 32);
            this.lbl_shots2.TabIndex = 10;
            this.lbl_shots2.Text = "Shots on goal";
            // 
            // lbl_shots1
            // 
            this.lbl_shots1.AutoSize = true;
            this.lbl_shots1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_shots1.Location = new System.Drawing.Point(12, 162);
            this.lbl_shots1.Name = "lbl_shots1";
            this.lbl_shots1.Size = new System.Drawing.Size(182, 32);
            this.lbl_shots1.TabIndex = 9;
            this.lbl_shots1.Text = "Shots on goal";
            // 
            // team1_p1
            // 
            this.team1_p1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1.AutoSize = true;
            this.team1_p1.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1.Location = new System.Drawing.Point(48, 302);
            this.team1_p1.Name = "team1_p1";
            this.team1_p1.Size = new System.Drawing.Size(30, 32);
            this.team1_p1.TabIndex = 14;
            this.team1_p1.Text = "0";
            this.team1_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p2
            // 
            this.team1_p2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2.AutoSize = true;
            this.team1_p2.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2.Location = new System.Drawing.Point(48, 366);
            this.team1_p2.Name = "team1_p2";
            this.team1_p2.Size = new System.Drawing.Size(30, 32);
            this.team1_p2.TabIndex = 16;
            this.team1_p2.Text = "0";
            this.team1_p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_player1.Location = new System.Drawing.Point(12, 334);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(91, 32);
            this.lbl_player1.TabIndex = 15;
            this.lbl_player1.Text = "Player";
            // 
            // lbl_penalty1
            // 
            this.lbl_penalty1.AutoSize = true;
            this.lbl_penalty1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_penalty1.Location = new System.Drawing.Point(146, 334);
            this.lbl_penalty1.Name = "lbl_penalty1";
            this.lbl_penalty1.Size = new System.Drawing.Size(105, 32);
            this.lbl_penalty1.TabIndex = 18;
            this.lbl_penalty1.Text = "Penalty";
            // 
            // team1_p1_minutes
            // 
            this.team1_p1_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1_minutes.AutoSize = true;
            this.team1_p1_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1_minutes.Location = new System.Drawing.Point(155, 302);
            this.team1_p1_minutes.Name = "team1_p1_minutes";
            this.team1_p1_minutes.Size = new System.Drawing.Size(30, 32);
            this.team1_p1_minutes.TabIndex = 17;
            this.team1_p1_minutes.Text = "0";
            this.team1_p1_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p1_seconds
            // 
            this.team1_p1_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1_seconds.AutoSize = true;
            this.team1_p1_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1_seconds.Location = new System.Drawing.Point(207, 302);
            this.team1_p1_seconds.Name = "team1_p1_seconds";
            this.team1_p1_seconds.Size = new System.Drawing.Size(30, 32);
            this.team1_p1_seconds.TabIndex = 20;
            this.team1_p1_seconds.Text = "0";
            this.team1_p1_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p2_seconds
            // 
            this.team1_p2_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2_seconds.AutoSize = true;
            this.team1_p2_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2_seconds.Location = new System.Drawing.Point(207, 366);
            this.team1_p2_seconds.Name = "team1_p2_seconds";
            this.team1_p2_seconds.Size = new System.Drawing.Size(30, 32);
            this.team1_p2_seconds.TabIndex = 22;
            this.team1_p2_seconds.Text = "0";
            this.team1_p2_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p2_minutes
            // 
            this.team1_p2_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2_minutes.AutoSize = true;
            this.team1_p2_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2_minutes.Location = new System.Drawing.Point(155, 366);
            this.team1_p2_minutes.Name = "team1_p2_minutes";
            this.team1_p2_minutes.Size = new System.Drawing.Size(30, 32);
            this.team1_p2_minutes.TabIndex = 21;
            this.team1_p2_minutes.Text = "0";
            this.team1_p2_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_colon3
            // 
            this.lbl_colon3.AutoSize = true;
            this.lbl_colon3.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_colon3.Location = new System.Drawing.Point(178, 302);
            this.lbl_colon3.Name = "lbl_colon3";
            this.lbl_colon3.Size = new System.Drawing.Size(23, 32);
            this.lbl_colon3.TabIndex = 23;
            this.lbl_colon3.Text = ":";
            // 
            // lbl_colon2
            // 
            this.lbl_colon2.AutoSize = true;
            this.lbl_colon2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_colon2.Location = new System.Drawing.Point(178, 366);
            this.lbl_colon2.Name = "lbl_colon2";
            this.lbl_colon2.Size = new System.Drawing.Size(23, 32);
            this.lbl_colon2.TabIndex = 24;
            this.lbl_colon2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(701, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 32);
            this.label1.TabIndex = 34;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(701, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = ":";
            // 
            // team2_p2_seconds
            // 
            this.team2_p2_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2_seconds.AutoSize = true;
            this.team2_p2_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2_seconds.Location = new System.Drawing.Point(730, 366);
            this.team2_p2_seconds.Name = "team2_p2_seconds";
            this.team2_p2_seconds.Size = new System.Drawing.Size(30, 32);
            this.team2_p2_seconds.TabIndex = 32;
            this.team2_p2_seconds.Text = "0";
            this.team2_p2_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p2_minutes
            // 
            this.team2_p2_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2_minutes.AutoSize = true;
            this.team2_p2_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2_minutes.Location = new System.Drawing.Point(678, 366);
            this.team2_p2_minutes.Name = "team2_p2_minutes";
            this.team2_p2_minutes.Size = new System.Drawing.Size(30, 32);
            this.team2_p2_minutes.TabIndex = 31;
            this.team2_p2_minutes.Text = "0";
            this.team2_p2_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p1_seconds
            // 
            this.team2_p1_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1_seconds.AutoSize = true;
            this.team2_p1_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1_seconds.Location = new System.Drawing.Point(730, 302);
            this.team2_p1_seconds.Name = "team2_p1_seconds";
            this.team2_p1_seconds.Size = new System.Drawing.Size(30, 32);
            this.team2_p1_seconds.TabIndex = 30;
            this.team2_p1_seconds.Text = "0";
            this.team2_p1_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_penalty2
            // 
            this.lbl_penalty2.AutoSize = true;
            this.lbl_penalty2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_penalty2.Location = new System.Drawing.Point(669, 334);
            this.lbl_penalty2.Name = "lbl_penalty2";
            this.lbl_penalty2.Size = new System.Drawing.Size(105, 32);
            this.lbl_penalty2.TabIndex = 29;
            this.lbl_penalty2.Text = "Penalty";
            // 
            // team2_p1_minutes
            // 
            this.team2_p1_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1_minutes.AutoSize = true;
            this.team2_p1_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1_minutes.Location = new System.Drawing.Point(678, 302);
            this.team2_p1_minutes.Name = "team2_p1_minutes";
            this.team2_p1_minutes.Size = new System.Drawing.Size(30, 32);
            this.team2_p1_minutes.TabIndex = 28;
            this.team2_p1_minutes.Text = "0";
            this.team2_p1_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p2
            // 
            this.team2_p2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2.AutoSize = true;
            this.team2_p2.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2.Location = new System.Drawing.Point(571, 366);
            this.team2_p2.Name = "team2_p2";
            this.team2_p2.Size = new System.Drawing.Size(30, 32);
            this.team2_p2.TabIndex = 27;
            this.team2_p2.Text = "0";
            this.team2_p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_player2.Location = new System.Drawing.Point(535, 334);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(91, 32);
            this.lbl_player2.TabIndex = 26;
            this.lbl_player2.Text = "Player";
            // 
            // team2_p1
            // 
            this.team2_p1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1.AutoSize = true;
            this.team2_p1.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1.Location = new System.Drawing.Point(571, 302);
            this.team2_p1.Name = "team2_p1";
            this.team2_p1.Size = new System.Drawing.Size(30, 32);
            this.team2_p1.TabIndex = 25;
            this.team2_p1.Text = "0";
            this.team2_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.team2_p2_seconds);
            this.Controls.Add(this.team2_p2_minutes);
            this.Controls.Add(this.team2_p1_seconds);
            this.Controls.Add(this.lbl_penalty2);
            this.Controls.Add(this.team2_p1_minutes);
            this.Controls.Add(this.team2_p2);
            this.Controls.Add(this.lbl_player2);
            this.Controls.Add(this.team2_p1);
            this.Controls.Add(this.lbl_colon2);
            this.Controls.Add(this.lbl_colon3);
            this.Controls.Add(this.team1_p2_seconds);
            this.Controls.Add(this.team1_p2_minutes);
            this.Controls.Add(this.team1_p1_seconds);
            this.Controls.Add(this.lbl_penalty1);
            this.Controls.Add(this.team1_p1_minutes);
            this.Controls.Add(this.team1_p2);
            this.Controls.Add(this.lbl_player1);
            this.Controls.Add(this.team1_p1);
            this.Controls.Add(this.team2_shots);
            this.Controls.Add(this.team1_shots);
            this.Controls.Add(this.lbl_shots2);
            this.Controls.Add(this.lbl_shots1);
            this.Controls.Add(this.period);
            this.Controls.Add(this.lbl_period);
            this.Controls.Add(this.lbl_colon);
            this.Controls.Add(this.seconds);
            this.Controls.Add(this.minutes);
            this.Controls.Add(this.team2_score);
            this.Controls.Add(this.team1_score);
            this.Controls.Add(this.team2_name);
            this.Controls.Add(this.team1_name);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label team1_name;
        private System.Windows.Forms.Label team2_name;
        private System.Windows.Forms.Label team2_score;
        private System.Windows.Forms.Label team1_score;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label lbl_colon;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Label team2_shots;
        private System.Windows.Forms.Label team1_shots;
        private System.Windows.Forms.Label lbl_shots2;
        private System.Windows.Forms.Label lbl_shots1;
        private System.Windows.Forms.Label team1_p1;
        private System.Windows.Forms.Label team1_p2;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label lbl_penalty1;
        private System.Windows.Forms.Label team1_p1_minutes;
        private System.Windows.Forms.Label team1_p1_seconds;
        private System.Windows.Forms.Label team1_p2_seconds;
        private System.Windows.Forms.Label team1_p2_minutes;
        private System.Windows.Forms.Label lbl_colon3;
        private System.Windows.Forms.Label lbl_colon2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label team2_p2_seconds;
        private System.Windows.Forms.Label team2_p2_minutes;
        private System.Windows.Forms.Label team2_p1_seconds;
        private System.Windows.Forms.Label lbl_penalty2;
        private System.Windows.Forms.Label team2_p1_minutes;
        private System.Windows.Forms.Label team2_p2;
        private System.Windows.Forms.Label lbl_player2;
        private System.Windows.Forms.Label team2_p1;
    }
}