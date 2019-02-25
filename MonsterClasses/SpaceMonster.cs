using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterClasses
{
    public class SpaceMonster : Monster, IBattle
    {
        private string _galaxy;
        private int _spacey;

        public int Spacey
        {
            get { return _spacey; }
            set { _spacey = value; }
        }


        public string Galaxy
        {
            get { return _galaxy; }
            set { _galaxy = value; }
        }

        public override string Greeting()
        {
            return $"Hello, my name is {Name} and I am from the {_galaxy} galaxy.";
        }

        public override bool IsHappy()
        {
            return true;
        }

        public MonsterAction MonsterBattleResponse()
        {
            Random random = new Random();
            int battleResponseNumber = random.Next(0, 101);

            if (battleResponseNumber >= 66)
            {
                return MonsterAction.Attack;
            }
            else if (battleResponseNumber + Ferociousness >= 33)
            {
                return MonsterAction.Defend;
            }
            else
            {
                return MonsterAction.Retreat;
            }
        }
        public override string DCatchPhrase()
        {
            if (_spacey >= 40)
            {
                CatchPhrase = ("Wooooooah maaaan.");
            }
            else
            {
                CatchPhrase = ("Pretty chill.");
            }
            return CatchPhrase;
        }
    }
}
