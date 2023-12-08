using (StreamReader reader = new StreamReader("input.txt"))
{

    List<string> inputList = new List<string>();
    while (!reader.EndOfStream)
    {
        inputList.Add(reader.ReadLine());
    }

    List<int> solutionArray = new List<int>();
    int solution = 0;

    foreach (var line in inputList)
    {
        char firstChar = 'p';
        char secondChar = 'p';
        string lineSolution = "";
        foreach (var character in line)
        {
            if ((int)character >= 48 && (int)character <= 57)
            {
                if (firstChar == 'p')
                {
                    firstChar = character;
                }
                else
                {
                    secondChar = character;
                }
            }
        }
        if (secondChar == 'p')
        {
            secondChar = firstChar;
        }

        lineSolution = firstChar.ToString() + secondChar.ToString();

        solutionArray.Add(int.Parse(lineSolution));
        solution += int.Parse(lineSolution);
    }
    System.Console.WriteLine(solution);
}