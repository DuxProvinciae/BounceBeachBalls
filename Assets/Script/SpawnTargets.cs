using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    [SerializeField] private GameObject Prefab_Target;
    [SerializeField] private GameObject[] Target1 ;
    private GameObject targetTemp;
    
    private void Start()
        {
                for (int i=0; i< Target1.Length;i++)
                {
                    targetTemp= Instantiate(Prefab_Target,Target1[i].transform.position, Quaternion.identity);
                }
        }

    //private void TargetsSpawner()
    //{
    //    for (int i=0; i< Target1.Length;i++)
    //        {
    //            targetTemp= Instantiate(Prefab_Target,Target1[i].transform.position, Quaternion.identity); 
    //            targetTemp.GetComponent<RandomSpawner>().Prefab_Cube = Prefab_Target;
    //        }
    //}

    //public void SpawnTargets()
    //{
    //    }
    //IEnumerator DelayBeforeSpwan()
    //{
    //    yield return new WaitForSeconds(2f);
    //    
    //    GameObject temp = Instantiate(Prefab_Target), SpawnPosition[Random.Range(0,)]
    //    temp.GetComponent<Target>().Spawner = this;
    //    yield return new WaitForEndOfFrame();
    //}
}
