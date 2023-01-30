using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool isDead;

    [SerializeField] ParticleSystem bloodEffect;
    [SerializeField] Transform headTransform;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Arrow")||collision.gameObject.CompareTag("NinjaStar"))
        {
            //Okun ucunda kan efekti var.
            /* Vector2 arrowPos= collision.gameObject.transform.position;
             float arrowSize = collision.gameObject.transform.localScale.x/2;
             headTransform.position = new Vector2(arrowPos.x - arrowSize,arrowPos.y);*/

            Transform arrow = collision.gameObject.transform;
                bool isRight;

            if(arrow.position.x>transform.position.x)   isRight= true;
            else isRight= false;

            headTransform.position = SetPos(arrow.transform.position, arrow.localScale.x / 2, isRight);
            
            bloodEffect.Play(); // kan efektini çalýþtýrýr
            isDead = true;
            collision.gameObject.SetActive(false);
        }
        if(collision.gameObject.CompareTag("Star"))

        {
            collision.gameObject.SetActive(false);
            ScoreManager.starNumber++;
        }
    }
    Vector2 SetPos(Vector2 targetPos,float targetSize, bool isRight)
    {
        Vector2 headPosition;
        if(isRight)
        {
            headPosition = new Vector2(targetPos.x - targetSize, targetPos.y);
        }
        else 
        {
        headPosition=new Vector2 (targetPos.x+ targetSize, targetPos.y);
        }
        
        return headPosition;
    }
}
