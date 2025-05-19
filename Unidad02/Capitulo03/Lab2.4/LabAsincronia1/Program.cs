using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
void SimularOperacionPesada()
{
    stopwatch.Start();
    Console.WriteLine("Simulando una operación pesada...");
    Thread.Sleep(5000);
    Console.WriteLine("Operación pesada completada.");
    stopwatch.Stop();
}

void SimularOperacionPesadaAsync()
{
    stopwatch.Start();
    Console.WriteLine("Simulando una operación pesada...");
    Thread.Sleep(5000);
    Console.WriteLine("Operación pesada completada.");
    stopwatch.Stop();
}

SimularOperacionPesada();
Console.WriteLine($"Tiempo transcurrido Sync: {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Reset();

await Task.Run(() => SimularOperacionPesadaAsync());
Console.WriteLine(Console.ReadLine());
Console.WriteLine($"Tiempo transcurrido Async: {stopwatch.ElapsedMilliseconds} ms");

//El codigo asyncronico es ms mas rapido y me habilito a realizar otras tareas mientras se ejecutaba la tarea asincrona
//El inconveniente q puede existir con el cod async es q si no se maneja bien el await puede generar un punto muerto