string ruta = "C:\\Users\\Santiago\\Documents\\Escuela\\2025\\NET\\Unidad02\\Capitulo03\\Lab2.4\\archivo.txt";
string contenido = "La probabilidad define la chance de ocurrencia de un suceso A dado por un valor entre 0 y 1";
async Task EscribirArchivoAsync(string ruta, string contenido)
{
    await File.WriteAllTextAsync(ruta, contenido);
    Console.WriteLine("Escribiendo en el archivo...");
    Task.Delay(5000);
    
}
async Task LeerArchivoAsync(string ruta)
{
    await File.ReadAllTextAsync(ruta);
    Console.WriteLine("Leyendo el archivo...");
}

void ProbarEscrituraArchivoAsync()
{
    try
    {
        Task tareaEscritura = Task.Run(() => EscribirArchivoAsync(ruta, contenido));
        tareaEscritura.Wait();
    }
    catch (AggregateException ex)
    {
        Console.WriteLine("Se ha producido una excepción: " + ex.InnerException.Message);
    }
}

void ProbarLecturaArchivoAsync()
{
    try
    {
        //File.Delete(ruta); // Asegurarse de que el archivo no exista antes de leerlo
        Task tareaLectura = Task.Run(() => LeerArchivoAsync(ruta));
        tareaLectura.Wait();
        Console.WriteLine(File.ReadAllText(ruta));
    }
    catch (AggregateException ex)
    {
        Console.WriteLine("Se ha producido una excepción: " + ex.InnerException.Message);
    }
}

ProbarEscrituraArchivoAsync();
ProbarLecturaArchivoAsync();