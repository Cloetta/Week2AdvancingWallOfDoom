using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCollision : MonoBehaviour
{
    public bool isDead = false;
    public bool isWin = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Spikes")
        {
            isDead = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Exit")
        {
            isWin = true;
        }
    }


   
}
