using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject asteroid;
    void Start()
    {
        gameOver.SetActive(false);
    }
    public void crash()
    {
        gameObject.SetActive(false);
        asteroid.SetActive(false);
        gameOver.SetActive(true);
    }
}