async Task OperacionCancelableAsync(CancellationToken token)
{
    Console.WriteLine("Iniciando la operación cancelable...");
    for (int i = 0; i < 10; i++)
    {
        token.ThrowIfCancellationRequested(); // Verifica si se ha solicitado la cancelación
        Console.WriteLine($"Operación en progreso... {i + 1}/10");
        await Task.Delay(5000); // Simula 
    }
    Console.WriteLine("Operación completada.");
}

void CancelarOperacion(CancellationTokenSource cts)
{
    Console.WriteLine("Presione cualquier tecla para cancelar la operación...");
    Console.ReadKey();
    cts.Cancel(); // Solicita la cancelación
}

// Crear un CancellationTokenSource
CancellationTokenSource cts = new CancellationTokenSource();
CancellationToken token = cts.Token;
Task tareaMedia = Task.Run(() => OperacionCancelableAsync(cts.Token));
CancelarOperacion(cts);
try
{
    tareaMedia.Wait(); //Si no se usa el try, vs tira la excepcion por no ejecutar el wait
}
catch (AggregateException ex) when (ex.InnerException is TaskCanceledException)
{
    Console.WriteLine("Cancelado."); 
}