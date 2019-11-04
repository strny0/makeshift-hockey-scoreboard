namespace Hockey_scoreboard
{
    partial class ControlPanel
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
            this.components = new System.ComponentModel.Container();
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
            this.lbl_colon2 = new System.Windows.Forms.Label();
            this.lbl_colon3 = new System.Windows.Forms.Label();
            this.team1_p2_seconds = new System.Windows.Forms.Label();
            this.team1_p2_minutes = new System.Windows.Forms.Label();
            this.team1_p1_seconds = new System.Windows.Forms.Label();
            this.lbl_penalty1 = new System.Windows.Forms.Label();
            this.team1_p1_minutes = new System.Windows.Forms.Label();
            this.team1_p2 = new System.Windows.Forms.Label();
            this.lbl_player1 = new System.Windows.Forms.Label();
            this.team1_p1 = new System.Windows.Forms.Label();
            this.team2_shots = new System.Windows.Forms.Label();
            this.team1_shots = new System.Windows.Forms.Label();
            this.lbl_shots2 = new System.Windows.Forms.Label();
            this.lbl_shots1 = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.lbl_period = new System.Windows.Forms.Label();
            this.lbl_colon = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.team1_name = new System.Windows.Forms.TextBox();
            this.team2_name = new System.Windows.Forms.TextBox();
            this.team1_score_plus = new System.Windows.Forms.Button();
            this.team1_score_minus = new System.Windows.Forms.Button();
            this.team2_score_minus = new System.Windows.Forms.Button();
            this.team2_score_plus = new System.Windows.Forms.Button();
            this.team1_score = new System.Windows.Forms.Label();
            this.team2_score = new System.Windows.Forms.Label();
            this.team2_shots_minus = new System.Windows.Forms.Button();
            this.team2_shots_plus = new System.Windows.Forms.Button();
            this.team1_shots_minus = new System.Windows.Forms.Button();
            this.team1_shots_plus = new System.Windows.Forms.Button();
            this.period_minus = new System.Windows.Forms.Button();
            this.period_plus = new System.Windows.Forms.Button();
            this.updown_minutes = new System.Windows.Forms.NumericUpDown();
            this.updown_seconds = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_time_set = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start_stop_ALL = new System.Windows.Forms.Button();
            this.btn_start_stop_PERIOD = new System.Windows.Forms.Button();
            this.btn_start_stop_PENALTIES = new System.Windows.Forms.Button();
            this.btn_reset_clock = new System.Windows.Forms.Button();
            this.btn_timeout = new System.Windows.Forms.Button();
            this.btn_preset_a = new System.Windows.Forms.Button();
            this.btn_preset_b = new System.Windows.Forms.Button();
            this.btn_preset_c = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updown_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_seconds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F);
            this.label1.Location = new System.Drawing.Point(708, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 32);
            this.label1.TabIndex = 67;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(708, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 32);
            this.label2.TabIndex = 66;
            this.label2.Text = ":";
            // 
            // team2_p2_seconds
            // 
            this.team2_p2_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2_seconds.AutoSize = true;
            this.team2_p2_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2_seconds.Location = new System.Drawing.Point(737, 388);
            this.team2_p2_seconds.Name = "team2_p2_seconds";
            this.team2_p2_seconds.Size = new System.Drawing.Size(30, 32);
            this.team2_p2_seconds.TabIndex = 65;
            this.team2_p2_seconds.Text = "0";
            this.team2_p2_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p2_minutes
            // 
            this.team2_p2_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2_minutes.AutoSize = true;
            this.team2_p2_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2_minutes.Location = new System.Drawing.Point(685, 388);
            this.team2_p2_minutes.Name = "team2_p2_minutes";
            this.team2_p2_minutes.Size = new System.Drawing.Size(30, 32);
            this.team2_p2_minutes.TabIndex = 64;
            this.team2_p2_minutes.Text = "0";
            this.team2_p2_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p1_seconds
            // 
            this.team2_p1_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1_seconds.AutoSize = true;
            this.team2_p1_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1_seconds.Location = new System.Drawing.Point(737, 324);
            this.team2_p1_seconds.Name = "team2_p1_seconds";
            this.team2_p1_seconds.Size = new System.Drawing.Size(30, 32);
            this.team2_p1_seconds.TabIndex = 63;
            this.team2_p1_seconds.Text = "0";
            this.team2_p1_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_penalty2
            // 
            this.lbl_penalty2.AutoSize = true;
            this.lbl_penalty2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_penalty2.Location = new System.Drawing.Point(676, 356);
            this.lbl_penalty2.Name = "lbl_penalty2";
            this.lbl_penalty2.Size = new System.Drawing.Size(105, 32);
            this.lbl_penalty2.TabIndex = 62;
            this.lbl_penalty2.Text = "Penalty";
            // 
            // team2_p1_minutes
            // 
            this.team2_p1_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1_minutes.AutoSize = true;
            this.team2_p1_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1_minutes.Location = new System.Drawing.Point(685, 324);
            this.team2_p1_minutes.Name = "team2_p1_minutes";
            this.team2_p1_minutes.Size = new System.Drawing.Size(30, 32);
            this.team2_p1_minutes.TabIndex = 61;
            this.team2_p1_minutes.Text = "0";
            this.team2_p1_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_p2
            // 
            this.team2_p2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p2.AutoSize = true;
            this.team2_p2.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p2.Location = new System.Drawing.Point(578, 388);
            this.team2_p2.Name = "team2_p2";
            this.team2_p2.Size = new System.Drawing.Size(30, 32);
            this.team2_p2.TabIndex = 60;
            this.team2_p2.Text = "0";
            this.team2_p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_player2
            // 
            this.lbl_player2.AutoSize = true;
            this.lbl_player2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_player2.Location = new System.Drawing.Point(542, 356);
            this.lbl_player2.Name = "lbl_player2";
            this.lbl_player2.Size = new System.Drawing.Size(91, 32);
            this.lbl_player2.TabIndex = 59;
            this.lbl_player2.Text = "Player";
            // 
            // team2_p1
            // 
            this.team2_p1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_p1.AutoSize = true;
            this.team2_p1.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_p1.Location = new System.Drawing.Point(578, 324);
            this.team2_p1.Name = "team2_p1";
            this.team2_p1.Size = new System.Drawing.Size(30, 32);
            this.team2_p1.TabIndex = 58;
            this.team2_p1.Text = "0";
            this.team2_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_colon2
            // 
            this.lbl_colon2.AutoSize = true;
            this.lbl_colon2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_colon2.Location = new System.Drawing.Point(185, 388);
            this.lbl_colon2.Name = "lbl_colon2";
            this.lbl_colon2.Size = new System.Drawing.Size(23, 32);
            this.lbl_colon2.TabIndex = 57;
            this.lbl_colon2.Text = ":";
            // 
            // lbl_colon3
            // 
            this.lbl_colon3.AutoSize = true;
            this.lbl_colon3.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_colon3.Location = new System.Drawing.Point(185, 324);
            this.lbl_colon3.Name = "lbl_colon3";
            this.lbl_colon3.Size = new System.Drawing.Size(23, 32);
            this.lbl_colon3.TabIndex = 56;
            this.lbl_colon3.Text = ":";
            // 
            // team1_p2_seconds
            // 
            this.team1_p2_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2_seconds.AutoSize = true;
            this.team1_p2_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2_seconds.Location = new System.Drawing.Point(214, 388);
            this.team1_p2_seconds.Name = "team1_p2_seconds";
            this.team1_p2_seconds.Size = new System.Drawing.Size(30, 32);
            this.team1_p2_seconds.TabIndex = 55;
            this.team1_p2_seconds.Text = "0";
            this.team1_p2_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p2_minutes
            // 
            this.team1_p2_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2_minutes.AutoSize = true;
            this.team1_p2_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2_minutes.Location = new System.Drawing.Point(162, 388);
            this.team1_p2_minutes.Name = "team1_p2_minutes";
            this.team1_p2_minutes.Size = new System.Drawing.Size(30, 32);
            this.team1_p2_minutes.TabIndex = 54;
            this.team1_p2_minutes.Text = "0";
            this.team1_p2_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p1_seconds
            // 
            this.team1_p1_seconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1_seconds.AutoSize = true;
            this.team1_p1_seconds.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1_seconds.Location = new System.Drawing.Point(214, 324);
            this.team1_p1_seconds.Name = "team1_p1_seconds";
            this.team1_p1_seconds.Size = new System.Drawing.Size(30, 32);
            this.team1_p1_seconds.TabIndex = 53;
            this.team1_p1_seconds.Text = "0";
            this.team1_p1_seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_penalty1
            // 
            this.lbl_penalty1.AutoSize = true;
            this.lbl_penalty1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_penalty1.Location = new System.Drawing.Point(153, 356);
            this.lbl_penalty1.Name = "lbl_penalty1";
            this.lbl_penalty1.Size = new System.Drawing.Size(105, 32);
            this.lbl_penalty1.TabIndex = 52;
            this.lbl_penalty1.Text = "Penalty";
            // 
            // team1_p1_minutes
            // 
            this.team1_p1_minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1_minutes.AutoSize = true;
            this.team1_p1_minutes.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1_minutes.Location = new System.Drawing.Point(162, 324);
            this.team1_p1_minutes.Name = "team1_p1_minutes";
            this.team1_p1_minutes.Size = new System.Drawing.Size(30, 32);
            this.team1_p1_minutes.TabIndex = 51;
            this.team1_p1_minutes.Text = "0";
            this.team1_p1_minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_p2
            // 
            this.team1_p2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p2.AutoSize = true;
            this.team1_p2.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p2.Location = new System.Drawing.Point(55, 388);
            this.team1_p2.Name = "team1_p2";
            this.team1_p2.Size = new System.Drawing.Size(30, 32);
            this.team1_p2.TabIndex = 50;
            this.team1_p2.Text = "0";
            this.team1_p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_player1
            // 
            this.lbl_player1.AutoSize = true;
            this.lbl_player1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_player1.Location = new System.Drawing.Point(19, 356);
            this.lbl_player1.Name = "lbl_player1";
            this.lbl_player1.Size = new System.Drawing.Size(91, 32);
            this.lbl_player1.TabIndex = 49;
            this.lbl_player1.Text = "Player";
            // 
            // team1_p1
            // 
            this.team1_p1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_p1.AutoSize = true;
            this.team1_p1.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_p1.Location = new System.Drawing.Point(55, 324);
            this.team1_p1.Name = "team1_p1";
            this.team1_p1.Size = new System.Drawing.Size(30, 32);
            this.team1_p1.TabIndex = 48;
            this.team1_p1.Text = "0";
            this.team1_p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_shots
            // 
            this.team2_shots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_shots.AutoSize = true;
            this.team2_shots.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_shots.Location = new System.Drawing.Point(701, 216);
            this.team2_shots.Name = "team2_shots";
            this.team2_shots.Size = new System.Drawing.Size(30, 32);
            this.team2_shots.TabIndex = 47;
            this.team2_shots.Text = "0";
            this.team2_shots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team1_shots
            // 
            this.team1_shots.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_shots.AutoSize = true;
            this.team1_shots.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_shots.Location = new System.Drawing.Point(60, 216);
            this.team1_shots.Name = "team1_shots";
            this.team1_shots.Size = new System.Drawing.Size(30, 32);
            this.team1_shots.TabIndex = 46;
            this.team1_shots.Text = "0";
            this.team1_shots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_shots2
            // 
            this.lbl_shots2.AutoSize = true;
            this.lbl_shots2.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_shots2.Location = new System.Drawing.Point(606, 184);
            this.lbl_shots2.Name = "lbl_shots2";
            this.lbl_shots2.Size = new System.Drawing.Size(182, 32);
            this.lbl_shots2.TabIndex = 45;
            this.lbl_shots2.Text = "Shots on goal";
            // 
            // lbl_shots1
            // 
            this.lbl_shots1.AutoSize = true;
            this.lbl_shots1.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_shots1.Location = new System.Drawing.Point(10, 184);
            this.lbl_shots1.Name = "lbl_shots1";
            this.lbl_shots1.Size = new System.Drawing.Size(182, 32);
            this.lbl_shots1.TabIndex = 44;
            this.lbl_shots1.Text = "Shots on goal";
            // 
            // period
            // 
            this.period.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Arial", 20F);
            this.period.Location = new System.Drawing.Point(382, 216);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(30, 32);
            this.period.TabIndex = 43;
            this.period.Text = "0";
            this.period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_period
            // 
            this.lbl_period.AutoSize = true;
            this.lbl_period.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_period.Location = new System.Drawing.Point(351, 184);
            this.lbl_period.Name = "lbl_period";
            this.lbl_period.Size = new System.Drawing.Size(92, 32);
            this.lbl_period.TabIndex = 42;
            this.lbl_period.Text = "Period";
            // 
            // lbl_colon
            // 
            this.lbl_colon.AutoSize = true;
            this.lbl_colon.Font = new System.Drawing.Font("Arial", 32F);
            this.lbl_colon.Location = new System.Drawing.Point(231, 37);
            this.lbl_colon.Name = "lbl_colon";
            this.lbl_colon.Size = new System.Drawing.Size(34, 49);
            this.lbl_colon.TabIndex = 41;
            this.lbl_colon.Text = ":";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Arial", 32F);
            this.seconds.Location = new System.Drawing.Point(260, 37);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(106, 49);
            this.seconds.TabIndex = 40;
            this.seconds.Text = "00.0";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Arial", 32F);
            this.minutes.Location = new System.Drawing.Point(194, 37);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(46, 49);
            this.minutes.TabIndex = 39;
            this.minutes.Text = "0";
            // 
            // team1_name
            // 
            this.team1_name.Font = new System.Drawing.Font("Arial", 16F);
            this.team1_name.Location = new System.Drawing.Point(25, 31);
            this.team1_name.Name = "team1_name";
            this.team1_name.Size = new System.Drawing.Size(100, 32);
            this.team1_name.TabIndex = 68;
            this.team1_name.Text = "Team 1";
            this.team1_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.team1_name.TextChanged += new System.EventHandler(this.team1_name_TextChanged);
            // 
            // team2_name
            // 
            this.team2_name.Font = new System.Drawing.Font("Arial", 16F);
            this.team2_name.Location = new System.Drawing.Point(667, 31);
            this.team2_name.Name = "team2_name";
            this.team2_name.Size = new System.Drawing.Size(100, 32);
            this.team2_name.TabIndex = 69;
            this.team2_name.Text = "Team 2";
            this.team2_name.TextChanged += new System.EventHandler(this.team2_name_TextChanged);
            // 
            // team1_score_plus
            // 
            this.team1_score_plus.Font = new System.Drawing.Font("Arial", 16F);
            this.team1_score_plus.Location = new System.Drawing.Point(25, 108);
            this.team1_score_plus.Name = "team1_score_plus";
            this.team1_score_plus.Size = new System.Drawing.Size(46, 37);
            this.team1_score_plus.TabIndex = 72;
            this.team1_score_plus.Text = "+1";
            this.team1_score_plus.UseVisualStyleBackColor = true;
            this.team1_score_plus.Click += new System.EventHandler(this.team1_score_plus_Click);
            // 
            // team1_score_minus
            // 
            this.team1_score_minus.Font = new System.Drawing.Font("Arial", 16F);
            this.team1_score_minus.Location = new System.Drawing.Point(79, 108);
            this.team1_score_minus.Name = "team1_score_minus";
            this.team1_score_minus.Size = new System.Drawing.Size(46, 37);
            this.team1_score_minus.TabIndex = 73;
            this.team1_score_minus.Text = "-1";
            this.team1_score_minus.UseVisualStyleBackColor = true;
            this.team1_score_minus.Click += new System.EventHandler(this.team1_score_minus_Click);
            // 
            // team2_score_minus
            // 
            this.team2_score_minus.Font = new System.Drawing.Font("Arial", 16F);
            this.team2_score_minus.Location = new System.Drawing.Point(721, 108);
            this.team2_score_minus.Name = "team2_score_minus";
            this.team2_score_minus.Size = new System.Drawing.Size(46, 37);
            this.team2_score_minus.TabIndex = 75;
            this.team2_score_minus.Text = "-1";
            this.team2_score_minus.UseVisualStyleBackColor = true;
            this.team2_score_minus.Click += new System.EventHandler(this.team2_score_minus_Click);
            // 
            // team2_score_plus
            // 
            this.team2_score_plus.Font = new System.Drawing.Font("Arial", 16F);
            this.team2_score_plus.Location = new System.Drawing.Point(667, 108);
            this.team2_score_plus.Name = "team2_score_plus";
            this.team2_score_plus.Size = new System.Drawing.Size(46, 37);
            this.team2_score_plus.TabIndex = 74;
            this.team2_score_plus.Text = "+1";
            this.team2_score_plus.UseVisualStyleBackColor = true;
            this.team2_score_plus.Click += new System.EventHandler(this.team2_score_plus_Click);
            // 
            // team1_score
            // 
            this.team1_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team1_score.AutoSize = true;
            this.team1_score.Font = new System.Drawing.Font("Arial", 20F);
            this.team1_score.Location = new System.Drawing.Point(60, 66);
            this.team1_score.Name = "team1_score";
            this.team1_score.Size = new System.Drawing.Size(30, 32);
            this.team1_score.TabIndex = 76;
            this.team1_score.Text = "0";
            this.team1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_score
            // 
            this.team2_score.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.team2_score.AutoSize = true;
            this.team2_score.Font = new System.Drawing.Font("Arial", 20F);
            this.team2_score.Location = new System.Drawing.Point(702, 66);
            this.team2_score.Name = "team2_score";
            this.team2_score.Size = new System.Drawing.Size(30, 32);
            this.team2_score.TabIndex = 77;
            this.team2_score.Text = "0";
            this.team2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // team2_shots_minus
            // 
            this.team2_shots_minus.Font = new System.Drawing.Font("Arial", 16F);
            this.team2_shots_minus.Location = new System.Drawing.Point(721, 251);
            this.team2_shots_minus.Name = "team2_shots_minus";
            this.team2_shots_minus.Size = new System.Drawing.Size(46, 37);
            this.team2_shots_minus.TabIndex = 81;
            this.team2_shots_minus.Text = "-1";
            this.team2_shots_minus.UseVisualStyleBackColor = true;
            this.team2_shots_minus.Click += new System.EventHandler(this.team2_shots_minus_Click);
            // 
            // team2_shots_plus
            // 
            this.team2_shots_plus.Font = new System.Drawing.Font("Arial", 16F);
            this.team2_shots_plus.Location = new System.Drawing.Point(667, 251);
            this.team2_shots_plus.Name = "team2_shots_plus";
            this.team2_shots_plus.Size = new System.Drawing.Size(46, 37);
            this.team2_shots_plus.TabIndex = 80;
            this.team2_shots_plus.Text = "+1";
            this.team2_shots_plus.UseVisualStyleBackColor = true;
            this.team2_shots_plus.Click += new System.EventHandler(this.team2_shots_plus_Click);
            // 
            // team1_shots_minus
            // 
            this.team1_shots_minus.Font = new System.Drawing.Font("Arial", 16F);
            this.team1_shots_minus.Location = new System.Drawing.Point(79, 251);
            this.team1_shots_minus.Name = "team1_shots_minus";
            this.team1_shots_minus.Size = new System.Drawing.Size(46, 37);
            this.team1_shots_minus.TabIndex = 79;
            this.team1_shots_minus.Text = "-1";
            this.team1_shots_minus.UseVisualStyleBackColor = true;
            this.team1_shots_minus.Click += new System.EventHandler(this.team1_shots_minus_Click);
            // 
            // team1_shots_plus
            // 
            this.team1_shots_plus.Font = new System.Drawing.Font("Arial", 16F);
            this.team1_shots_plus.Location = new System.Drawing.Point(25, 251);
            this.team1_shots_plus.Name = "team1_shots_plus";
            this.team1_shots_plus.Size = new System.Drawing.Size(46, 37);
            this.team1_shots_plus.TabIndex = 78;
            this.team1_shots_plus.Text = "+1";
            this.team1_shots_plus.UseVisualStyleBackColor = true;
            this.team1_shots_plus.Click += new System.EventHandler(this.team1_shots_plus_Click);
            // 
            // period_minus
            // 
            this.period_minus.Font = new System.Drawing.Font("Arial", 16F);
            this.period_minus.Location = new System.Drawing.Point(397, 251);
            this.period_minus.Name = "period_minus";
            this.period_minus.Size = new System.Drawing.Size(46, 37);
            this.period_minus.TabIndex = 83;
            this.period_minus.Text = "-1";
            this.period_minus.UseVisualStyleBackColor = true;
            this.period_minus.Click += new System.EventHandler(this.period_minus_Click);
            // 
            // period_plus
            // 
            this.period_plus.Font = new System.Drawing.Font("Arial", 16F);
            this.period_plus.Location = new System.Drawing.Point(343, 251);
            this.period_plus.Name = "period_plus";
            this.period_plus.Size = new System.Drawing.Size(46, 37);
            this.period_plus.TabIndex = 82;
            this.period_plus.Text = "+1";
            this.period_plus.UseVisualStyleBackColor = true;
            this.period_plus.Click += new System.EventHandler(this.period_plus_Click);
            // 
            // updown_minutes
            // 
            this.updown_minutes.Font = new System.Drawing.Font("Arial", 16F);
            this.updown_minutes.Location = new System.Drawing.Point(183, 121);
            this.updown_minutes.Name = "updown_minutes";
            this.updown_minutes.Size = new System.Drawing.Size(34, 32);
            this.updown_minutes.TabIndex = 84;
            // 
            // updown_seconds
            // 
            this.updown_seconds.Font = new System.Drawing.Font("Arial", 16F);
            this.updown_seconds.Location = new System.Drawing.Point(238, 121);
            this.updown_seconds.Name = "updown_seconds";
            this.updown_seconds.Size = new System.Drawing.Size(78, 32);
            this.updown_seconds.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(216, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 86;
            this.label3.Text = ":";
            // 
            // btn_time_set
            // 
            this.btn_time_set.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_time_set.Location = new System.Drawing.Point(324, 121);
            this.btn_time_set.Name = "btn_time_set";
            this.btn_time_set.Size = new System.Drawing.Size(54, 32);
            this.btn_time_set.TabIndex = 87;
            this.btn_time_set.Text = "set";
            this.btn_time_set.UseVisualStyleBackColor = true;
            this.btn_time_set.Click += new System.EventHandler(this.btn_time_set_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start_stop_ALL
            // 
            this.btn_start_stop_ALL.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_start_stop_ALL.Location = new System.Drawing.Point(384, 11);
            this.btn_start_stop_ALL.Name = "btn_start_stop_ALL";
            this.btn_start_stop_ALL.Size = new System.Drawing.Size(75, 49);
            this.btn_start_stop_ALL.TabIndex = 88;
            this.btn_start_stop_ALL.Text = "Start all clocks";
            this.btn_start_stop_ALL.UseVisualStyleBackColor = true;
            this.btn_start_stop_ALL.Click += new System.EventHandler(this.btn_start_stop_ALL_Click);
            // 
            // btn_start_stop_PERIOD
            // 
            this.btn_start_stop_PERIOD.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_start_stop_PERIOD.Location = new System.Drawing.Point(384, 66);
            this.btn_start_stop_PERIOD.Name = "btn_start_stop_PERIOD";
            this.btn_start_stop_PERIOD.Size = new System.Drawing.Size(75, 49);
            this.btn_start_stop_PERIOD.TabIndex = 89;
            this.btn_start_stop_PERIOD.Text = "Start period clock";
            this.btn_start_stop_PERIOD.UseVisualStyleBackColor = true;
            this.btn_start_stop_PERIOD.Click += new System.EventHandler(this.btn_start_stop_PERIOD_Click);
            // 
            // btn_start_stop_PENALTIES
            // 
            this.btn_start_stop_PENALTIES.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_start_stop_PENALTIES.Location = new System.Drawing.Point(465, 11);
            this.btn_start_stop_PENALTIES.Name = "btn_start_stop_PENALTIES";
            this.btn_start_stop_PENALTIES.Size = new System.Drawing.Size(75, 49);
            this.btn_start_stop_PENALTIES.TabIndex = 90;
            this.btn_start_stop_PENALTIES.Text = "Start penalties clocks";
            this.btn_start_stop_PENALTIES.UseVisualStyleBackColor = true;
            this.btn_start_stop_PENALTIES.Click += new System.EventHandler(this.btn_start_stop_PENALTIES_Click);
            // 
            // btn_reset_clock
            // 
            this.btn_reset_clock.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_reset_clock.Location = new System.Drawing.Point(465, 66);
            this.btn_reset_clock.Name = "btn_reset_clock";
            this.btn_reset_clock.Size = new System.Drawing.Size(75, 49);
            this.btn_reset_clock.TabIndex = 91;
            this.btn_reset_clock.Text = "Reset clock";
            this.btn_reset_clock.UseVisualStyleBackColor = true;
            this.btn_reset_clock.Click += new System.EventHandler(this.btn_reset_clock_Click);
            // 
            // btn_timeout
            // 
            this.btn_timeout.Font = new System.Drawing.Font("Arial", 10F);
            this.btn_timeout.Location = new System.Drawing.Point(548, 12);
            this.btn_timeout.Name = "btn_timeout";
            this.btn_timeout.Size = new System.Drawing.Size(75, 103);
            this.btn_timeout.TabIndex = 92;
            this.btn_timeout.Text = "Timeout";
            this.btn_timeout.UseVisualStyleBackColor = true;
            this.btn_timeout.Click += new System.EventHandler(this.btn_timeout_Click);
            // 
            // btn_preset_a
            // 
            this.btn_preset_a.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_preset_a.Location = new System.Drawing.Point(384, 121);
            this.btn_preset_a.Name = "btn_preset_a";
            this.btn_preset_a.Size = new System.Drawing.Size(75, 32);
            this.btn_preset_a.TabIndex = 93;
            this.btn_preset_a.Text = "A";
            this.btn_preset_a.UseVisualStyleBackColor = true;
            this.btn_preset_a.Click += new System.EventHandler(this.btn_preset_a_Click);
            // 
            // btn_preset_b
            // 
            this.btn_preset_b.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_preset_b.Location = new System.Drawing.Point(465, 121);
            this.btn_preset_b.Name = "btn_preset_b";
            this.btn_preset_b.Size = new System.Drawing.Size(75, 32);
            this.btn_preset_b.TabIndex = 94;
            this.btn_preset_b.Text = "B";
            this.btn_preset_b.UseVisualStyleBackColor = true;
            this.btn_preset_b.Click += new System.EventHandler(this.btn_preset_b_Click);
            // 
            // btn_preset_c
            // 
            this.btn_preset_c.Font = new System.Drawing.Font("Arial", 16F);
            this.btn_preset_c.Location = new System.Drawing.Point(548, 121);
            this.btn_preset_c.Name = "btn_preset_c";
            this.btn_preset_c.Size = new System.Drawing.Size(75, 32);
            this.btn_preset_c.TabIndex = 95;
            this.btn_preset_c.Text = "C";
            this.btn_preset_c.UseVisualStyleBackColor = true;
            this.btn_preset_c.Click += new System.EventHandler(this.btn_preset_c_Click);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_preset_c);
            this.Controls.Add(this.btn_preset_b);
            this.Controls.Add(this.btn_preset_a);
            this.Controls.Add(this.btn_timeout);
            this.Controls.Add(this.btn_reset_clock);
            this.Controls.Add(this.btn_start_stop_PENALTIES);
            this.Controls.Add(this.btn_start_stop_PERIOD);
            this.Controls.Add(this.btn_start_stop_ALL);
            this.Controls.Add(this.btn_time_set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updown_seconds);
            this.Controls.Add(this.updown_minutes);
            this.Controls.Add(this.period_minus);
            this.Controls.Add(this.period_plus);
            this.Controls.Add(this.team2_shots_minus);
            this.Controls.Add(this.team2_shots_plus);
            this.Controls.Add(this.team1_shots_minus);
            this.Controls.Add(this.team1_shots_plus);
            this.Controls.Add(this.team2_score);
            this.Controls.Add(this.team1_score);
            this.Controls.Add(this.team2_score_minus);
            this.Controls.Add(this.team2_score_plus);
            this.Controls.Add(this.team1_score_minus);
            this.Controls.Add(this.team1_score_plus);
            this.Controls.Add(this.team2_name);
            this.Controls.Add(this.team1_name);
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
            this.Name = "ControlPanel";
            this.Text = "Hockey scoreboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updown_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updown_seconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lbl_colon2;
        private System.Windows.Forms.Label lbl_colon3;
        private System.Windows.Forms.Label team1_p2_seconds;
        private System.Windows.Forms.Label team1_p2_minutes;
        private System.Windows.Forms.Label team1_p1_seconds;
        private System.Windows.Forms.Label lbl_penalty1;
        private System.Windows.Forms.Label team1_p1_minutes;
        private System.Windows.Forms.Label team1_p2;
        private System.Windows.Forms.Label lbl_player1;
        private System.Windows.Forms.Label team1_p1;
        private System.Windows.Forms.Label team2_shots;
        private System.Windows.Forms.Label team1_shots;
        private System.Windows.Forms.Label lbl_shots2;
        private System.Windows.Forms.Label lbl_shots1;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label lbl_period;
        private System.Windows.Forms.Label lbl_colon;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.TextBox team1_name;
        private System.Windows.Forms.TextBox team2_name;
        private System.Windows.Forms.Button team1_score_plus;
        private System.Windows.Forms.Button team1_score_minus;
        private System.Windows.Forms.Button team2_score_minus;
        private System.Windows.Forms.Button team2_score_plus;
        private System.Windows.Forms.Label team1_score;
        private System.Windows.Forms.Label team2_score;
        private System.Windows.Forms.Button team2_shots_minus;
        private System.Windows.Forms.Button team2_shots_plus;
        private System.Windows.Forms.Button team1_shots_minus;
        private System.Windows.Forms.Button team1_shots_plus;
        private System.Windows.Forms.Button period_minus;
        private System.Windows.Forms.Button period_plus;
        private System.Windows.Forms.NumericUpDown updown_minutes;
        private System.Windows.Forms.NumericUpDown updown_seconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_time_set;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start_stop_ALL;
        private System.Windows.Forms.Button btn_start_stop_PERIOD;
        private System.Windows.Forms.Button btn_start_stop_PENALTIES;
        private System.Windows.Forms.Button btn_reset_clock;
        private System.Windows.Forms.Button btn_timeout;
        private System.Windows.Forms.Button btn_preset_a;
        private System.Windows.Forms.Button btn_preset_b;
        private System.Windows.Forms.Button btn_preset_c;
    }
}

