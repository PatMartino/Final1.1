using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player1_Soldier : MonoBehaviour
{
    public TextMeshProUGUI gold_Text;
    public float movement_Speed;
    float point= 1000;
    void Update()
    {
        transform.Translate(0, 0, movement_Speed);
        
    }
    private void OnTriggerEnter(Collider other)
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            
            Debug.Log("bum");
        }
    }
}
