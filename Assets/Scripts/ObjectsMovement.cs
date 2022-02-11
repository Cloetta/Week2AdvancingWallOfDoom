using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{

    public GameObject arrivalPoint;
    public float moveSpeed = 10f;
    public float distance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Target = arrivalPoint.transform.position;
        //Debug.Log("Target" + Target);

        Vector2 Position = this.transform.position;
        //Debug.Log("Position" + Position);

        Vector2 Direction = Target - Position;
        //Debug.Log("Direction" + Direction);

        distance = Vector2.Distance(Position, Target);


        //Checking distance and stops when it's too close to the player
        //With those condition set in this way, enemies and player won't push each other (ONLY when they're near, the constraints are activated. Enabling constraints entirely would make the enemy ignore collisions with the environment)
        Vector2 movement = Vector2.MoveTowards(Position, Target, moveSpeed * Time.deltaTime);

        transform.position = movement;


    }
}
