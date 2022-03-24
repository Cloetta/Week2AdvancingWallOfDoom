using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad1;
    public GameObject quad2;
    public GameObject quad3;
    public GameObject quad4;



    private void Update()
    {

        //tried to reuse the spawn at random script but it doesn't work for moving the arrows, they stay static

        //---- TO FIX ----
        //the arrows are supposed to follow the player. Couldn't find a working way to move them.

        //when the player moves on a trigger = shoot

        //when the players moves on another trigger = shoot




    }

    public void SpawnObjects1()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c1 = quad1.GetComponent<MeshCollider>();

        //MeshCollider c2 = quad2.GetComponent<MeshCollider>();

        //MeshCollider c3 = quad3.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int index = 0; index < numberToSpawn; index++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c1.bounds.min.x, c1.bounds.max.x);
            screenY = Random.Range(c1.bounds.min.y, c1.bounds.max.y);

            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);

        }

    }

    public void SpawnObjects2()
    {
        int randomItem = 0;
        GameObject toSpawn;
        //MeshCollider c1 = quad1.GetComponent<MeshCollider>();

        MeshCollider c2 = quad2.GetComponent<MeshCollider>();

        //MeshCollider c3 = quad3.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int index = 0; index < numberToSpawn; index++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c2.bounds.min.x, c2.bounds.max.x);
            screenY = Random.Range(c2.bounds.min.y, c2.bounds.max.y);

            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);


        }

    }

    public void SpawnObjects3()
    {

        int randomItem = 0;
        GameObject toSpawn;
        //MeshCollider c1 = quad1.GetComponent<MeshCollider>();

        //MeshCollider c2 = quad2.GetComponent<MeshCollider>();

        MeshCollider c3 = quad3.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int index = 0; index < numberToSpawn; index++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c3.bounds.min.x, c3.bounds.max.x);
            screenY = Random.Range(c3.bounds.min.y, c3.bounds.max.y);

            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);


        }


    }


    public void SpawnObjects4()
    {

        int randomItem = 0;
        GameObject toSpawn;
        //MeshCollider c1 = quad1.GetComponent<MeshCollider>();

        //MeshCollider c2 = quad2.GetComponent<MeshCollider>();

        MeshCollider c4 = quad4.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int index = 0; index < numberToSpawn; index++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c4.bounds.min.x, c4.bounds.max.x);
            screenY = Random.Range(c4.bounds.min.y, c4.bounds.max.y);

            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);


        }

    }



}
