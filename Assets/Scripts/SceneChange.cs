using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour
{
    public void Change(int num)
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().SceneChange(num);
    }
}
