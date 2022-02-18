using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public PlayerMovement playerScript;
    public TrapCollision playerCollision;


    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        playerCollision = GameObject.FindGameObjectWithTag("Player").GetComponent<TrapCollision>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerCollision.isDead)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (playerCollision.isWin)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
