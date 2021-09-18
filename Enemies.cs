using System.Drawing;

namespace Game
{
    class Enemies
    {
        public int x_coord;
        public int speed;
        public int y_coord;
        public int health;
        public int type;
        public Color color;
        public int dim_x;
        public int dim_y;
        public bool hit;
        public bool reached_border;
        public Enemies(int x_coord, int speed, int y_coord, int health, int type, Color color, int dim_x, int dim_y)
        {
            this.x_coord = x_coord;
            this.speed = speed;
            this.y_coord = y_coord;
            this.health = health;
            this.type = type;
            this.color = color;
            this.dim_x = dim_x;
            this.dim_y = dim_y;
            hit = false;
            reached_border = false;
        }
    }
}
