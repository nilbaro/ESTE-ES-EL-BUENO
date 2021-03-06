﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour {

    public GameObject Player;
    private PlayerManager getDamage;

    public Image vida;
    public float numVida;

    public Image energia1;
    public Image energia2;
    public Image energia3;
    public int numEnergia;

    private inicialitzar getCambio;
    private bool change;

    private void Awake()
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        getCambio = Player.GetComponent<inicialitzar>();
        change = getCambio.cambio;

        if (change) vida.fillAmount = 1;

        getDamage = Player.GetComponent<PlayerManager>();
        numVida = getDamage.Vida;
        numEnergia = getDamage.energia;

        vida.fillAmount = numVida / 100;
    }
}
