using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject boxenemy1;
    public GameObject boxenemy2;
    public GameObject boxenemy3;
    public GameObject boxenemy4;
    public GameObject boxenemy5;

    float enemyspawner = 1f;
    float count = 0;
    logicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    void Update()
    {
        if (count < enemyspawner)
        {
            count += Time.deltaTime;
        }
        else
        {
            int spawnEnemy = Random.Range(0, 5);
            switch(spawnEnemy)
            {
                case 0:
                    Instantiate(boxenemy1,transform.position,transform.rotation);
                    break;

                case 1:
                    Instantiate(boxenemy2, transform.position, transform.rotation);
                    break;
                case 2:
                    Instantiate(boxenemy3, transform.position, transform.rotation);
                    break;
                case 3:
                    Instantiate(boxenemy4, transform.position, transform.rotation);
                    break;
                case 4:
                    Instantiate(boxenemy5, transform.position, transform.rotation);
                    break;
            }    

            count = 0;
        }
        UpSpeed();
    }

    void UpSpeed()
    {
        if (logic.PlayerScore % 5 == 0 && logic.PlayerScore != 0)
        {
            MoveEnemy.globalMoveSpeed += 1 * Time.deltaTime;
          
        }
    }
}
