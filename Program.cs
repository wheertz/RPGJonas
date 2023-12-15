using System;


namespace RPGJonas
{
    class RPGGame
    {
        static void Main()
        {
            // Opret en ny spiller
            Player player = new Player("Leroy Jenkins");

            // Opret udstyr
            Equipment sword = new Equipment("Sword of a Thousand Truths", 5);
            Equipment armor = new Equipment("Judgment Armor", 10);

            // Udstyr spilleren
            player.EquipWeapon(sword);
            player.EquipArmor(armor);

            // Titel på spillet
            Console.WriteLine("Velkommen til DragonSlayer!\n");

            // Opret fjender
            Enemy enemy1 = new Enemy("Big Goblin", 5);
            Enemy enemy2 = new Enemy("Small Goblin", 3);

            // Opret quests
            Quest defeatGoblinQuest = new Quest("Besejr gobliner", "Besejr 3 gobliner i skoven.", 15);
            Quest slayDragonQuest = new Quest("Dræb dragen", "Konfronter og besejr den mægtige drage.", 50);

            // Tildel quests til spilleren
            player.AssignQuest(defeatGoblinQuest);
            player.AssignQuest(slayDragonQuest);

            // Vis initial spillerstatus
            player.DisplayStatus();

            // Simuler quest-progression
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("\nSpiller går på quest for at besejre gobliner...\n");
            DisplayEnemyStatus(enemy1);
            player.PerformAttack(enemy1);
            DisplayEnemyStatus(enemy1);
            player.PerformAttack(enemy1);
            DisplayEnemyStatus(enemy1);
            player.PerformAttack(enemy1);
            DisplayEnemyStatus(enemy1);

            DisplayQuestStatus(player, defeatGoblinQuest);

            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("\nSpiller støder på en frygtindgydende goblin...\n");
            DisplayEnemyStatus(enemy2);
            player.PerformAttack(enemy2);
            DisplayEnemyStatus(enemy2);
            player.PerformAttack(enemy2);
            DisplayEnemyStatus(enemy2);
            Console.WriteLine("---------------------------------------------------------------------------------------");

            DisplayQuestStatus(player, slayDragonQuest);

            // Vis endelig spillerstatus
            player.DisplayStatus();

            Console.ReadLine();
        }

        // Metode til at vise status for en fjende
        static void DisplayEnemyStatus(Enemy enemy)
        {
            Console.WriteLine($"{enemy.Name} - Level {enemy.Level} | Sundhed: {enemy.Health}");
        }

        // Metode til at vise status for et quest
        static void DisplayQuestStatus(Player player, Quest quest)
        {
            Console.WriteLine($"Quest Status: {quest.Title} - {quest.Description} | XP: {quest.XP}");
            Console.WriteLine($"Spiller XP: {player.Level}");
        }
    }
}

