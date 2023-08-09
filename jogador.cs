using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class jogador : Program

    {
        string nome;
        int idade;
        int drible;
        int velocidade;
        int chute;
        int forca;

        public void correr()
        {
            int aceleracao = forca + velocidade;
        }
        public int chutar()
        {
            int potenciachute  = forca * chute;
            return potenciachute;
        }
        public double tocar()
        {
            double tocar = forca / 3 +  chute / 3;
            return tocar;
        }
        public double interceptar()
        {
            double roubar = velocidade * velocidade + forca / 2;
            return roubar;
        }
        public int driblar()
        {
            int driblar = drible  + velocidade * velocidade;
            return driblar;
        }
    }
}
