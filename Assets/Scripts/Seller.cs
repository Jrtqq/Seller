using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Seller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            TraderSetter.GetBehaviour(player.Reputation).Trade();
        }
    }
}
