using System;
using System.Drawing;
using System.Windows.Forms;

namespace TigerRace
{
    public class Tiger // tiger class 
    {
        private static int StartPosition;
        private static int trackLength;
        public PictureBox TigerPictureBox = null;
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object 

        public static int StartPosition1 { get => StartPosition; set => StartPosition = value; }
        public static int trackLength1 { get => trackLength; set => trackLength = value; }

       

        public static bool Run(Tiger obj)
        {
            int distance = MyRandom.Next(2, 8);
            if (obj.TigerPictureBox != null)
                obj.MovePictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (trackLength1 - StartPosition1))
            {
                return true;
            }
            return false;
        }

        public void TakeStartPosition()
        {
            MovePictureBox(-Location); //reset location 
            Location = 0;

        }

        public void MovePictureBox(int distance)
        {
            Point p = TigerPictureBox.Location;
            p.X += distance;
            TigerPictureBox.Location = p; //move tigers
        }
    }
}
