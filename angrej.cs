using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TigerRace
{
    public class angrej : Punter // player
    {
        public angrej(bet MyBet, Label MaxBet, int Cash, Label MyLabel) : base(MyBet, MaxBet, Cash, MyLabel)
        {
        }

        public override void setPunterName()
        {
            Name = "angrej"; //player name 
        }
    }
}