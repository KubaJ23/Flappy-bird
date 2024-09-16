using System.Drawing;

namespace Flappy_bird
{
    public class Pillar
    {
        public Rectangle top_boundary;
        public Rectangle middle_boundary;
        public Rectangle bottom_boundary;

        public Pillar(int x, int y, int gapwidth, int gapheight)
        {
            middle_boundary = new Rectangle(x, y, gapwidth, gapheight);

            top_boundary = new Rectangle(x, y-800, gapwidth, 800);
            bottom_boundary = new Rectangle(x, y+gapheight, gapwidth, 800);
        }
        public void MovePillar(int speed)
        {
            middle_boundary.X -= speed;

            top_boundary.X -= speed;
            bottom_boundary.X -= speed;
        }
        public void TranslatePillarX(int amount)
        {
           
        }
    }
}
