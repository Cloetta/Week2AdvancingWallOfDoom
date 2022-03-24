using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{

    //public GameObject arrivalPoint;
    public float moveSpeed = 10f;
    public Rigidbody2D rb;

    public PlayerHealth player;
    public int arrowDamage = 5;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        rb.velocity = transform.up * moveSpeed;

        Debug.Log(rb.velocity);

        Destroy(gameObject, 6f);



    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Damage player
            player.health -= arrowDamage;

            Destroy(gameObject);
        }
    }
}
