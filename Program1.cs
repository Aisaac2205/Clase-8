void arreglos()
{
    string[] nombre = new string[]
    {
        "Fernanda", "Melvin", "Luis", "Brandon", "Yamileth"
    };

    int[] notas = new int[]
    {
        70,90,43,85,30
    };
    int notaMasAlta = notas[0];
    string nombreNotaMasAlta = nombre[0];

    foreach (int nota in notas)
    {
        if (nota > notaMasAlta)
        {
            notaMasAlta = nota;
        }
    }

    for (int i = 0; i < nombre.Length; i++)
    {
        if (notas[i] == notaMasAlta)
        {
            nombreNotaMasAlta = nombre[i];
            break;
        }
    }
    int notaMasBaja = notas[0];
    string nombreNotaMasBaja = nombre[0];

    foreach (int nota in notas)
    {
        if (nota < notaMasBaja)
        {
            notaMasBaja = nota;
        }
    }

    for (int i = 0; i < nombre.Length; i++)
    {
        if (notas[i] == notaMasBaja)
        {
            nombreNotaMasBaja = nombre[i];
            break;
        }
    }

    Console.WriteLine($"La nota más alta es {notaMasAlta} y es del alumno {nombreNotaMasAlta}");
    Console.WriteLine($"La nota más baja es {notaMasBaja} y es del alumno {nombreNotaMasBaja}");
}

arreglos();

