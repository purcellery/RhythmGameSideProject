using System;

namespace TitlePending
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TitlePending())
                game.Run();
        }
    }
}
