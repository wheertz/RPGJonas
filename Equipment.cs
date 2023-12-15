namespace RPGJonas
{
    class Equipment
    {
        // Navnet på udstyret
        public string Name { get; }

        // Vægten af udstyret
        public int Weight { get; }

        // Konstruktør til oprettelse af nyt udstyr
        public Equipment(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        // Overrides ToString-metoden for at give en brugervenlig repræsentation af udstyret
        public override string ToString()
        {
            return $"{Name} (Vægt: {Weight})";
        }
    }


}
