using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTrading : ITrader
{
    int ITrader.NeededReputation { get; set; } = 20;
    public void Trade()
    {
        Debug.Log("Торгую фруктами");
    }
}
