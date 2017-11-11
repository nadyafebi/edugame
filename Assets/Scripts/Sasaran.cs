using UnityEngine;
using System.Collections;

public class Sasaran : MonoBehaviour
{
    public bool tutorial;
    public GameObject button;

    GameManager mgr;

    void Start()
    {
        mgr = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        if (tutorial)
        {
            button.SetActive(true);
        }
        else
        {
            Destroy(gameObject);
            GameObject.Find("Main Camera").GetComponent<RandomTarget>().Spawn();
            mgr.AddScore();
        }
    }
}
