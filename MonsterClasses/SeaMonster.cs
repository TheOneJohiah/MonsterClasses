using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterClasses
{
    public class SeaMonster : Monster, IHurt
    {
        private string _homeSea;
        private bool _hasGills;
        private int _fishy;


        public int Fishy
        {
            get { return _fishy; }
            set { _fishy = value; }
        }

        public string HomeSea
        {
            get { return _homeSea; }
            set { _homeSea = value; }
        }

        public bool HasGills
        {
            get { return _hasGills; }
            set { _hasGills = value; }
        }

        public override bool IsHappy()
        {
            return _hasGills ? true : false;
        }

        public SeaMonster(bool HasGills, string HomeSea)
        {
            _homeSea = HomeSea;
            _hasGills = HasGills;
        }

        public SeaMonster()
        {

        }

        public bool MonsterBattleHurt()
        {
            bool monsterBattleHurt = false;
            if (_fishy >= 80)
            {
                monsterBattleHurt = true;
            }
            else
            {
                monsterBattleHurt = false;
            }
            return monsterBattleHurt;
        }

        public override string DCatchPhrase()
        {
            if (_fishy >= 40)
            {
                CatchPhrase = ("Can't catch me, I'm a soggy gingerbread man!");
            }
            else
            {
                CatchPhrase = ("I'm not that fishy and that's how I like it.");
            }
            return CatchPhrase;
        }
    }
}
