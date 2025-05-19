using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
void SimularOperacionMedia()
{
    Console.WriteLine("Simulando una operación media...");
    Thread.Sleep(2000);
    Console.WriteLine("Operación media completada.");
}
void SimularOperacionLarga()
{
    Console.WriteLine("Simulando una operación larga...");
    Thread.Sleep(3000);
    Console.WriteLine("Operación larga completada.");
}
void SimularOperacionCorta()
{
    Console.WriteLine("Simulando una operación corta...");
    Thread.Sleep(1000);
    Console.WriteLine("Operación corta completada.");
}

void EjecutarTareasAsync()
{
    Console.WriteLine("COMIENZA EL ASYNC"); Console.WriteLine("");
    stopwatch.Start();
    Task tareaMedia = Task.Run(() => SimularOperacionMedia());
    Task tareaLarga = Task.Run(() => SimularOperacionLarga());
    Task tareaCorta = Task.Run(() => SimularOperacionCorta());
    Task.WaitAll(tareaMedia, tareaLarga, tareaCorta);
    stopwatch.Stop();
    Console.WriteLine("Todas las tareas async han sido completadas en" + stopwatch.ElapsedMilliseconds + "ms");
}

void EjecutarTareasSync()
{
    Console.WriteLine("COMIENZA EL SYNC"); Console.WriteLine("");
    stopwatch.Start();
    SimularOperacionMedia();
    SimularOperacionLarga();
    SimularOperacionCorta();
    stopwatch.Stop();
    Console.WriteLine("Todas las tareas han sido completadas en" + stopwatch.ElapsedMilliseconds + "ms");
}

EjecutarTareasAsync();
Console.WriteLine("");
stopwatch.Reset();
EjecutarTareasSync();