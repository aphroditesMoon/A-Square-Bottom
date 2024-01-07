using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTilemaps : MonoBehaviour
{
    public GameObject[] tilemaps;

    private void Update()
    {
        ControlTheTilemaps();
    }

    private void ControlTheTilemaps()
    {
        tilemaps[2].SetActive(!tilemaps[1].activeSelf);
    }

    public void ChangeTheTilemap()
    {
        tilemaps[1].SetActive(!tilemaps[1].activeSelf);
    }
}
