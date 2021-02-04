using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigerRace
{
    public class sahib : Punter // player 
    {
        public sahib(bet MyBet, Label MaxBet, int Cash, Label MyLabel) : base(MyBet, MaxBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "sahib"; // player name 
        }
    }
}
