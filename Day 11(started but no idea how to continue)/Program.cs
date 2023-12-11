string filePath = "input.txt";

using (StreamReader reader = new StreamReader(filePath))
{
    string? line;
    int rows = 0;
    
    while ((line = reader.ReadLine()) != null)
    {
        int columns = 0;
        var symbols = line.ToCharArray();

        for (int i = 0; i < symbols.Length; i++)
        {
            var symbol = symbols[i];
            if (symbol == '#')
            {
                System.Console.WriteLine($"Row: {rows}, Column: {i}");
            }
        }
        rows++;
    }
}