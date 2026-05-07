class Assignment11
{
    public static void Main(string[] arg)
    {
        HashSet<char> vowelObj = new HashSet<char>()
        {
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };
        HashSet<char> specialCharObj = new HashSet<char>()
{
    '!', '@', '#', '$', '%', '^', '&', '*',
    '(', ')',
    '-', '_', '=', '+',
    '[', ']', '{', '}',
    '\\', '|',
    ';', ':',
    '\'', '"',
    ',', '.', '<', '>',
    '/', '?',
    '`', '~'
};
        int vowel = 0;
        int specialChar = 0;
        int space = 0;
        string input = "Hello World 123!!$$";
        for (int i = 0; i < input.Length; i++)
        {

            if (input[i] == ' ')
            {
                space += 1;
            }
            if (vowelObj.Contains(input[i]))
            {
                vowel += 1;
            }
            if (specialCharObj.Contains(input[i]))
            {
                specialChar += 1;
            }
        }
        Console.WriteLine($"Space: {space}");
        Console.WriteLine($"Vowel: {vowel}");
        Console.WriteLine($"SpecialChar: {specialChar}");
    }
}