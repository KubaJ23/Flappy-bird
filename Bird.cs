using System.Drawing;

namespace Flappy_bird
{
    public class Bird
    {
        public float x;
        public float y;
        public float vy;
        public int radius;
        public Rectangle hitbox;

        public Bird(float xpos, float ypos, int radius)
        {
            hitbox = new((int)xpos - radius, (int)ypos - radius, radius * 2, radius * 2);

            x = xpos;
            y = ypos;
            this.radius = radius;
            vy = 0;
        }
        public void Move()
        {
            y += vy;
            hitbox.Y += (int)vy;
        }
        public void ChangeYspeed(int num)
        {
            vy += num;
        }
    }
}
