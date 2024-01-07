using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public int machineAmount = 0;
    public TextMeshProUGUI machineAmountInText;

    public float moveSpeed = 5f;

    public Slider soundSfxSlider;
    
    public ParticleSystem ParticleSystem;
    public AudioSource AudioSource;
    public AudioSource AudioSourceSound;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        transform.position = Vector2.MoveTowards(transform.position, mousePos, moveSpeed * Time.deltaTime);

        machineAmountInText.text = machineAmount.ToString();
        
        SoundSfx();
    }
        
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            Debug.Log(":");
            Vector2 moveDirection = transform.position - other.transform.position;
            transform.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime);
        }
    }

    public void SoundSfx()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            AudioSource.volume += 0.1f;
            AudioSourceSound.volume += 0.1f;
            soundSfxSlider.value = AudioSource.volume;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            AudioSource.volume -= 0.1f;
            AudioSourceSound.volume -= 0.1f;
            soundSfxSlider.value = AudioSource.volume;
        }
    }

    public void WinCondition()
    {
        if (machineAmount == 5)
        {
            GetComponent<LevelManager>().NextLevel();
        }
    }
}
