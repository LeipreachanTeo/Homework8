int rdm_lines = new Random().Next(2,6);
int rdm_columns = new Random().Next(2,6);
int[,] two_dim_array = new int [ rdm_lines,rdm_columns ];

void FillTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }   
}
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}
void MinSumLine(int[,] array)
{
    int Sum = int.MaxValue;
    int index = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int Min = 0;
        for (int j =0; j < array.GetLength(1); j++)
        {
            Min += array[i,j];
        }
        if (Min < Sum)
        {
            index = i;
            Sum = Min;
        }
    }
    Console.WriteLine($"Номер строки с наименшей суммой элементов: {index+1}");
}
FillTwoDimArray(two_dim_array);
PrintTwoDimArray(two_dim_array);
MinSumLine(two_dim_array);


