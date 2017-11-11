using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sudut : MonoBehaviour
{
    public int angle = 0;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = angle.ToString();
    }

    public void ChangeAngle(int num)
    {
        if ((angle + num) > 90)
        {
            angle = 90;
        }
        else if ((angle + num) < 0)
        {
            angle = 0;
        }
        else
        {
            angle += num;
        }
    }
}
