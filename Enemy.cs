namespace RPGJonas
{
    class Enemy
    {
        // Fjendens navn
        public string Name { get; }

        // Fjendens niveau
        public int Level { get; }

        // Fjendens livspoints
        public int Health { get; private set; }

        // Konstruktør til oprettelse af en ny fjende
        public Enemy(string name, int level)
        {
            Name = name;
            Level = level;
            // Fjendens livspoints initialiseres baseret på niveau
            Health = level * 8;
        }

        // Metode til at påføre fjenden skade
        public void TakeDamage(int damage)
        {
            Health -= damage;
            // Sikrer, at livspoints ikke bliver negative
            if (Health <= 0)
            {
                Health = 0;
            }
        }

        // Egenskab der returnerer, om fjenden er død
        public bool IsDead { get { return Health <= 0; } }
    }

}
