﻿void arreglos()
{
    Console.Write("¿Cuántos alumnos tiene el curso?: ");
    int numAlumnos = int.Parse(Console.ReadLine());

    string[] nombresAlumnos = new string[numAlumnos];
    int[] notasAlumnos = new int[numAlumnos];


    for (int i = 0; i < numAlumnos; i++)
    {
        Console.Write($"Ingrese el nombre del alumno número {i + 1}: ");
        nombresAlumnos[i] = Console.ReadLine();

        Console.Write($"Ahora ingrese la nota del alumno número {i + 1}: ");
        notasAlumnos[i] = int.Parse(Console.ReadLine());
    }


    int notaMasAlta = notasAlumnos[0];
    string nombreNotaMasAlta = nombresAlumnos[0];

    for (int i = 1; i < numAlumnos; i++)
    {
        if (notasAlumnos[i] > notaMasAlta)
        {
            notaMasAlta = notasAlumnos[i];
            nombreNotaMasAlta = nombresAlumnos[i];
        }
    }

    int notaMasBaja = notasAlumnos[0];
    string nombreNotaMasBaja = nombresAlumnos[0];

    for (int i = 1; i < numAlumnos; i++)
    {
        if (notasAlumnos[i] < notaMasBaja)
        {
            notaMasBaja = notasAlumnos[i];
            nombreNotaMasBaja = nombresAlumnos[i];
        }
    }
    Console.WriteLine($"La nota de {nombreNotaMasAlta} es la más alta con: {notaMasAlta}");
    Console.WriteLine($"La nota de {nombreNotaMasBaja} es la más baja con: {notaMasBaja}\n");
    Console.WriteLine($"¡Gracias por usar este programa!");
}

arreglos();