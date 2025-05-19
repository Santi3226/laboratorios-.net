void OperacionErrorAsync()
{
    Console.WriteLine("Simulando una operación media...");
    Thread.Sleep(2000);
    throw new InvalidOperationException("Error simulado en operación asincrónica");
}

void ProbarManejoExcepcionesAsync()
{
    try
    {
        Task tareaMedia = Task.Run(() => OperacionErrorAsync());
        tareaMedia.Wait();
    }
    catch (AggregateException ex)
    {
        Console.WriteLine("Se ha producido una excepción: " + ex.InnerException.Message);
    }
}

ProbarManejoExcepcionesAsync();