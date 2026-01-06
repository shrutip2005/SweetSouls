using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundrun : MonoBehaviour
{
    
    float speed =10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newPos=Mathf.Repeat(speed * Time.time,2500f);
        transform.position= Vector2.left * newPos;
    }
}

