using System.Globalization;

namespace CsvTablePresenterProject.Utility
{
    public static class UtilityBundle
    {
        public static string Capitalize(string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text);
        }
    }
}
