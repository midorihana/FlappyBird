using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool isEndGame = false;
    int gamePoint = 0;
    public Text txtPoint;
    public GameObject pnlEndGame;
    public Button btnRestart;
    public Text txtendPoint;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        isEndGame = false;
        pnlEndGame.SetActive(false);
	}
	
    public void Restart()
    {
        StartGame();
    }

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
	// Update is called once per frame
	void Update () {

        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Reset Game
                Time.timeScale = 0;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
	}

    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point:" + gamePoint.ToString();
    }
    public void EndGame()
    {
        Debug.Log("EndGame");
        isEndGame = true;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtendPoint.text = "Your Point\n" + gamePoint.ToString();
    }
}
