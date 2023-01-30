using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour
{
    public static bool isNextLevel;
    [SerializeField] GameObject finishPanel;
    [SerializeField] List<GameObject> stars;

    [SerializeField] List<ParticleSystem> confetties;
   

    // Start is called before the first frame update
    void Start()
    {
        isNextLevel = false;  
    }

    // Update is called once per frame
    void Update()
    {
       if(isNextLevel)
        {
            NextLevel();

        }


    }
        void NextLevel()
    {
       isNextLevel= false;

        foreach(ParticleSystem confetti in confetties)
        {
            confetti.Play();
        }


        finishPanel.SetActive(true);
        if (ScoreManager.starNumber > 0)
        {
            for (int i=0; i<ScoreManager.starNumber; i++) 
            {
                stars[i].SetActive(true);
            }
        }
       
    }

    


}
