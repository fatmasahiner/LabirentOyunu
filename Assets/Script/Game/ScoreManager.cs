using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int starNumber;
    [SerializeField] int maxStarNumber;
    [SerializeField] TextMeshProUGUI starText;
    
    // Start is called before the first frame update
    void Start()
    {
        starNumber = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        starText.text= starNumber.ToString()+"/"+maxStarNumber.ToString();
    }
}
