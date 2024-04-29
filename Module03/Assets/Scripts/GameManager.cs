using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager = null;
    private bool isGameOver = false;
    private EnemySpawn spawner;
    private Base _base;

    public bool IsGameOver
    {
        get{return isGameOver;}
    }
    public static GameManager _GameManager
    {
        get{return gameManager;}
    }
    // Start is called before the first frame update
    void Awake()
    {
        if (gameManager == null){
            gameManager = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        spawner = transform.GetChild(0).GetComponent<EnemySpawn>();
        _base = transform.GetChild(1).GetComponent<Base>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_base == null){
            Debug.Log("NULL OBJECT BASE");
        }
        else if (_base && _base.Hp <= 0f)
        {
            isGameOver = true;
            Debug.Log("Game Over");
        }
        if (spawner.numberOfSpawns <= 0)
        {
           
        }
    }
}

