using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmitTest : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public GameObject s3;
    public GameObject s4;
    public GameObject s5;
    public GameObject yn;
    public GameObject namaBox;

    dreamloLeaderBoard board;

    public int score;
    public int y;
    public string nama;

    GameManager mgr;

    void Start()
    {
        board = GetComponent<dreamloLeaderBoard>();
        mgr = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Submit()
    {
        if (s1.GetComponent<Text>().text == "10")
        {
            score += 20;
        }
        if (s2.GetComponent<Text>().text == "10")
        {
            score += 20;
        }
        if (s3.GetComponent<Text>().text == "45")
        {
            score += 20;
        }
        if (s4.GetComponent<Text>().text == "10")
        {
            score += 20;
        }
        if (s5.GetComponent<Text>().text == "30")
        {
            score += 20;
        }

        if (yn.GetComponent<Toggle>().isOn == true)
        {
            y = 1;
        }

        nama = namaBox.GetComponent<Text>().text;

        board.AddScore(nama, score, y);
        mgr.finish = true;
        mgr.SceneChange(1);
    }
}
