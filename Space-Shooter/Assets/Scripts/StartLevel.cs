using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
	private Text start;
	private static float started = 0;

    // Start is called before the first frame update
    void Start()
    {
        start = GetComponent<Text>();
        start.enabled = true;
        Time.timeScale = 0;
        if (started == 0){
     		started = 1;   	
        	SceneManager.LoadScene("Scene_000");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        	SceneManager.LoadScene("Scene_001");
        	start.enabled = false;
        	Time.timeScale = 1;
        }
    }
}
