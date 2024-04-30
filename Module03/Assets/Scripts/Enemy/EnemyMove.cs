using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float hp = 3f;
    public float speed = 0.5f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.down * Time.deltaTime * speed;
        if (GameManager._GameManager.IsGameOver)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Base")
        {
            Destroy(this.gameObject);
        }
        if (collider.gameObject.GetComponent<CircleCollider2D>().gameObject.tag == "Projectile")
        {
            hp -= collider.gameObject.GetComponent<CircleCollider2D>().GetComponent<Projectile>().attackDamage;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
