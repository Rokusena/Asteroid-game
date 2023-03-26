using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public GameObject missile;
    public GameObject Empty;
    public float nextshootTime;
    public float shootInterval;
    public AudioSource shotingsound;

    private void Start()
    {
        nextshootTime = Time.time;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) rb.velocity = new Vector3(-speed, 0, 0);
        if (Input.GetKeyDown(KeyCode.D)) rb.velocity = new Vector3(speed, 0, 0);
        if (Input.GetKeyDown(KeyCode.W)) rb.velocity = new Vector3(0, speed, 0);
        if (Input.GetKeyDown(KeyCode.S)) rb.velocity = new Vector3(0, -speed,0);

        if (Time.time > nextshootTime)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
                nextshootTime += shootInterval;
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Contains("Right"))
        {
            


        }
    }

    private void Shoot()
    {
        Vector3 pos = Empty.transform.position;
        pos.x += 0.3f;
        var rot = Quaternion.Euler(0, 0, 0);
        Instantiate(missile, pos, rot);
        pos.x -= 0.65f;
        Instantiate(missile, pos, rot);
        shotingsound.Play();
    }
}
