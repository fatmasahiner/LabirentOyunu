using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{
    [SerializeField]Transform target;
    [SerializeField] float minX,maxX,minY,maxY;
    Vector2 targetPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPos.x=Mathf.Clamp(target.position.x, minX, maxX); 
        targetPos.y=Mathf.Clamp(target.position.y, minY, maxY);
        transform.position=new Vector3 (targetPos.x,targetPos.y, -10);
    }
}
