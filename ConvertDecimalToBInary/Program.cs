//Ler um numero inteiro e converter para o correspondente binário.
int userValue, quotient, reminderValue = 0;
int[] binaryNumber = new int[8];

userInteraction();
changeValueToBinary(userValue);

foreach (int value in binaryNumber)
{
    Console.Write("{0} ", value);
}

int[] changeValueToBinary(int valor)
{
    quotient = valor;
    for(int i = 0; i < binaryNumber.Length; i++)
    {
        if((quotient == 1) && (quotient % 2 == 0))
        {
            i = binaryNumber.Length;
        }
        reminderValue = quotient % 2;        
        putNumberInVector();
        quotient = valor / 2;
        valor = quotient;        
    }
    return binaryNumber;
}
void putNumberInVector()
{
    for(int i = binaryNumber.Length - 1 ; i >= 0; i--)
    {
        binaryNumber[i] = reminderValue;
    }
}
void userInteraction()
{
    Console.Write("Put a number to chage value to binary: ");
    if (!int.TryParse(Console.ReadLine(), out userValue))
    {
        Console.WriteLine("The number must to be a integer value.");
    }
    else
    {
        changeValueToBinary(userValue);        
    }
}