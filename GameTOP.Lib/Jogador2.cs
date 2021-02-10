using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas patenado"; 
        }

        public string Corre()
        {
            return "Maradona estas coriendo"; 
        }

        public string Passe()
        {
            return "Maradona estas passando"; 
        }
    }
}