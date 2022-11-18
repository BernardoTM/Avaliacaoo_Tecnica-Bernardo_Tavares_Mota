namespace Models
{
    public class RoboAspirador
    {
        public int PosicaoEixoX { get; private set; }
        public int PosicaoEixoY { get; private set; }
        public char Direcao { get; private set; }

        public RoboAspirador()
        {
            PosicaoEixoX = 0;
            PosicaoEixoY = 0;
            Direcao = 'N';
        }

        public void PassoFrente(int largura, int comprimento)
        {
            switch (Direcao)
            {
                case 'N':
                    if (PosicaoEixoY < comprimento)
                    {
                        PosicaoEixoY++;
                    }
                    break;
                case 'S':
                    if (PosicaoEixoY > 0)
                    {
                        PosicaoEixoY--;
                    }
                    break;
                case 'L':
                    if (PosicaoEixoX < largura)
                    {
                        PosicaoEixoX++;
                    }
                    break;
                case 'O':
                    if (PosicaoEixoX > 0)
                    {
                        PosicaoEixoX--;
                    }
                    break;
                default:
                    break;
            }

        }

        public void PassoTras(int largura, int comprimento)
        {
            switch (Direcao)
            {
                case 'N':
                    if (PosicaoEixoY > 0)
                    {
                        PosicaoEixoY--;
                    }
                    break;
                case 'S':
                    if (PosicaoEixoY < comprimento)
                    {
                        PosicaoEixoY++;
                    }
                    break;
                case 'L':
                    if (PosicaoEixoX > 0)
                    {
                        PosicaoEixoX--;
                    }
                    break;
                case 'O':
                    if (PosicaoEixoX < comprimento)
                    {
                        PosicaoEixoX++;
                    }
                    break;
                default:
                    break;
            }
        }

        public void MudadaOrientacaoParaDireita()
        {
            switch (Direcao)
            {
                case 'N':
                    Direcao = 'L';
                    break;
                case 'S':
                    Direcao = 'O';
                    break;
                case 'L':
                    Direcao = 'S';
                    break;
                case 'O':
                    Direcao = 'N';
                    break;
                default:
                    break;
            }


        }

        public void MudadaOrientacaoParaEsquerda()
        {
            switch (Direcao)
            {
                case 'N':
                    Direcao = 'O';
                    break;
                case 'S':
                    Direcao = 'L';
                    break;
                case 'L':
                    Direcao = 'N';
                    break;
                case 'O':
                    Direcao = 'S';
                    break;
                default:
                    break;
            }
        }
        public void ImprimeResltado()
        {
            Console.WriteLine(@"{0} {1} {2}", Direcao, PosicaoEixoX, PosicaoEixoY);
        }
    }
}