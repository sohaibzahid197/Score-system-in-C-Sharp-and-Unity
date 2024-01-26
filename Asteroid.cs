using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Asteroid : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        PlayerHealth ph = other.GetComponent<PlayerHealth>();
        if (ph == null)
        {
            return;
        }
        ph.crash();
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}