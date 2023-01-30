using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rotateSpeed;
    [SerializeField] List<Vector2> patrolPositios;

    Vector2 target;

    int index;


        // Start is called before the first frame update
    void Start()
    {
        index= 1;
        target = patrolPositios[index];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
        if (Vector3.Distance(transform.position, patrolPositios[index]) <= 0.05f)
        {
            if (index == patrolPositios.Count - 1) index = 0;
            else index++;
            target = patrolPositios[index];
        }
        
        transform.Rotate(Vector3.forward * rotateSpeed);
    }
}
