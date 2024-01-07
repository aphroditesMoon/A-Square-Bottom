using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMachines : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            other.GetComponent<ControlTilemaps>().ChangeTheTilemap();
            var x = other.GetComponent<PlayerMovement>();
            x.machineAmount += 1;
            x.WinCondition();
            x.ParticleSystem.transform.position = gameObject.transform.position;
            x.ParticleSystem.Play();
            x.AudioSource.Play();
        }
    }
}
