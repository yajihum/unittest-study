namespace HelloXUnit
{
    public static class Calculator
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static bool IsOdd(int value) => value % 2 == 1;
    }

    public static class Files
    {
        public static bool DeleteIfExist(string file)
        {
            if (!File.Exists(file))
            {
                return false;
            }

            File.Delete(file);
            return true;

        }

        public static async Task<string> ReadAllTextAsync(string file)
        {
            using (var reader = new StreamReader(File.OpenRead(file)))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
