using TrooperWars.Enum;
namespace TrooperWars.Equipment
{
    class Weapon
    {
        private const int GOOD_GAUY_DAMAGE = 5;
        private const int BAD_GAUY_DAMAGE = 5;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;

            }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GAUY_DAMAGE;

                    break;
                case Faction.BadGuy:
                    damage = BAD_GAUY_DAMAGE;
                    break;
                default:
                    break;
            }


        }
    }
}

