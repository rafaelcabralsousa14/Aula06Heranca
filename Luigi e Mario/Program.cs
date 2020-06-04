using System;

namespace Luigi_e_Mario
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();

            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
        }
    }
}
