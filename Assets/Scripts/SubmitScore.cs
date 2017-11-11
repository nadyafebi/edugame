using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubmitScore : MonoBehaviour
{
    GameManager mgr;
    public GameObject namaBox;
    dreamloLeaderBoard board;

    void Start()
    {
        mgr = GameObject.Find("GameManager").GetComponent<GameManager>();
        board = GetComponent<dreamloLeaderBoard>();
    }

    public void Submit()
    {
        int score = mgr.score;
        string nama = namaBox.GetComponent<Text>().text;

        board.AddScore(nama, score);

        mgr.firstTime = false;
        mgr.SceneChange(1);
    }
}
