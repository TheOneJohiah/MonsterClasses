using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterClasses
{
    public interface IBattle
    {
        Monster.MonsterAction MonsterBattleResponse();
    }
    public interface IHurt
    {
        bool MonsterBattleHurt();
    }
}
