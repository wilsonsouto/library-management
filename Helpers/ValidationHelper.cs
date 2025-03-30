namespace LibraryManagement.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidateString(string input) => input.Length is >= 4 and <= 20;
    }
}
