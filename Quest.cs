namespace RPGJonas
{
    class Quest
    {
        // Titlen på questen
        public string Title { get; }

        // Beskrivelsen af questen
        public string Description { get; }

        // XP (erfaringspoint) belønningen for at fuldføre questen
        public int XP { get; }

        // Konstruktør til oprettelse af en ny quest
        public Quest(string title, string description, int xp)
        {
            Title = title;
            Description = description;
            XP = xp;
        }
    }


}
