using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public int numberOfSpawns = 50;
    public float delay;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay && numberOfSpawns > 0 && !GameManager._GameManager.IsGameOver)
        {
            Instantiate(enemy,transform.position,Quaternion.identity);
            timer = 0;
            numberOfSpawns -= 1;
        }
    }
}
