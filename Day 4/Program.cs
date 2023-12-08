using System.Globalization;

string[] lines = File.ReadAllLines("input.txt");

CalculateWinningNumbers();

void CalculateWinningNumbers()
{
    int totalSum = 0;
    for (int i = 0; i < lines.Length; i++)
    {
        string[] line = lines[i].Split(':');
        string[] winningNumbers = line[1].Split('|')[0].Split();
        string[] checkNumbers = line[1].Split('|')[1].Split();
        int sum = 0;

        foreach (var checkNumber in checkNumbers)
        {
            foreach (var winningNumber in winningNumbers)
            {
                int num = 0;
                int win = 0;
                if (int.TryParse(checkNumber, out num) && int.TryParse(winningNumber, out win))
                {
                    if (num == win)
                    {
                        if (sum == 0)
                        {
                            sum = 1;
                        }
                        else
                        {
                            sum *= 2;
                        }
                    }
                }
            }
        }
        totalSum += sum;
        System.Console.WriteLine("This is the sum of the line " + i + ": " + sum);

    }
    System.Console.WriteLine("This is the total winning numbers: " + totalSum);
}