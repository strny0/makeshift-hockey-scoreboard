using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hockey_scoreboard
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form View = new View(); // starts the view panel
            View.ShowDialog();
            // On start, reset variables
            global.team1_name = "Team 1";
            global.team2_name = "Team 2";
            global.team1_score = 0;
            global.team2_score = 0;
            global.minutes = 0;
            global.seconds = 0.0;
            global.team1_shots = 0;
            global.team2_shots = 0;
            global.period = 1;
            global.team1_p1 = String.Empty;
            global.team1_p2 = String.Empty;
            global.team2_p1 = String.Empty;
            global.team2_p2 = String.Empty;
            global.team1_p1_minutes = 0;
            global.team1_p1_seconds = 0;
            global.team1_p2_minutes = 0;
            global.team1_p2_seconds = 0;
            global.team2_p1_minutes = 0;
            global.team2_p1_seconds = 0;
            global.team2_p2_minutes = 0;
            global.team2_p2_seconds = 0;
    }
        // LOCAL GLOBAL VARIABLES
        bool PERIODrunning = false;
        bool PENALTIESrunning = false;


        private void team1_score_plus_Click(object sender, EventArgs e)  // SCORE MANAGEMENT
        {
            
            global.team1_score++;
            team1_score.Text = global.team1_score.ToString();
        }

        private void team1_score_minus_Click(object sender, EventArgs e)
        {
            global.team1_score--;
            team1_score.Text = global.team1_score.ToString();
        }

        private void team2_score_plus_Click(object sender, EventArgs e)
        {
            global.team2_score++;
            team2_score.Text = global.team2_score.ToString();
        }

        private void team2_score_minus_Click(object sender, EventArgs e)
        {
            global.team2_score--;
            team2_score.Text = global.team2_score.ToString();
        }                                                                   // END OF SCORE MANAGEMENT

        private void team1_name_TextChanged(object sender, EventArgs e)  // TEAM NAME MANAGEMENT
        {
            global.team1_name = team1_name.Text;
        }

        private void team2_name_TextChanged(object sender, EventArgs e)
        {
            global.team2_name = team2_name.Text;
        }                                                               // END OF TEAM NAME MANAGEMENT


        private void team1_shots_plus_Click(object sender, EventArgs e)  // SHOTS MANAGEMENT
        {
            global.team1_shots++;
            team1_shots.Text = global.team1_shots.ToString();
        }

        private void team1_shots_minus_Click(object sender, EventArgs e)
        {
            global.team1_shots--;
            team1_shots.Text = global.team1_shots.ToString();
        }

        private void team2_shots_plus_Click(object sender, EventArgs e)
        {
            global.team2_shots++;
            team2_shots.Text = global.team2_shots.ToString();
        }

        private void team2_shots_minus_Click(object sender, EventArgs e)
        {
            global.team2_shots--;
            team2_shots.Text = global.team2_shots.ToString();
        }                                                               // END OF SHOTS MANAGEMENT

        private void period_plus_Click(object sender, EventArgs e)      // PERIOD MANAGEMENT
        {
            global.period++;
            period.Text = global.period.ToString();
        }

        private void period_minus_Click(object sender, EventArgs e)
        {
            global.period--;
            period.Text = global.period.ToString();
        }                                                               // PERIOD MANAGEMENT

        private void btn_reset_clock_Click(object sender, EventArgs e)  // TIMER MANAGEMENT
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void btn_start_stop_ALL_Click(object sender, EventArgs e)
        {
            if (btn_start_stop_ALL.Text == "Start all clocks")
            {
                btn_start_stop_ALL.Text = "Stop all clocks";
                btn_start_stop_PERIOD.Text = "Stop period clock";
                btn_start_stop_PENALTIES.Text = "Stop penalties clocks";
                PERIODrunning = true;
                PENALTIESrunning = true;
                timer1.Enabled = true;
            }
            else if (btn_start_stop_ALL.Text == "Stop all clocks")
            {
                btn_start_stop_ALL.Text = "Start all clocks";
                btn_start_stop_PERIOD.Text = "Start period clock";
                btn_start_stop_PENALTIES.Text = "Start penalties clocks";
                PERIODrunning = false;
                PENALTIESrunning = false;
                timer1.Enabled = false;
            }
            
        }

        private void btn_start_stop_PERIOD_Click(object sender, EventArgs e)
        {

        }

        private void btn_start_stop_PENALTIES_Click(object sender, EventArgs e)
        {

        }

        private void btn_timeout_Click(object sender, EventArgs e)
        {

        }

        private void btn_preset_a_Click(object sender, EventArgs e)  // CUSTOM PRESET TIMES
        {

        }

        private void btn_preset_b_Click(object sender, EventArgs e)
        {

        }

        private void btn_preset_c_Click(object sender, EventArgs e)
        {

        }                                                               // END OF CUSTOM PRESET TIMES

        private void btn_time_set_Click(object sender, EventArgs e)
        {

        }                                                               // TIMER MANAGEMENT END


    }                                                                       
}
