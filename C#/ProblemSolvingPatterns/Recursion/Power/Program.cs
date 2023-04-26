/*
Write a function called power which accepts a 
base and an exponent. The function should 
return the power of the base to the exponent. 
This function should mimic the functionality 
of Math.pow()  - do not worry about negative bases and exponents.
*/

int Power(int baseNumber, int exponent) 
{
    if (exponent == 1)
        return baseNumber;

    return baseNumber * Power(baseNumber, exponent - 1);
}

Console.WriteLine(Power(2, 3));