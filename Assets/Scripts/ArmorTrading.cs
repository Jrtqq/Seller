using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorTrading : ITrader
{
    int ITrader.NeededReputation { get; set; } = 100;

    public void Trade()
    {
        Debug.Log("Торгую бронёй");
    }
}
