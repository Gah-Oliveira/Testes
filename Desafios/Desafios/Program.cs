Random num = new Random();

float a = num.Next(1, 50);
float b = num.Next(1, 50);

List<String> listaBanda = new List<string> {"ACDC", "Metallica", "Ramones", "Motorhead"};
List<int> listaNum = new List<int>(10);// {1,2,3,4,5,6,7,8,9,10};

void Calculos()
{
    Console.WriteLine($"Numero aleatório A: {a}");
    Console.WriteLine($"Numero aleatório B: {b}");
    Console.WriteLine($"Soma: {a + b}");
    Console.WriteLine($"Subtração: {a - b}");
    Console.WriteLine($"Multiplicação: {a * b}");
    Console.WriteLine($"Divisão: {a / b}\n");
}

void ListarBandas()
{
    for (int i = 0; i < listaBanda.Count; i++)
    {
        Console.WriteLine(listaBanda[i]);
    }
}

void ListarNumeros()
{
    int sum = 0;

    for (int i = 0;i < listaNum.Capacity;i++)
    {
        int v = num.Next(1, 10);
        listaNum.Add(v);
        Console.WriteLine($"Número inserido: {listaNum[i]}");
        sum += v;
    }
    Console.WriteLine($"Total: {sum}");
}

void ListarNumerosPares()
{
    /*for (int i = 0; i<listaNum.Count;i++) 
    {
        if (listaNum[i]%2==0)
        {
            Console.WriteLine(listaNum[i]);
        }
    }*/

    foreach (int i in listaNum)
    {
        if(i%2==0)
        {
            Console.WriteLine(i);
        }
    }
}

Calculos();

ListarBandas();

ListarNumeros();

//ListarNumerosPares();