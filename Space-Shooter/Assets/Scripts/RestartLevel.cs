using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private static float level = 1;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)){
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;
            ShieldControl.hit = 0;
            PlayerControl.health = 3;
            EnemyControl.counter = 0;
            if (level == 1)
                SceneManager.LoadScene("Scene_001");
            if (level == 2)
                SceneManager.LoadScene("Scene_002");
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            PlayerScore.playerScore = 0;
            GameOver.isPlayerDead = false;
            Time.timeScale = 1;
            ShieldControl.hit = 0;
            PlayerControl.health = 3;
            EnemyControl.counter = 0;

        	SceneManager.LoadScene("Scene_002");
            level = 2;
        }
    }
}
