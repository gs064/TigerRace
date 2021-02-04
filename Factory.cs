using System;
using System.Windows.Forms;

namespace TigerRace

{
    public class Factory // factory class 
    {
        public Punter getPunter(String Name, Label MaxBet, Label bet)
        {
            Punter p;
            switch (Name.ToLower())
            {
                case "gurpartap":
                    p = new gurpartap(null, MaxBet, 50, bet);
                    break;

                case "angrej":
                    p = new angrej(null, MaxBet, 50, bet);
                    break;

                case "sahib":
                    p = new sahib(null, MaxBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            p.setPunterName();
            return p;
        }
    }
}
