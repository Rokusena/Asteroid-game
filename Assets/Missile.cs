using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float missileSpeed;
    public GameObject prefab;
   // public AudioSource explosion;

    void Start()
    {
        
    }
    void Update()
    {
        transform.position += Vector3.up*missileSpeed * Time.deltaTime;
        if(transform.position.y > 15)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Meteor"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Smallermeteors();
           // explosion.Play();
        }
        else if(collision.gameObject.name.Contains("Metteor"))
        {
          //  explosion.Play();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    private void Smallermeteors()
    {
        Vector3 pos = transform.position;
        var rot = Quaternion.Euler(0, 0, 0);
        Instantiate(prefab, pos, rot);
        pos.x += 1f;
        Instantiate(prefab, pos, rot);
    }


}
