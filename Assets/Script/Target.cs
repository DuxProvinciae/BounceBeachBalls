using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Target : MonoBehaviour
{
    [SerializeField] private float RotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,RotationSpeed,0);
    }

    private void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
        Destroy(gameObject);
        }
    }
}


