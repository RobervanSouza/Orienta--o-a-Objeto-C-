

//List<string> listasBandas = new List<string> { "robervan", "auriene", "Alice", "beatriz"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 3, 4 });
bandasRegistradas.Add("voice", new List<int> ());

void ExibirMensagem()
{
    Console.WriteLine(@"
█▀█ █▀█ █▄▄ █▀▀ █▀█ █░█ ▄▀█ █▄░█   █▀ █▀█ █░█ ▀█ ▄▀█
█▀▄ █▄█ █▄█ ██▄ █▀▄ ▀▄▀ █▀█ █░▀█   ▄█ █▄█ █▄█ █▄ █▀█
"

); // Logo
//Console.WriteLine("*************************************");
    ExibiTitulo("Seja bem vindo !!!");
//Console.WriteLine("*************************************");
}




void ExibirMenu ()
{
    ExibirMensagem();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir media de uma banda");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida =  Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: MostraBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: MediaDaBanda();
            
            break;
        case 0: Console.WriteLine("Você escolheu a opção :) ");
            break;
        default: Console.WriteLine("Opção invalida!!!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibiTitulo("Registar bandas!!!");
    Console.Write("Digite o nome da Banda para registrar: ");
    string nomeBanda = Console.ReadLine()!;
    //listasBandas.Add(nomeBanda);
    bandasRegistradas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"A banda {nomeBanda} foi registrada ");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirMenu();
}

void MostraBandas()
{
    Console.Clear();
    ExibiTitulo("Exibir todas as bandas registadas!!!");

   // for (int i =0;  i < listasBandas.Count; i++ )
    //{
      //  Console.WriteLine($"Banda: {listasBandas[i]}");
    //}

    foreach (string bandas in bandasRegistradas.Keys)
    {
         Console.WriteLine($"Banda: {bandas}");

    }

    Console.Write("\nDigite uma tecla para voltar para menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();

void ExibiTitulo (string titulo)
{
    int quantidadeLetra = titulo.Length;
    string contaASteristicos = string.Empty.PadLeft(quantidadeLetra, '$');
    Console.WriteLine(contaASteristicos);
    Console.WriteLine(titulo);
    Console.WriteLine(contaASteristicos + "\n");

}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibiTitulo("Avaliar Banda");
    Console.WriteLine("***********************");

    // Mostrar todas as bandas e suas notas
    Console.WriteLine("Bandas Registradas:");
    foreach (var banda in bandasRegistradas)
    {
        string nomeDaBandae = banda.Key;
        List<int> notas = banda.Value;

        Console.WriteLine($"- {nomeDaBandae}");

        if (notas.Count > 0)
        {
            Console.WriteLine("  Notas:");
            foreach (int nota in notas)
            {
                Console.WriteLine($"    - {nota}");
            }
        }
        else
        {
            Console.WriteLine("  A banda ainda não recebeu avaliações.");
        }

    }
   
    Console.Write("\nDigite o nome da banda para avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece:  ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.Write($"\nA nota {nota} foi registrada com sucesso {nomeDaBanda} ");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!!!");
        Console.Write("Digite uma tecla para voltar ");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }

}

void MediaDaBanda()
{
    Console.Clear();
    ExibiTitulo($"Média da Banda ");
    Console.WriteLine("***********************");

    // Mostrar todas as bandas
    Console.WriteLine("Bandas Registradas:");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"- {banda}");
    }
    Console.WriteLine("***********************");
    Console.Write("Digite o nome da banda para calcular a média: ");
    string nomeBandaMedia = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBandaMedia))
    {
        List<int> notas = bandasRegistradas[nomeBandaMedia];

        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"A média da banda {nomeBandaMedia} é: {media:F2}");
        }
        else
        {
            Console.WriteLine($"A banda {nomeBandaMedia} ainda não recebeu avaliações.");
        }
    }
    else
    {
        Console.Clear();
        ExibiTitulo($"A banda {nomeBandaMedia} não foi encontrada!!!");

        // Exibir o nome de todas as bandas
        Console.WriteLine("Bandas Registradas:");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"- {banda}");
        }

        Console.Write("\nDigite uma tecla para voltar para o menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();




    }

    Console.Write("\nDigite uma tecla para voltar para o menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

















// Numero Secreto

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
do
{
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("O número é maior.");
    }
    else
    {
        Console.WriteLine("O número é menor.");
    }

} while (true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");


// Diferença de for para foreach
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine(numeros[i]);
    }
}


foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}