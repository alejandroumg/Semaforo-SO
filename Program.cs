using System; 
// importa el espacio de nombres 'system', que contiene clases basicas como 'Console' 

using System.Threading; 
// importa el espacio de nombres 'system.threading', que contiene clases para trabajar con hilos y sincronizacion, incluyendo 'semaphore'.
class Program // declara la clase 'Program'.
{
    private static Semaphore semaphore = new Semaphore(3, 3);
  // declaramos una variable de tipo 'Semaphore' llamada 'semaphore'. Al ser estatica es compartida por todos los hilos. 'new semaphore (3, 3)' crea un objeto de tipo 'Semaphore' con un valor inicial de 3 y un valor maximo de 3. el primer '3' nos indica cuantos hilos estan disponibles al inicio y el segundo '3' nos indica cuantos hilos se pueden crear. esto nos dice que hasta 3 hilos pueden acceder al recurso al mismo tiempo.

    static void Main()
  //es el metodo principal de la clase 'Program' que se ejecuta al iniciar el programa.
    {
       
        for (int i = 1; i <= 5; i++)
      // este es un bucle que crea 5 hilos.
        {
            Thread thread = new Thread(AccessResource);
          // crea un nuevo hilo y le asigna la funcion 'AccessResource' como su metodo de trabajo. accesresource es la funcion que accede al recurso compartido.
          
            thread.Name = "Hilo " + i;
          // le asigna un nombre al hilo. esto apara identifiralo en los mensajes de consola.
          
            thread.Start();
          //inicia el hilo.
          
        }
    }

    private static void AccessResource()
  //define un metodo estatico llamado 'AccessResource' que sera ejecutado por cada hilo.
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} está esperando para entrar...");
      //imprime un mensaje que nos dice que el hilo esta esperando para acceder al recurso.

        semaphore.WaitOne();
      //espera a que un hilo disponible acceda al recurso. si hay permisos disponibles (contador >0), decrementa el contador y deja que el hilo continue, si no hay permisos el hilo se bloquea hasta que un permiso este disponible (se libere).

        Console.WriteLine($"{Thread.CurrentThread.Name} ha entrado!");
      //imprime un mensaje que nos dice que el hilo ha entrado al recurso.

        Thread.Sleep(2000);
      //hace que el hilo 'duerma' por 2000 milisegundos (2 segundos) para simular que esta trabajando con el recurso.

        Console.WriteLine($"{Thread.CurrentThread.Name} está saliendo...");
      //imprime un mensaje que nos dice que el hilo esta saliendo del recurso.

        semaphore.Release();
      // libera un permiso para que otro hilo pueda acceder al recurso.
    }
}