using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{

	private Transform enemyHolder;
	public float speed;

	public GameObject shot;
	public Text winText;
	public float fireRate = 3.3f;

    //counter for legs
    public static float counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        enemyHolder = GetComponent<Transform> ();
        InvokeRepeating("EnemyShot", 0.2f, fireRate);
    }

    void MoveEnemy()
    {
    	enemyHolder.position += Vector3.right * speed;
    	foreach(Transform enemy in enemyHolder){
    		if (enemy.position.x < -10 || enemy.position.x > 10){
    			speed = -speed;
    			enemyHolder.position += Vector3.down * 0.5f;
    			return;
    		}

    		//EnemyBulletControl -> replaced by invoke
            //if (Random.value > fireRate){
            //    Instantiate(shot, enemy.position, enemy.rotation);
            //}


    		if(enemy.position.y <= -4){
    			GameOver.isPlayerDead = true;
    			Time.timeScale = 0;
    		}
    	}

        /* Not needed it only one enemy
    	if(enemyHolder.childCount == 1){
    		CancelInvoke();
    		InvokeRepeating("MoveEnemy", 0.1f, 0.25f);

            //InvokeRepeating("EnemyShot", 0.2f, 0.5f);
    	}*/

    	if(enemyHolder.childCount == 0){
    		winText.enabled = true;
    	}
    }

    void EnemyShot()
    {
        foreach(Transform enemy in enemyHolder){
            Instantiate(shot, enemy.position, enemy.rotation);
        }
    }
}
