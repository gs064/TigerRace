using System;
using System.Windows.Forms;

namespace TigerRace
{
    public abstract class Punter // punter class 
    {
        public string Name;
        public bet bet;
        public int Cash;
        public bool busted;
        public Label statusLabel, MaxBet;

        public Punter(bet bet, Label MaxBet, int Cash, Label statusLabel)
        {
            this.bet = bet;
            this.Cash = Cash;
            this.MaxBet = MaxBet;
            this.statusLabel = statusLabel;
          
              

        }

        public void UpdateLabels()
        {
            if (bet == null)
            {
                statusLabel.Text = String.Format("{0} hasn't placed any bets", Name);
            }

            else
            {
                statusLabel.Text = bet.GetDescription(); // get notification when player place bet 
            }
            if (Cash == 0)
            {
                busted = true;
                statusLabel.Text = String.Format("BUSTED!");
                statusLabel.ForeColor = System.Drawing.Color.Red;

            }
            MaxBet.Text = String.Format("Max Bet: ${0}", Cash);
        }


        public void ClearBet() // clear bet after finish the game 
        {
            bet.Amount = 0;
        }

        public bool PlaceBet(int Amount, int Tiger) // place bet 
        {
            if (Amount <= Cash)
            {
                bet = new bet(Amount, Tiger, this);
                return true;
            }
            return false;
        }

        public void Collect(int Winner) // winner 
        {
            Cash += bet.Pay(Winner);
        }

        public abstract void setPunterName(); //abstract class set function 
    }
}
