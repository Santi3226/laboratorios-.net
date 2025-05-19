string pw = "1234";
int cont = 0;
while(cont<4)
{
    cont = cont+1;
    Console.WriteLine("Ingrese la contraseña: ");
    string? pwtest = Console.ReadLine();
    if(pwtest == pw)
    {
        Console.WriteLine("Contraseña correcta");
        break;
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}