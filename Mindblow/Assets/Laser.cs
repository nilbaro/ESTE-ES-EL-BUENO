﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public float tiempoRecarga;
    public float tiempoCiclo;
    public float posX;
    public float posY;

    float tiempo;

    public GameObject laser;
    public Transform transformLaser;

    public AudioClip sonidoLase;
    public AudioSource fuenteDeAudioLaser;

    private bool reproduint = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;

        if (tiempo >= tiempoRecarga && tiempo <= tiempoCiclo)
        {
            transformLaser.localPosition = new Vector2(posX, posY);
            if (!reproduint)
            {
                fuenteDeAudioLaser.clip = sonidoLase;
                fuenteDeAudioLaser.Play();
                reproduint = true;
            }
            //Debug.Log("entra");
        }
        else
        {
            reproduint = false;
            transformLaser.localPosition = new Vector2(600, 600);
            if (tiempo > tiempoCiclo)
            {
                tiempo = 0;
            }
        }
    }
}
