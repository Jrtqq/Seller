using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Reputation { get; private set; } = 20;

    private float _speed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _speed * Time.deltaTime;
        }
    }
}
