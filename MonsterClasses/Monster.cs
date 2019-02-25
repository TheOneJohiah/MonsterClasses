using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterClasses
{
    public abstract class Monster
    {
        public enum MonsterAction {  Attack, Defend, Retreat }
        private int _id;
        private string _name;
        private int _age;
        private string _color;
        private int _ferociousness;
        private int _toughness;
        private string _catchPhrase;

        public string CatchPhrase
        {
            get { return _catchPhrase; }
            set { _catchPhrase = value; }
        }


        public int Toughness
        {
            get { return _toughness; }
            set { _toughness = value; }
        }

        public int Ferociousness
        {
            get { return _ferociousness; }
            set { _ferociousness = value; }
        }


        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Monster()
        {

        }

        public Monster(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public virtual string Greeting()
        {
            return $"Hello, my name is {_name}";
        }

        public virtual bool IsTough()
        {
            bool isTough = false;
            if (_toughness >= _ferociousness)
            {
                isTough = true;
            }
            return isTough;
        }

        public abstract bool IsHappy();

        public abstract string DCatchPhrase();
    }
}
