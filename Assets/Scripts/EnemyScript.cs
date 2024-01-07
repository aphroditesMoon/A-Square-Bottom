using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public float speed = 5f;
    public Transform player;

    void Update()
    {
        if (player != null)
        {
            // Oyuncunun konumuna doğru yönel
            Vector3 direction = player.position - transform.position;
            direction.Normalize();
            
            // Yönelimin doğrultusunda hareket et
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<LevelManager>().RestartLevel();
        }
    }
}
