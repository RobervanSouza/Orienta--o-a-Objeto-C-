string mensagem = "seja bem vindo!!!";List<string> listasBandas = new List<string> { "robervan", "auriene", "Alice", "beatriz"};void ExibirMensagem()
{
    Console.WriteLine(@"
█▀█ █▀█ █▄▄ █▀▀ █▀█ █░█ ▄▀█ █▄░█   █▀ █▀█ █░█ ▀█ ▄▀█
█▀▄ █▄█ █▄█ ██▄ █▀▄ ▀▄▀ █▀█ █░▀█   ▄█ █▄█ █▄█ █▄ █▀█
"

); // Logo
Console.WriteLine("*************************************");Console.WriteLine(mensagem);
Console.WriteLine("*************************************");
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
        case 3: Console.WriteLine("Você escolheu a opção: " + opcaoNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção: " + opcaoNumerica);
            break;
        case 0: Console.WriteLine("Você escolheu a opção :) ");
            break;
        default: Console.WriteLine("Opção invalida!!!");
            break;
    }
}void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Registrar Bandas");
    Console.WriteLine("****************************");
    Console.Write("Digite o nome da Banda para registrar: ");
    string nomeBanda = Console.ReadLine()!;
    listasBandas.Add(nomeBanda);
    Console.WriteLine($"A banda {nomeBanda} foi registrada ");
    Thread.Sleep(3000);
    Console.Clear();
    ExibirMenu();
}void MostraBandas()
{
    Console.Clear();
    Console.WriteLine("**************************** ################");
    Console.WriteLine("Exibindo todas as bandas");
    Console.WriteLine("**************************** ################\n");

   // for (int i =0;  i < listasBandas.Count; i++ )
    //{
      //  Console.WriteLine($"Banda: {listasBandas[i]}");
    //}

    foreach (string bandas in listasBandas)
    {
         Console.WriteLine($"Banda: {bandas}");

    }

    Console.Write("\nDigite uma tecla para voltar para menu");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}ExibirMenu();



















// Numero Secreto

Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);do
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