using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    /* void Start()
    {
        SceneManager.LoadScene("Scene_001");
    }*/

    private static float start = 0;
    // Update is called once per frame
    void Update()
    {
        if(start == 0){
            SceneManager.LoadScene("Scene_001");
            start = 1;
        }

        if(Input.GetKeyDown(KeyCode.R)){
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;
            ShieldControl.hit = 0;
            PlayerControl.health = 3;
            EnemyControl.counter = 0;

            SceneManager.LoadScene("Scene_001");
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;
            ShieldControl.hit = 0;
            PlayerControl.health = 3;
            EnemyControl.counter = 0;

        	SceneManager.LoadScene("Scene_002");
        }
    }
}
