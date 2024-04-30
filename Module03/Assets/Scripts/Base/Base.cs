using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField]
    private float hp = 5;
    private int energy = 10;

    public float Hp
    {
        get{return hp;}
        set{hp = value;}
    }
        public float Energy
    {
        get{return hp;}
        set{hp = value;}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        hp -= 1;
        Debug.Log("hp: " + hp);
    }
}
