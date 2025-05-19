Progress<int> progress = new Progress<int>(valor =>
{
    Console.WriteLine($"Progreso: {valor * 20}%");
});
async Task OperacionLargaConProgresoAsync(IProgress<int> progreso)
{
    for (int i = 1; i <= 5; i++)
    {
        progreso.Report(i); // Reportando progreso  
        await Task.Delay(2000); // Simulando trabajo  
    }
}

Task tareaAsync = Task.Run(() => OperacionLargaConProgresoAsync(progress));
try
{
    Console.WriteLine("Ya puede usar el UI.");
    Console.ReadLine();
    tareaAsync.Wait(); // Si no se usa el try, vs tira la excepcion por no ejecutar el wait
}
catch (AggregateException ex)
{
    Console.WriteLine("Se ha producido una excepción: " + ex.InnerException.Message);
}

//No entiendo si lo hice bien o no :d