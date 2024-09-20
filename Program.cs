namespace PaperTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            List<string> subjects = new List<string> { "IT", "Math", "Physics" };
            Console.WriteLine("bro pls work!");

            Application.Run(new BaseForm(subjects));
        }
    }
}