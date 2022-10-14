using System.Collections;
using System.Collections.Generic;

public class Multiplying 
{
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public string Multiply(string str1, int num3)
    {
        string result = "";

        for (int i = 0; i < num3; i++)
        {
            result += str1;
        }

        return result;
    }
}
