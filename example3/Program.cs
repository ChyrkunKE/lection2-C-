﻿int [] array = {1,2,34,56657,7768,89,543,23,89};
int n = array.Length;
int find = 89;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}

