int rdm_lines = new Random().Next(2,8);
int rdm_columns = new Random().Next(2,8);
int[,] two_dim_array = new int [ rdm_lines,rdm_columns ];
int[,] array = new int[rdm_lines,rdm_columns];
void FillTwoDimArrayRDM(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10,100);
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
void Math(int[,] array)
{
    for(int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {   int count = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[a,b] == array[i,j])
                    {
                        count +=1;
                        if (count > 1)
                        {
                            array[i,j] = new Random().Next(10,100);
                            Math(array);
                        }
                    }
                }
            }
        }
    }
}
   

FillTwoDimArrayRDM(two_dim_array);
PrintTwoDimArray(two_dim_array);
Console.WriteLine();
Math(two_dim_array);
PrintTwoDimArray(two_dim_array);