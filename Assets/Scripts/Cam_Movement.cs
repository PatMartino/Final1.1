using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Movement : MonoBehaviour
{
    public float movement_Speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)&& transform.position.x < 5.12)
        {
            transform.Translate(movement_Speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)&& transform.position.x> -1.11)
        {
            transform.Translate(-movement_Speed, 0, 0);
        }
    }
}
