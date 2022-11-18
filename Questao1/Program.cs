using Models;

var tamanhoSala = Console.ReadLine().Split(' ');
string instrucoes = Console.ReadLine();

int largura = int.Parse(tamanhoSala[0]), comprimento = int.Parse(tamanhoSala[1]);
RoboAspirador robo = new RoboAspirador();

foreach (var item in instrucoes)
{
    switch (item)
    {
        case 'F':
            robo.PassoFrente(largura, comprimento);
            break;
        case 'T':
            robo.PassoTras(largura, comprimento);
            break;
        case 'D':
            robo.MudadaOrientacaoParaDireita();
            break;
        case 'E':
            robo.MudadaOrientacaoParaEsquerda();
            break;
        default:
            Console.WriteLine("Instrução invalida");
            break;
    }

}

robo.ImprimeResltado();