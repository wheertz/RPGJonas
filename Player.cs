using System;
using System.Collections.Generic;

namespace RPGJonas
{
    class Player
    {
        // Spillerens navn
        public string Name { get; }

        // Spillerens livpoint
        public int Health { get; private set; }

        // Spillerens angrebsstyrke
        public int Attack { get; private set; }

        // Spillerens level
        public int Level { get; private set; }

        // Liste over udstyr spilleren har på sig
        private List<Equipment> equippedItems;

        // Liste over aktive quests for spilleren
        private List<Quest> activeQuests;

        // Konstruktør til oprettelse af en ny spiller
        public Player(string name)
        {
            Name = name;
            Health = 100;
            Attack = 10;
            Level = 1;
            equippedItems = new List<Equipment>();
            activeQuests = new List<Quest>();
        }

        // Metode til at udstyre spilleren med et våben
        public void EquipWeapon(Equipment weapon)
        {
            equippedItems.Add(weapon);
            Attack += weapon.Weight;
        }

        // Metode til at udstyre spilleren med en rustning
        public void EquipArmor(Equipment armor)
        {
            equippedItems.Add(armor);
            // Her kan der tilføjes yderligere logik, f.eks. at øge spillerens forsvar baseret på rustningens egenskaber
        }

        // Metode til at tildele en quest til spilleren
        public void AssignQuest(Quest quest)
        {
            activeQuests.Add(quest);
            Console.WriteLine($"{Name} received the quest: {quest.Title}");
        }

        // Metode til at udføre et angreb mod en fjende
        public void PerformAttack(Enemy enemy)
        {
            Console.WriteLine($"{Name} attacks {enemy.Name}!");
            int totalDamage = Attack + CalculateAdditionalDamage();
            enemy.TakeDamage(totalDamage);
            if (enemy.IsDead)
            {
                Console.WriteLine($"{enemy.Name} defeated! {Name} gained {enemy.Level * 2} XP.");
                LevelUp(enemy.Level * 2);
            }
            Console.WriteLine($"{enemy.Name} health: {enemy.Health}");
        }

        // Metode til at fuldføre en quest
        public void CompleteQuest(Quest quest)
        {
            if (activeQuests.Contains(quest))
            {
                Console.WriteLine($"{Name} completed the quest: {quest.Title}");
                Console.WriteLine($"{Name} gained {quest.XP} XP!");
                LevelUp(quest.XP);
                activeQuests.Remove(quest);
            }
            else
            {
                Console.WriteLine($"{Name} does not have the quest: {quest.Title}");
            }
        }

        // Metode til at level op for spilleren
        private void LevelUp(int xp)
        {
            Level += xp / 10;
            Health += 10;
            Attack += 5;
        }

        // Metode til at beregne yderligere skade (kan udvides med mere kompleks logik senere)
        private int CalculateAdditionalDamage()
        {
            return 0;
        }

        // Metode til at vise spillerens status
        public void DisplayStatus()
        {
            Console.WriteLine($"Player {Name} - Level {Level} | Health: {Health} | Attack: {Attack}\n");
        }
    }

}

