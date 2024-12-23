namespace AppiumMobileTestProject.Utils
{
    public class PathUtil
    {
        private const string PathToLog = @"\Log";

        public static string GetFullPathToLogs => Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + PathToLog;
    }
}
