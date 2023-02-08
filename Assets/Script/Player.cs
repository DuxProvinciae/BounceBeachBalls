using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent UpdateScore;
    //int Id = 0;

    public delegate void TargetEvents();
    public static event TargetEvents OnTargetTouched;
    
    [SerializeField] private float zForce = 1f;
    [SerializeField] private float xForce = 1f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {   
            GetComponent<Rigidbody>().AddForce(-xForce,0,0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        { 
            GetComponent<Rigidbody>().AddForce(xForce,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {   
            GetComponent<Rigidbody>().AddForce(0,0,-zForce);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {   
            GetComponent<Rigidbody>().AddForce(0,0,zForce);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            UpdateScore?.Invoke();
            OnTargetTouched?.Invoke();
            //Score--;
            //ScoreText.text = "Score : " + Score.ToString();
        }
        
    }
    //public void SelectScenario (int number)
    //{
    //    _appData.ActualScenairio = _appData.Scanarios[number];
    //}

}

