using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITrader
{
    public int NeededReputation { get; protected set; }

    public void Trade();
}
