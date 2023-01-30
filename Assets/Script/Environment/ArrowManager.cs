using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField]  Vector3 finishPos;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPos= transform.position;   
    }

    // Update is called once per frame

    void FixedUpdate()
    {
     if( Vector3.Distance(transform.position, finishPos)>=0.1f)
        {
            transform.Translate(Vector3.left * speed);
        }

        else 
        
        {
            transform.position = startPos;
        }
    }
}
