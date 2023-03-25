void Adivina()
{
    const int Oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte intentos, bandera_control;
    string lima;

    Random rand = new Random();

    do
    {
        numeroCPU = Convert.ToInt32(rand.Next(100));
    } while (!(((numeroCPU >= 1) & (numeroCPU <= 20))));

    intentos = 1;
    bandera_control = 0;
    do
    {
        Console.WriteLine("Hola estoy pensando en un numero, cual crees que es?");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if ((numeroUsuario == numeroCPU))
        {
            Console.WriteLine("Yes! adivinaste!");
            bandera_control = 1;
        }
        else
        {
            Console.WriteLine("Te equivocaste.");
        }
    } while (((intentos <= Oportunidades) & (bandera_control == 0)));

    if (bandera_control == 0)
    {
        Console.WriteLine("El numero que pense era: " + numeroCPU);
    }

}
Adivina();
Console.WriteLine();

void busca_mayor()
{
    int mayor = 0;
    int numero = 0;
    Random numerito = new Random();

    for ( int i = 0; i < 5; i++)
    {
        numero = numerito.Next(100);
        Console.WriteLine(numero);
        if (numero > mayor)
        {
            mayor = numero;
        }
    }

    Console.WriteLine("El numero mayor es: " + mayor);
}

void busca_menor()
{
    int menor = 100;
    int numero = 0;
    Random numerito = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = numerito.Next(100);
        Console.WriteLine(numero);
        if (numero > menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("El numero menor es: " + menor);
}
busca_menor();
busca_mayor();

/*void Adivina()
{
    const int Oportunidades = 4;
    Random rand = new Random();
    int numeroCPU = rand.Next(1, 21);

    for (int intentos = 1; intentos <= Oportunidades; intentos++)
    {
        Console.WriteLine("Hola estoy pensando en un número, ¿cuál crees que es?");
        int numeroUsuario = Convert.ToInt32(Console.ReadLine());
        if (numeroUsuario == numeroCPU)
        {
            Console.WriteLine("¡Sí! ¡adivinaste!");
            return;
        }
        else
        {
            Console.WriteLine("Te equivocaste. El número que pensé era: " + numeroCPU);
        }
    }

    Console.WriteLine("El número que pensé era: " + numeroCPU);
}

Adivina();
Console.WriteLine();


void arreglos()
{
    int[] notas = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }

    Console.WriteLine("desplegando información: ");

    for (int i = 0; i <= notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    } 
}
arreglos();*/

/*void arreglos()
{
    int[] notas = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);
    }

    Console.WriteLine("Desplegando información: ");

    int mayor = notas[0];
    int menor = notas[0];
    int sumaNotas = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }
        if (notas[i] < menor)
        {
            menor = notas[i];
        }
        sumaNotas += notas[i];
    }

    double promedioNotas = (double)sumaNotas / notas.Length;

    Console.WriteLine("La nota más alta es: " + mayor);
    Console.WriteLine("La nota más baja es: " + menor);
    Console.WriteLine("El promedio de notas es: " + promedioNotas);
}

arreglos();*/

void nombres()
{
    String[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Ruldin";
    nombre[7] = "Steven";
    nombre[8] = "Marlon";
    nombre[9] = "Gabriela";
    nombre[10] = "Johana";


    for (int i = 0; i< nombre.Length; i++)
    {
        Console.WriteLine(i + ": " + nombre[i]);
    }

    Random rnd = new Random();
    int ganador1 = rnd.Next(0, 11); 
    int ganador2 = rnd.Next(0, 11); 

    while (ganador2 == ganador1) 
    {
        ganador2 = rnd.Next(0, 11);
    }

    Console.WriteLine("El primer premio del cerdo sin una pierna es para: " + nombre[ganador1]);
    Console.WriteLine("El segundo premio de la pierna de cerdo es para: " + nombre[ganador2]);
}
nombres();