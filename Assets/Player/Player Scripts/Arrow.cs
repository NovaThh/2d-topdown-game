using System.Collections;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    { 
       StartCoroutine(DeathDelay());
    }

    IEnumerator DeathDelay() {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Wall"))
        {
            // Destroy the bullet when it touches the player or a wall
            Destroy(gameObject);
        }
    }

}
