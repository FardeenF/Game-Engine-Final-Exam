using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LaunchProjectile : MonoBehaviour
{
    public float projectileForce = 20.0f;
    GameObject projectile;
    public static event Action shootProjectile;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            projectile = ProjectilePool.SharedInstance.GetPooledObject();

            if (projectile != null)
            {
                projectile.transform.position = this.transform.position - new Vector3(1.0f, 0.0f, 0.0f);
                projectile.transform.rotation = Quaternion.Euler(this.transform.forward);
                projectile.SetActive(true);

                projectile.GetComponent<Rigidbody2D>().velocity = -transform.right * projectileForce;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            projectile = ProjectilePool.SharedInstance.GetPooledObject();

            if (projectile != null)
            {
                projectile.transform.position = this.transform.position + new Vector3(1.0f, 0.0f, 0.0f);
                projectile.transform.rotation = Quaternion.Euler(this.transform.forward);
                projectile.SetActive(true);

                projectile.GetComponent<Rigidbody2D>().velocity = transform.right * projectileForce;
            }
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            projectile = ProjectilePool.SharedInstance.GetPooledObject();

            if (projectile != null)
            {
                projectile.transform.position = this.transform.position + new Vector3(0.0f, 1.0f, 0.0f);
                projectile.transform.rotation = Quaternion.Euler(this.transform.forward);
                projectile.SetActive(true);

                projectile.GetComponent<Rigidbody2D>().velocity = transform.up * projectileForce;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            #region observer
            shootProjectile?.Invoke();
            #endregion

            projectile = ProjectilePool.SharedInstance.GetPooledObject();

            if (projectile != null)
            {
                projectile.transform.position = this.transform.position - new Vector3(0.0f, 1.0f, 0.0f);
                projectile.transform.rotation = Quaternion.Euler(this.transform.forward);
                projectile.SetActive(true);

                projectile.GetComponent<Rigidbody2D>().velocity = -transform.up * projectileForce;
            }
        }
    }
}
