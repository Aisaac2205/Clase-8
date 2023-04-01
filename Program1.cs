void arreglos()
{
    String[] nombre = new string[]
    {
 "Fernanda", "Melvin", "Luis", "Brandon", "Yamileth"
    };

    int[] notas = new int[]
    {
    70,90,43,85,30
    };
    int notaMasAlta = notas[0];
    foreach (int nota in notas)
    {
        if (nota > notaMasAlta)
        {
            notaMasAlta = nota;
        }
    }
    Console.WriteLine($"La nota más alta es del alumno {nombre[1]} y su nota es: " + notaMasAlta);
};
  
arreglos();
