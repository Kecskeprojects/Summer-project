namespace Game
{
    class Arrows
    {
        public float arr_x_coord;
        public float arr_x_speed;
        public float arr_y_coord;
        public float arr_y_speed;
        public int steps_taken;
        public int steps_total;
        public bool hit;
        public Arrows(float arr_x_coord, float arr_x_speed, float arr_y_coord, float arr_y_speed, int steps_total)
        {
            this.arr_x_coord = arr_x_coord;
            this.arr_x_speed = arr_x_speed;
            this.arr_y_coord = arr_y_coord;
            this.arr_y_speed = arr_y_speed;
            this.steps_total = steps_total;
            this.steps_taken = 0;
            this.hit = false;
        }
    }
}
