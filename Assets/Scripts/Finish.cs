﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")) // win
        {
            // TODO add stuff
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
