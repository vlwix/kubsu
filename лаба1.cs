double SizeVector(int[] vector, int size, int[][] matrix)
{
    int[] matrix1;
    matrix1 = new int[size];
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum = 0;
        for (int j = 0; j < size; j++)
        {
            sum += vector[j] * matrix[j][i];
        }
        matrix1[i] = sum;
    }
    sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += matrix1[i] * vector[i];
    }
    return Math.Sqrt(sum);
}
int Symmetry(int size, int[][] matrix)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (matrix[i][j] != matrix[j][i])
            {
                return 0;
            }
        }
    }
    return 1;
}
string readFile = "laba1.txt";
string? s;
int size = 0;
int[] vector = new int[0];
int[][] matrix = new int[0][];
try
{
    StreamReader str = new StreamReader(readFile);
    size = Convert.ToInt32(str.ReadLine());
    vector = new int[size];
    matrix = new int[size][];
    for (int i = 0; i < size; ++i)
    {
        s = str.ReadLine();
        matrix[i] = s.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    }
    s = str.ReadLine();
    vector = s.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    str.Close();
}
catch (Exception e)
{
    Console.WriteLine("exception" + e.Message);
}
if (Symmetry(size, matrix) == 1)
{
    Console.WriteLine("Матрица симметрична.");
}
if (Symmetry(size, matrix) == 1)
{
    Console.WriteLine("Ответ: ");
    Console.WriteLine(SizeVector(vector, size, matrix));
}
else
{
    Console.WriteLine("Ответа нет.");
}
