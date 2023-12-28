using ProjetoCalculadora.models;

Calculadora calc = new Calculadora();

do {
    Console.Clear();
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("                  Calculadora"                    );
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("Qual operação você deseja realizar?");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Potência");
    Console.WriteLine("6 - Raiz Quadrada");
    int operação = Convert.ToInt32(Console.ReadLine());

    switch (operação) {
        case 1: Console.Clear();calc.Adição();break;
        case 2: Console.Clear();calc.Subtração();break;
        case 3: Console.Clear();calc.Multiplicação();break;
        case 4: Console.Clear();calc.Divisão();break;
        case 5: Console.Clear();calc.Potência();break;
        case 6: Console.Clear();calc.RaizQuadrada();break;
        default: Console.WriteLine("Opção Inválida!"); break;
    }
    Console.WriteLine("Pressione <ENTER> para continuar");
} while (Console.ReadKey().Key == ConsoleKey.Enter); 
