﻿bool flag = true;
int value = 0; // initialise the varioable value
if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
