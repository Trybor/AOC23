double pqFormel(double time, long distance)
{
    double result = 0;
    double result1 = time / 2.0 - Math.Sqrt(Math.Pow((-time / 2.0), 2) - distance);
    double result2 = time / 2.0 + Math.Sqrt(Math.Pow((-time / 2.0), 2) - distance);

    if (result1 % 1 == 0 || result2 % 1 == 0)
    {
        result1 = Math.Ceiling(result1);
        result2 = Math.Ceiling(result2);
        result = result2 - result1 + 1;
    }
    else
    {
        result1 = Math.Ceiling(result1);
        result2 = Math.Ceiling(result2);   
        result = result2 - result1;
    }
    return result;
}
// double result2 = pqFormel(53897698,313109012141201);
// System.Console.WriteLine(result2);

// double result3 = pqFormel(59,430) * pqFormel(70,1218) * pqFormel(78,1213) * pqFormel(78,1276);
// System.Console.WriteLine(result3);