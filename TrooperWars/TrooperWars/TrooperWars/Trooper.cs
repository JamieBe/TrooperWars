using TrooperWars.Equipment;
using TrooperWars.Enum;


namespace TrooperWars
{
    class Trooper
    {
        private const int GOOD_GUY_STARTING_HEALTH = 20;
        private const int BAD_GUY_STARTING_HEALTH = 20;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        private Weapon weapon;
        private Armor armor;

        public Trooper(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;

                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                
                    break;
                default:
                    break;
            }
        }

        public void Attack(Trooper enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health = enemy.health - damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(Trooper enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Tools.ColorfulWriteLine($"{enemy.name} is dead!", System.ConsoleColor.Red);
                Tools.ColorfulWriteLine($"{name} is victorious", System.ConsoleColor.Green);

            }
            else
            {
                System.Console.WriteLine($"{name} attacked {enemy.name}.{damage} damage was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }
        }
    }
}
