namespace Luigi_e_Mario
{
    public class Luigi : Player
    {
        public override void Pular(){
            // Manter as ações do método pai
            base.Pular();
            // Acrescento novas ações
            System.Console.WriteLine("Luigi agora está pulando com uma altura maior");
        }
    }
}