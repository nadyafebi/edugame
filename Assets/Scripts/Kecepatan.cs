using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Kecepatan : MonoBehaviour
{
    public int speed = 0;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = speed.ToString();
    }

    public void ChangeSpeed(int num)
    {
        if ((speed + num) > 15)
        {
            speed = 15;
        }
        else if ((speed + num) < 0)
        {
            speed = 0;
        }
        else
        {
            speed += num;
        }
    }
}
