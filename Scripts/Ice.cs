﻿using UnityEngine;

public class Ice : MonoBehaviour
{
    public GameObject IceShatter;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 10)
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        GameObject shatter = Instantiate(IceShatter, transform.position, Quaternion.identity);
        GameManager.Instance.AddScore(500, transform.position, Color.white);
        Destroy(shatter, 2);
        GameManager.Instance.IceDestruction.Play();      
        Destroy(gameObject);
    }
}
