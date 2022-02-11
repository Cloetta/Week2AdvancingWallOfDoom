using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeslow : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SlowTime());
        }
    }




    //Make it a skill, give it a cooldown marked into the UI
    IEnumerator SlowTime()
    {
        Time.timeScale = 0.2f;       
        yield return new WaitForSeconds(0.4f); //This is actually 2 seconds (secondstowait / 0.2 timescale is equal to 2 because the time is being slowed)
        Time.timeScale = 1f;
    }



}
