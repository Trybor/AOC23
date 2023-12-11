string filePath = "input.txt";

using (StreamReader reader = new StreamReader(filePath))
{
    int totalTask1 = 0;
    int totalTask2 = 0;
    int maxRed = 12;
    int maxGreen = 13;
    int maxBlue = 14;
    string line;

    while ((line = reader.ReadLine()) != null)
    {
        void task1()
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
                totalTask1 += gameId;
            }
        }
        task1();
        //----------------------------------------------------------//
        void task2()
        {
            int maximumRed = 0;
            int maximumGreen = 0;
            int maximumBlue = 0;
            var gameInfo = line.Split(':');
            var gameId = int.Parse(gameInfo[0].Split(' ')[1]);
            var rounds = gameInfo[1].Split(';', StringSplitOptions.TrimEntries);
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
                        maximumRed = Math.Max(colorCount, maximumRed);
                    }
                    else if (colorName == "blue")
                    {
                        maximumBlue = Math.Max(colorCount, maximumBlue);
                    }
                    else if (colorName == "green")
                    {
                        maximumGreen = Math.Max(colorCount, maximumGreen);
                    }
                }
            }
            var lineResult = maximumRed * maximumBlue * maximumGreen;
            totalTask2 += lineResult;
        }
        task2();
    }
    System.Console.WriteLine("Task 1: " + totalTask1);
    System.Console.WriteLine("Task 2: " + totalTask2);
}