using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotTrading : ITrader
{
    int ITrader.NeededReputation { get; set; } = int.MinValue; //� ��� ������� ��� ������� ������ ���������

    public void Trade() { }
}
