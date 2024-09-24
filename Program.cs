using System.Text.Json;

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

            List<Subject> subjects = LoadData();
            void saveCallback() { SaveData(subjects); }

            Application.Run(new BaseForm(subjects, saveCallback));
        }

        public static List<Subject> LoadData()
        {
            string dataPath = @"data\subjects.json";
            if (File.Exists(dataPath))
            {
                try
                {
                    string jsonString = File.ReadAllText(dataPath);
                    List<Subject> loadedSubjects = JsonSerializer.Deserialize<List<Subject>>(jsonString);
                    if (loadedSubjects != null)
                    {
                        return loadedSubjects;
                    }
                    else
                    {
                        return new List<Subject>();
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Error loading the file: " + ex.Message);
                    return new List<Subject>();
                }
            }
            else
            {
                return new List<Subject>();
            }
        }

        public static void SaveData(List<Subject> subjectsToSave)
        {
            string dataPath = @"data\subjects.json";

            // Ensure the directory exists
            string directory = Path.GetDirectoryName(dataPath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string jsonString = JsonSerializer.Serialize(subjectsToSave, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(dataPath, jsonString);
        }
    }
}