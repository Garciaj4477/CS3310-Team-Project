using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject TallObsticle;
    
    [SerializeField]
    public int TallObsticlesRepeating = 6;

    void Start()
    {
        //GenerateObjects();
    }

    void GenerateObject(GameObject go, int amount)
    {
        if (go == null)
        {
            return;
        }

        int distanceFromStart = 800;

        for (int i = 0; i < amount; i++)
        {
            for (int k = 0; k < Random.Range(1, 5); k++)
            {
                GameObject tmp = Instantiate(go);
                tmp.gameObject.transform.position = new Vector3(Random.Range(0,4), 1.0f, distanceFromStart);
                distanceFromStart = distanceFromStart + 5;
            }
            distanceFromStart = distanceFromStart + 25;

            for (int k = 0; k < Random.Range(1, 5); k++)
            {
                GameObject tmp = Instantiate(go);
                tmp.gameObject.transform.position = new Vector3(Random.Range(-4, 0), 1.0f, distanceFromStart);
                distanceFromStart = distanceFromStart + 5;
            }
            distanceFromStart = distanceFromStart + 25;
        }
    }

    public void GenerateObjects()
    {
        GenerateObject(TallObsticle, TallObsticlesRepeating);
    }

    public void SpawnTallObsticles()
    {



    }

}
