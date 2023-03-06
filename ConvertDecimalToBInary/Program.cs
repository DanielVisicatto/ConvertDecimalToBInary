//Ler um numero inteiro e converter para o correspondente binário.
int userValue, quotient;
int[] binaryNumber = new int[8];

userInteraction();
changeValueToBinary(userValue);

foreach (int value in binaryNumber)
{
    Console.Write("{0} ", value);
}

void changeValueToBinary(int value)
{
    //iniciando quotient com o valor da variavel valor
    quotient = value;
    //o for já vem ao contrário colocando os dados no vetor
    for(int i = binaryNumber.Length -1; i >= 0; i--)
    {
        //pega o resto da divisão deste numero e armazena na posição i
        binaryNumber[i] = quotient % 2;
        //atualizar o valor pra divisão inteira do quociente por 2 
        quotient /= 2;
        //se o quociente for zero, encerra o loop

        if(quotient == 0)
        {
            break;
        }
              
    }
    // depois a funcao retorna o vetor binaryNumber com os dados esperados
    return binaryNumber;
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