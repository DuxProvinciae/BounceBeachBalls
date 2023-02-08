using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Prefab_Cube;

    private void TargetsSpawner()
    {
            for (int i = 0; i < 10; i++)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-36f, 14f), 8f, Random.Range(-12.5f,-61.2f));
                Instantiate(Prefab_Cube, randomSpawnPosition, Quaternion.identity);
            }
    }
    
    /*private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-36f, 14f), 8f, Random.Range(-12.5f,-61.2f));
                Instantiate(Prefab_Cube, randomSpawnPosition, Quaternion.identity);
            }
        }
    }*/
   
   private void OnEnable()
   {
       Player.OnTargetTouched += TargetsSpawner;
   }
    
   private void OnDisable()
   {
       Player.OnTargetTouched -= TargetsSpawner;
   }
    
}
