Explicación de como este ejemplo de "semaforo contador" resuelve los problemas de sincronizacion, concurrencia y exclusión mutua.
Sincronización:
  problema: Se refiere a la coordinacion entre varios procesos o hilos para asegurarse de que se ejecutan en el orden correcto o en el tiempo que es aedcuado. 
    solución: el semaforo actua como un mecanismo de sicronizacion porque controla cuando los hilos pueden tener acceso o no al recurso, solo permite que un numero especifico
    (en el caso del ejemplo 3) de hilos acceda al recurso al mismo tiempo, si un hilo intenta acceder al recurso y no hay permisos disponibles, se sincroniza automaticamente 
    esperando hasta que un permiso sea liberado 

Concurrencia: 
  Problema: Ocurre cuando varios procesos o hilos intentan ejecutar codigo al mismo tiemo, eso los puede llevar a problemas si no se manejan correctamente los recursos compartidos.
    Solucion: el semaforo contador permite manejar la concurrencia limitando el numero de hilos qu epueden acceder a un recurso al mismo tiempo. como restringe el acceso a un numero
    especifico de hilos se previenen estos problemas u otros como condiciones de carrera, donde el resultado del programa podria depender del orden en que se ejecutan los hilos. 

Exclusion Mutua:
  Problema: garantiza que solo un hilos pueda acceder a un recurso a la vez, evitando probleas. 
    Solucion: aunque el semaforo contador nos permite que varios hilos accedan al recurso, tambien pueden actuar como mecanismo de exclusion mutua si se inicia ocn un valor de 1, 
    funcionando enonces como un semaforo binario, en este caso solo un hilo puede acceder al recurso a la vez asegurando que no hay conflictos. 
