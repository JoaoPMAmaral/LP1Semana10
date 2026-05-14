namespace ArcadeLog
{
    public class Score : IComparable<Score>
    {
        // Variável de Instância Privada: points (int)
        private int points;

        // Propriedade Auto-Implementada Só de Leitura: Name (string)
        public string name {get;}

        // Propriedade: Points (int), sempre entre 0 e 9999
        public float Points
        {
            get
            {
                if(points >= 9999)
                {
                    return 9999;
                }else if(points <= 0)
                {
                    return 0;
                }else
                {
                    return points;
                }
            }
        }

        // Propriedade Só de Leitura: Medal (string)
        public string Medal
        {
            get
            {
                if(points >= 7000)
                {
                    return "Gold";
                } else if(points >= 4000)
                {
                    return "Silver";
                } else
                {
                    return "Bronze";
                }
            }
        }

        // Construtor: aceita nome e pontuação
        public Score(string nome, int pontuacao)
        {
            nome = name;
            pontuacao = points;
        }

        public int CompareTo(Score other)
        {
            // CÓDIGO AQUI
            return 0; // substitua o return
        }

        public override string ToString()
        {
            return $"{name} [{Medal}]: {points}";
        }
    }
}
