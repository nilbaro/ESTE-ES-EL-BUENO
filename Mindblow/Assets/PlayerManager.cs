﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	Rigidbody2D player;

	public Transform NAVE;

    public float Vida;
    public int energia;

    private inicialitzar getCambio;
    public GameObject Player;
    public bool change = false;

    public AudioClip sonidoAu;
    public AudioSource fuenteDeAudioAu;

    bool dead = false;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
		player = GetComponent<Rigidbody2D>();
        Vida = 100;
        energia = 3;
	}

	// Update is called once per frame
	void Update () {
        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        if (Vida < 1 && !dead)
        {
            energia--;
            dead = true;
        }

        if (change)
        {
            Vida = 100;
            dead = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Compas")
        {
            player.velocity = new Vector2(25, 25);
            Vida -= 2;
            fuenteDeAudioAu.clip = sonidoAu;
            fuenteDeAudioAu.Play();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "Enemigo" ||
            col.gameObject.tag == "Enemigo 2" ||
            col.gameObject.tag == "Enemigo 3" ||
            col.gameObject.tag == "Enemigo 4" ||
            col.gameObject.tag == "Enemigo 5" ||
            col.gameObject.tag == "Enemigo 6" ||
            col.gameObject.tag == "Enemigo 7" ||

            col.gameObject.tag == "Enemy Ball" ||
            col.gameObject.tag == "Enemy Ball 2" ||
            col.gameObject.tag == "Enemy Ball 3" ||
            col.gameObject.tag == "Enemy Ball 4" ||
            col.gameObject.tag == "Enemy Ball 5" ||
            col.gameObject.tag == "Enemy Ball 6" ||
            col.gameObject.tag == "Enemy Ball 7" ||
            col.gameObject.tag == "Enemy Ball 8" ||
            col.gameObject.tag == "Enemy Ball 9" ||

            col.gameObject.tag == "Elemento Nocivo" ||
            col.gameObject.tag == "Elemento Nocivo 2" ||
            col.gameObject.tag == "Rebotante 1" ||
            col.gameObject.tag == "Rebotante 2" ||
            col.gameObject.tag == "Rebotante 3" ||
            col.gameObject.tag == "Rebotante 4" ||
            col.gameObject.tag == "Rebotante 5" ||
            col.gameObject.tag == "Rebotante 6" ||
            col.gameObject.tag == "Rebotante 7" ||
            col.gameObject.tag == "Rebotante 8" ||
            col.gameObject.tag == "Rebotante 9" ||
            col.gameObject.tag == "Rebotante 10" ||
            col.gameObject.tag == "Rebotante 11" ||
            col.gameObject.tag == "Rebotante 12" ||
            col.gameObject.tag == "Rebotante 13" ||
            col.gameObject.tag == "Rebotante 14" ||

            col.gameObject.tag == "Enemigo 8" ||
            col.gameObject.tag == "Enemigo 9" ||
            col.gameObject.tag == "Enemigo 10" ||
            col.gameObject.tag == "Enemigo 11" ||
            col.gameObject.tag == "Enemigo 12" ||
            col.gameObject.tag == "Enemigo 13" ||
            col.gameObject.tag == "Enemigo 14" ||
            col.gameObject.tag == "Enemigo 15" ||

            col.gameObject.tag == "Compas" ||
            col.gameObject.tag == "Compas 1" ||
            col.gameObject.tag == "Compas 2" ||
            col.gameObject.tag == "Compas 3" ||
            col.gameObject.tag == "Compas 4" ||
            col.gameObject.tag == "Compas 5" ||
            col.gameObject.tag == "Compas 6" ||
            col.gameObject.tag == "Compas 7" ||
            col.gameObject.tag == "Compas 8" ||
            col.gameObject.tag == "Compas 9" ||
            col.gameObject.tag == "Compas 10" ||

            col.gameObject.tag == "Dibujante 1" ||
            col.gameObject.tag == "Dibujante 2" ||
            col.gameObject.tag == "Dibujante 3" ||
            col.gameObject.tag == "Dibujante 4" ||
            col.gameObject.tag == "Dibujante 5" ||
            col.gameObject.tag == "Lanzador de Esferas" ||
            col.gameObject.tag == "Justice Flash" ||
            col.gameObject.tag == "Boss 2" ||

            col.gameObject.tag == "Enemigo 16" ||
            col.gameObject.tag == "Enemigo 17" ||
            col.gameObject.tag == "Enemigo 18" ||
            col.gameObject.tag == "Enemigo 19" ||

            col.gameObject.tag == "Enemigo 3.1" ||
            col.gameObject.tag == "Enemigo 3.2" ||
            col.gameObject.tag == "Enemigo 3.3" ||
            col.gameObject.tag == "Enemigo 3.4"||
            col.gameObject.tag == "Mortero 1" ||
            col.gameObject.tag == "Mortero 3" ||
            col.gameObject.tag == "Laser Pistol 1" ||
            col.gameObject.tag == "Laser Pistol 2" ||
            col.gameObject.tag == "Zona Laser" ||
            col.gameObject.tag == "MiniBoss" ||
            col.gameObject.tag == "Boss 3" ||


            col.gameObject.tag == "Area de Explosion") //|| col.tag == "OtroEnemigo")
        {
            if (col.transform.localPosition.x < NAVE.localPosition.x)
            {
                player.velocity = new Vector2(25, 25);
                Vida -= 2;
                fuenteDeAudioAu.clip = sonidoAu;
                fuenteDeAudioAu.Play();
            }

            else
            {
                player.velocity = new Vector2(-25, 25);
                Vida -= 2;
                fuenteDeAudioAu.clip = sonidoAu;
                fuenteDeAudioAu.Play();
            }
        }

        if (col.gameObject.tag == "Lava")
        {
            player.velocity = new Vector2(-25, 25);
            Vida -= 2;
            fuenteDeAudioAu.clip = sonidoAu;
            fuenteDeAudioAu.Play();
        }

        if (col.gameObject.tag == "Obstaculos") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(-25, 25);
        }

        if (col.gameObject.tag == "Trampolin") //|| col.tag == "OtroEnemigo")
        {
            player.velocity = new Vector2(0, 100);
        }

        if (col.gameObject.tag == "Curs Navet") Vida = 0;
    }
}
