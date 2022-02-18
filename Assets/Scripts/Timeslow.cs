using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeslow : MonoBehaviour
{


    //public Text txtCooldown;
    public float cooldownTimer;
    public bool canSlowTime;


    private PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        cooldownTimer = 0;
        canSlowTime = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canSlowTime)
        {
            StartCoroutine(SlowTime());
            TimeSlowCountdown(); //stopping right after the cooldown is starting, so it stays at 9.something forever

        }

        Debug.Log("cooldown: " + cooldownTimer);
    }




    //Make it a skill, give it a cooldown marked into the UI ?
    IEnumerator SlowTime()
    {
        canSlowTime = false;
        Time.timeScale = 0.2f;
        player.moveSpeed = 25;
        yield return new WaitForSeconds(0.4f); //This is actually 2 seconds (secondstowait / 0.2 timescale is equal to 2 because the time is being slowed)
        Time.timeScale = 1f;
        player.moveSpeed = 5f;
        
        //Note: if you change the animation propertiy Update mode to Uscaled time, the animation of the player won't be affected by the time scaling giving the time controlling effect. Although there is delay in the animations start anyway (e.g. jump animation)

    }

    //This is stopping for some reason not giving the chance to reuse the skill, find out why
    void TimeSlowCountdown()
    {
        cooldownTimer = 10;
        //Subtrack time since last called
        cooldownTimer -= Time.deltaTime;

        //Condition to make the text and the filler of the image active according to the status of the skill
        if (cooldownTimer <= 0.0f)
        {
            canSlowTime = true;


            //txtCooldown.gameObject.SetActive(false);
            //imgCooldown.fillAmount = 0.0f;
        }
        else
        {
            //txtCooldown.text = Mathf.RoundToInt(cooldownTimer).ToString();
            //txtCooldown.text = cooldownTimer.ToString();
            //imgCooldown.fillAmount = cooldownTimer / skill.skillCooldown;

            
        }
    }

}
