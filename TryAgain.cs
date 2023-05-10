using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgain : MonoBehaviour, IPointerDownHandler
{
    public Text lastRezult;
    public Text bestRezult;
    public Text LivesLeft;
    private GameHalper gameHalper;

    void Start()
    {
        gameHalper = FindObjectOfType<GameHalper>(); // Get reference to Player object
    }
    public void LoadScene(int sceneid)
    {
        if (sceneid == 1)
        SceneManager.LoadScene(1);
        
     
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        LoadScene(1);
        gameHalper.LivesLeft.text = gameHalper.loadScene.ToString();
    }

    public void Update()
    {
        bestRezult.text = PlayerPrefs.GetString("highScore");
        lastRezult.text = PlayerPrefs.GetString("lastRezult");
        //gameHalper.loadScene--;
    }

    
}
