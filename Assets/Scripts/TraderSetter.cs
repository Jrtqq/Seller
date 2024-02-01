using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class TraderSetter
{
    private static ITrader[] _behaviours = {new ArmorTrading(), new FruitTrading(), new NotTrading()};

    public static ITrader GetBehaviour(int playerReputation)
    {
        for (int i = 0; i < _behaviours.Length; i++)
        {
            if (playerReputation >= _behaviours[i].NeededReputation)
            {
                return _behaviours[i];
            }
        }

        return _behaviours[_behaviours.Length - 1];
    }
}
