using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.isDead)
        {

            GameOver();
        }
    }
    void GameOver()
    {

        gameOverPanel.SetActive(true);
    }

}
