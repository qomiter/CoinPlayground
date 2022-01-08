using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinCount = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PickUp();
        Destroy(gameObject);
    }

    void PickUp()
    {
        coinCount++;
    }
}
