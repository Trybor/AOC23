using System.Text.RegularExpressions;

StreamReader? reader = null;

try
{
    reader = new StreamReader("input.txt");
    string[] colorArray = { "red", "green", "blue" };
    string[] maxColorArray = { "12", "13", "14" };

    int gameCount = 0;

    while (!reader.EndOfStream)
    {
        string[] lineData = reader.ReadLine().Split(':');
        int gameId = Int32.Parse(lineData[0].Split(" ")[1]);
        string[] draws = lineData[1].Split(';');

        int[] drawnColors = new int[3];
        bool skipDrawing = false;

        // loop through draws
        for (int drawIdx = 0; drawIdx < draws.Length; drawIdx++)
        {
            if (skipDrawing) break;

            // separate the colors
            string[] colors = draws[drawIdx].Split(",");

            foreach (string color in colors)
            {
                string[] colorData = color.Split(" ");

                if (colorArray.Contains(colorData[2]))
                {
                    int colorIdx = Array.IndexOf(colorArray, colorData[2]);
                    //drawnColors[colorIdx] += Int32.Parse(colorData[1]);

                    if (Int32.Parse(colorData[1]) > drawnColors[colorIdx])
                    {
                        drawnColors[colorIdx] = Int32.Parse(colorData[1]);
                    }
                }
            }
        }

        int red = drawnColors[0];
        int green = drawnColors[1];
        int blue = drawnColors[2];

        int pow = 1;

        if (red > 0) pow = red;
        if (green > 0) pow= green;
        if (blue > 0) pow *= blue;

        gameCount += pow;
    }

    Console.WriteLine(gameCount);
}
catch (FileNotFoundException e)
{
    Console.WriteLine("No file");
}
catch (IOException)
{
    Console.WriteLine("Genral IO problem");
}
