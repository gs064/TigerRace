using System;

using System.Windows.Forms;

namespace TigerRace
{
    public partial class Form1 : Form
    {

        Tiger[] Tigers = new Tiger[4];

        Factory pFactory = new Factory();
        Punter[] punters = new Punter[3];

        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Tiger.StartPosition1 = Tiger1.Right - Track.Left;
            Tiger.trackLength1 = Track.Size.Width - 35; // race track length

            Tigers[0] = new Tiger() { TigerPictureBox = Tiger1 };
            Tigers[1] = new Tiger() { TigerPictureBox = Tiger2 };
            Tigers[2] = new Tiger() { TigerPictureBox = Tiger3 };
            Tigers[3] = new Tiger() { TigerPictureBox = Tiger4 };

            punters[0] = pFactory.getPunter("gurpartap", MaximumBet, GurpartapBet);
            punters[1] = pFactory.getPunter("angrej", MaximumBet, AngrejBet); 
            punters[2] = pFactory.getPunter("sahib", MaximumBet, SahibBet); 


            foreach (Punter punter in punters)
            {
                punter.UpdateLabels();
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PlaceBet_Click(object sender, EventArgs e) // placdebet 
        {

            int PunterNum = 0;

            if (btnGurPartap.Checked)
            {
                PunterNum = 0;
            }
            if (btnAngrej.Checked)
            {
                PunterNum = 1;
            }
            if (btnSahib.Checked)
            {
                PunterNum = 2;
            }

            punters[PunterNum].PlaceBet((int)BettingAmount.Value, (int)TigerNumber.Value);
            punters[PunterNum].UpdateLabels();
        }

        private void Start_Click(object sender, EventArgs e) // start race 
        {

            bool NoWinner = true;
            int winner;
            Start.Enabled = false; //disable start  button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Tigers.Length; i++)
                {
                    if (Tiger.Run(Tigers[i]))
                    {
                        winner = i + 1;
                        NoWinner = false;
                        MessageBox.Show("Winner - Tiger " + winner);
                        foreach (Punter punter in punters)
                        {
                            if (punter.bet != null)
                            {
                                punter.Collect(winner); //winner
                                punter.bet = null;
                                punter.UpdateLabels();
                            }
                        }
                        foreach (Tiger Tiger in Tigers)
                        {
                            Tiger.TakeStartPosition();
                        }
                        break;
                    }
                }
            }
            if (punters[0].busted && punters[1].busted && punters[2].busted)
            {  
                String message = "Do you want to Play Again?";
                String title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    this.Close();
                }

            }
            Start.Enabled = true; //enable race button 
        }

        private void btnGurPartap_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[0].Cash);
        }

        private void btnAngrej_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[1].Cash);
        }

        private void btnSahib_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(punters[2].Cash);
        }
        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = String.Format("Maximum Bet: ${0}", Cash);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GurpartapBet_Click(object sender, EventArgs e)
        {

        }
    }
}
