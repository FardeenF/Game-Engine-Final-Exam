using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolProjectile : MonoBehaviour
{
    public float time = 2.0f;

    void OnEnable()
    {
        StartCoroutine(DestroyProjectile());
    }

    IEnumerator DestroyProjectile()
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Danger")
        {
            col.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            col.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
