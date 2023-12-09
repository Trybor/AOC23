int totalSum = 0;

string file = "input.txt";
string[] lines = File.ReadAllLines(file);

foreach (string line in lines)
{
    int[] rowValues = Array.ConvertAll(line.Split(' '), int.Parse);
    int[,] matrix = new int[line.Length, rowValues.Length];

    for (int i = 0; i < rowValues.Length; i++)
    {
        matrix[0, i] = rowValues[i];
    }

    totalSum += matrix[0, matrix.GetLength(1) - 1];
}
Console.WriteLine("Total sum of all sums: " + totalSum);