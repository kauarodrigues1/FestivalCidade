using FestivalCidade;

Console.Write("Digite o nome do fã: ");
string nome = Console.ReadLine() ?? "";

Console.Write("Digite a quantidade de dias de show: ");
int quantidadeDias = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o cupom de desconto: ");
string cupom = Console.ReadLine() ?? "";

Console.Write("Digite a pontuação do clube de fidelidade: ");
int pontuacaoClube = int.Parse(Console.ReadLine() ?? "0");

Usuario usuario = new Usuario(
    nome,
    quantidadeDias,
    cupom,
    pontuacaoClube
);

Console.WriteLine();
Console.WriteLine("===== FESTIVALCIDADE =====");
Console.WriteLine($"Nome do Fã: {usuario.Nome.ToUpper()}");
Console.WriteLine($"Valor Bruto: R$ {usuario.CalcularCustoBruto():F2}");
Console.WriteLine($"Valor Final: R$ {usuario.CalcularValorFinal():F2}");
Console.WriteLine($"Acesso ao Lounge VIP: {usuario.TemAcessoVip()}");
