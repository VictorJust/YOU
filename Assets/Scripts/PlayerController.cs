using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    [SerializeField] private GameObject player;
    // Set player's movement
    [SerializeField] private float speed = 10;
    private float verticalInput;
    private float horizontalInput;

    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        
        player.transform.Translate(movement * speed * Time.deltaTime);
        
        // Keep player within the screen
        Vector3 position = Camera.main.WorldToViewportPoint (transform.position);
        position.x = Mathf.Clamp01(position.x);
        position.y = Mathf.Clamp01(position.y);
        transform.position = Camera.main.ViewportToWorldPoint(position);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(player);
        gameManager.isGameActive = false;
    }
}
