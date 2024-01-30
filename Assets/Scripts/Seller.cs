using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Seller : MonoBehaviour
{
    private ITrader[] _behaviours = { new NotTrading(), new FruitTrading(), new ArmorTrading()};

    private void Awake()
    {
        _behaviours = _behaviours.OrderByDescending(x => x.NeededReputation).ToArray();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            for (int i = 0; i < _behaviours.Length; i++)
            {
                if (player.Reputation >= _behaviours[i].NeededReputation)
                {
                    _behaviours[i].Trade();
                    break;
                }
            }
        }
    }
}
