using Chess.Pieces;

namespace Chess
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //string huhuhuuh = Console.ReadLine();
            //Application.Run(new ChessBoardForm(huhuhuuh));
            Application.Run(new MainMenuForm());
        }
    }
}