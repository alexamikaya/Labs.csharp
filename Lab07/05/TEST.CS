namespace Utils
{
    using System;

    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        public static void Main() 
        {
            int aa = 65;
            string bb = "A String";
            Coordinate c = new Coordinate(21.0, 68.0);
            Utils.Display(aa);
            Utils.Display(bb);
            Utils.Display(c);
            Console.Read();
        }
    }
}
