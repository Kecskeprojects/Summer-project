using System.Drawing;

namespace Game
{
    class Enemies
    {
        public int x_coord;
        public int speed;
        public int y_coord;
        public int health;
        public Color color;
        public int type;
        public bool hit;
        public bool reached_border;
        public Enemies(int x_coord, int speed, int y_coord, int health, int type, Color color)
        {
            this.x_coord = x_coord;
            this.speed = speed;
            this.y_coord = y_coord;
            this.health = health;
            this.type = type;
            this.color = color;
            this.hit = false;
            this.reached_border = false;
        }
    }
}
