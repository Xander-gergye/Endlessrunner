using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI distanceTraveled;
    public GameObject gameOverScreen;
    public Player player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ShowGameOverScreen();
        }
    }
    void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        float roundedDistance = Mathf.Ceil(player.distanceFrom);
        distanceTraveled.text = " " + roundedDistance;
        
    }

    public void GameRestart()
    {
        Debug.Log("Restart the game");
    }


}
