int lines= 2;
int colums = 2;
int[,] two_dim_array_one = new int [ lines, colums ];
int[,] two_dim_array_two = new int [lines, colums];

void FillTwoDimArrayRDM(int[,] array)
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
void ProductMartix(int[,]martix_one, int[,] matrix_two)
{
    int [,] matrix_product = new int [martix_one.GetLength(0), matrix_two.GetLength(1)];
    for (int i = 0; i < martix_one.GetLength(0); i++)
    {
        for(int j = 0; j < matrix_two.GetLength(0); j++)
        {
            for(int k = 0; k < matrix_two.GetLength(1); k++)
            {
                matrix_product[i,j] += martix_one[i,k] * matrix_two[k,j]; 
            }
        Console.Write(matrix_product[i,j]+ " ");   
        }
    Console.WriteLine();
    }
}
FillTwoDimArrayRDM(two_dim_array_one);
FillTwoDimArrayRDM(two_dim_array_two);
Console.WriteLine($"\nПервая матрица:");
PrintTwoDimArray(two_dim_array_one);
Console.WriteLine($"Вторая матрица:");
PrintTwoDimArray(two_dim_array_two);
Console.WriteLine($"Произведение матриц:");
ProductMartix(two_dim_array_one, two_dim_array_two);