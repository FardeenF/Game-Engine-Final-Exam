using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject bullet;

    public float speed = 3.0f;
    public static event Action shootProjectile;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            GameObject firedBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            firedBullet.GetComponent<Rigidbody2D>().velocity = -transform.right * 10.0f;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            GameObject firedBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            firedBullet.GetComponent<Rigidbody2D>().velocity = transform.right * 10.0f;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            GameObject firedBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            firedBullet.GetComponent<Rigidbody2D>().velocity = transform.up * 10.0f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            GameObject firedBullet = Instantiate(bullet, transform.position, Quaternion.identity);

            firedBullet.GetComponent<Rigidbody2D>().velocity = -transform.up * 10.0f;
        }
    }

    private void FixedUpdate()
    {
        //body.velocity = new Vector2(horizontal * speed, vertical * speed);


        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(4, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-4, 0);
        }
        else if(Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0, 4);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0, -4);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }


        


    }


    


}
