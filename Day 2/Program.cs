int runningTotal = 0;
int maxRed = 12;
int maxGreen = 13;
int maxBlue = 14;

string filePath = "input.txt";

using (StreamReader reader = new StreamReader(filePath))
{
    string line;

    while ((line = reader.ReadLine()) != null)
    {
        var gameInfo = line.Split(':');
        var gameId = int.Parse(gameInfo[0].Split(' ')[1]);
        var rounds = gameInfo[1].Split(';', StringSplitOptions.TrimEntries);
        bool isGameValid = true;
        foreach (var round in rounds)
        {
            var colorInfos = round.Split(',', StringSplitOptions.TrimEntries);
            foreach (var color in colorInfos)
            {
                var colorInfo = color.Split(' ');
                int colorCount = int.Parse(colorInfo[0]);
                string colorName = colorInfo[1];
                if (colorName == "red")
                {
                    if (colorCount > maxRed)
                    {
                        isGameValid = false;
                    }
                }
                else if (colorName == "blue")
                {
                    if (colorCount > maxBlue)
                    {
                        isGameValid = false;
                    }
                }
                else if (colorName == "green")
                {
                    if (colorCount > maxGreen)
                    {
                        isGameValid = false;
                    }
                }
            }
        }
        if (isGameValid)
        {
            runningTotal += gameId;
        }
    }
}

System.Console.WriteLine(runningTotal);