using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour
{
    public GameObject ice, walrus, barrel,tire;

    public float spawnrate = 1f;

    float nextspawn = 0f;
    int whattospawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawn)
        {
            whattospawn = Random.Range(1, 4);
            
            Vector3 SpawnPos = new Vector3(Random.Range(-2,2),0, 0);
            switch (whattospawn)
            {
                case 1:
                    Instantiate(ice, SpawnPos, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(walrus, SpawnPos, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(barrel, SpawnPos, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(tire, SpawnPos, Quaternion.identity);
                    break;
            }

            nextspawn = Time.time + spawnrate;
        }
    }
}
