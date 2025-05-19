Console.WriteLine("Ingrese la cantidad de numeros a evaluar: ");
int n = Convert.ToInt32(Console.ReadLine());

int j;
int k;
bool flag = true;
for (int i = 3; i < n; i++)
{
    for (j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            flag = false;
            break;
        }
    }

    for (k = 2; k < (i+2); k++)
    {
        if ((i+2) % k == 0)
        {
            flag = false;
            break;
        }
    }
    
    if(flag) Console.WriteLine(j + " y " + k + " son primos gemelos");
    flag = true;
}