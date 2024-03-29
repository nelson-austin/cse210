using System;
using Microsoft.VisualBasic;
using Unit05.Game.Casting;

namespace Unit05
{
    /// <summary>
    /// Constants
    /// </summary>
    public class Constants
    {
        public static int COLUMNS = 40;
        public static int ROWS = 20;
        public static int CELL_SIZE = 15;
        public static int MAX_X = 900;
        public static int MAX_Y = 600;

        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Snake";
        public static int SNAKE_LENGTH = 8;

        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);
        public static Color PLAYER_1 = new Color(255, 0, 0);
        public static Color PLAYER_2 = new Color(0, 255, 0);
        public static Point point_1 = new Point(210, 300);
        public static Point point_2 = new Point(690, 300);

    }
}