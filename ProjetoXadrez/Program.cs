using System;
using Mesa;
using PartidaX;
using Enum;
using ProjetoXadrez.PecasDoTabuleiro;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro Tab = new Tabuleiro(8, 8);

                Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao(0, 0));
                Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new Posicao(1, 1));
                Tab.ColocarPeca(new Torre(Tab, Cor.Branca), new Posicao(2, 2));

                
                Tela.ImprimirTabuleiro(Tab);
            }
            catch
            {
                throw new TabuleiroException(" Erro Encontrado ");
            }




        }
    }
}
