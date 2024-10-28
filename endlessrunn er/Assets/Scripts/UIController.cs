using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI distanceTraveled;
    public TextMeshProUGUI coinsCollected;
    public GameObject gameOverScreen;
    public Player player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            ShowGameOverScreen();
        }
    }
    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        float roundedDistance = Mathf.Ceil(player.distanceFrom);
        distanceTraveled.text = " " + roundedDistance;
        coinsCollected.text = " " + player.coinsCollected;
    }

    public void GameRestart()
    {
        Debug.Log("Restart the game");
        SceneManager.LoadScene("SampleScene");
    }

    


}
