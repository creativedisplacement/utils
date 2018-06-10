namespace Utils.Utilities
{
    public static class BooleanUtilities
    {
        public static bool BoolsDiffer(bool value1, bool value2)
        {
            return !Equals(value1, value2);
        }
    }
}