using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public enum States
    {
        StartMenu,
        Tutorial,
        Game,
        Test
    }

    public States state = States.StartMenu;

    public int score;
    public int sasaran;
    public int shoot;

    public int nilai;

    public GameObject infoAwal;
    public bool firstTime = true;
    public bool finish = false;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        SceneChange(1);
    }

	void Update()
    {
        switch (state)
        {
            case States.StartMenu:
                break;
        }
    }

    public void SceneChange(int num)
    {
        if (num == 1)
        {
            state = States.StartMenu;
        }
        if (num == 2)
        {
            state = States.Tutorial;
        }
        if (num == 5)
        {
            state = States.Game;
        }
        if (num == 6)
        {
            state = States.Test;
        }
        Application.LoadLevel(num);
    }

    public void AddScore()
    {
        Tembak tembak = GameObject.Find("Tembak").GetComponent<Tembak>();

        score += (11 - tembak.shoot);
        tembak.shoot = 0;
        GameObject.Find("Skor").GetComponent<Text>().text = "Skor: " + score;
    }

    public void GameOver(GameObject goP)
    {
        goP.SetActive(true);
    }
}
