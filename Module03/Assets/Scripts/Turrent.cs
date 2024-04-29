using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Turrent : MonoBehaviour
{
    public float attackDamage;
    public float range;
    public float attackDelay;
    private float timer = 0;
    private List<GameObject> targets;
    public GameObject projectiles;
    public float projectileSpeed;
    // Start is called before the first frame update
    void Start()
    {
        targets = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (targets.Count > 0)
        {
            timer += Time.deltaTime;
            
        }
    }

    private void FixedUpdate()
    {
        if (timer >= attackDelay)
        {
            int closestTarget = GetClosestTargetIndex();
            GameObject projectile = Instantiate(projectiles, transform.position, Quaternion.identity);
            projectile.AddComponent<Rigidbody2D>();
            projectile.GetComponent<Rigidbody2D>().gravityScale = 0;
            projectile.AddComponent<CircleCollider2D>();
            projectile.AddComponent<Projectile>();
            projectile.GetComponent<Projectile>().attackDamage = attackDamage;
            Vector3 direction = targets[closestTarget].transform.position - transform.position;
            direction.Normalize();
            projectile.GetComponent<Rigidbody2D>().AddForceAtPosition(direction * projectileSpeed, transform.position);
            timer = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            targets.Add(collision.gameObject);
        }
    }

    int GetClosestTargetIndex()
    {
        float closesteTarget = (transform.position - targets[0].transform.position).magnitude;
        int index = 0;
        for (int i = 0; i < targets.Count; i++)
        {
            if (targets.Count >= i && (transform.position - targets[i].transform.position).magnitude < closesteTarget)
            {
                closesteTarget = (transform.position - targets[i].transform.position).magnitude;
                index = i; 
            }
        }
        return index;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (targets.Count != 0)
            {
                targets.RemoveAt(0);
            }
        }

    }
}
