using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float zForce = 1f;
    [SerializeField] private float xForce = 1f;
    [SerializeField] private int Score = 0;
    [SerializeField] private TMP_Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Score--;
            ScoreText.text = "Score : " + Score.ToString();
        }
        
    }
    
}

