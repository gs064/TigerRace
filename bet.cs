using System;

namespace TigerRace
{
    public class bet // bet class
    {
        public int Amount;
        public int TigerNum;
        public Punter Bettor;

        public bet(int Amount, int TNum, Punter Bettor)
        {
            this.Amount = Amount;
            this.TigerNum = TNum;
            this.Bettor = Bettor;
        }

        public string GetDescription() // show message
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on Tiger {2}",
                    Bettor.Name, Amount, TigerNum);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets",
                    Bettor.Name);
            }
            return description;
        }

        public int Pay(int Winner) // winner
        {
            if (TigerNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
