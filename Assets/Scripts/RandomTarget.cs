using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomTarget : MonoBehaviour
{
    public GameObject target;
    public GameObject info;
    public GameObject info1;
    public GameObject goPanel;

    Text infoText;
    Text infoText1;

    public int shoot;

    GameManager manager;

    void Start()
    {
        infoText = info.GetComponent<Text>();
        infoText1 = info1.GetComponent<Text>();
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Spawn();
    }

    public void Spawn()
    {
        if (shoot < 10)
        {
            int r = Random.Range(0, 2);

            Vector3 pos;
            Quaternion rot;

            if (r == 0) // Datar
            {
                pos = new Vector3((int)Random.Range(-4, 7), -3, 0);
                rot = Quaternion.Euler(0, 0, 0);
                infoText.text = (pos.x + 5).ToString();
                infoText1.text = "Jarak Target: ";
            }
            else // Vertical
            {
                pos = new Vector3(0, (int)Random.Range(-1, 2), 0);
                rot = Quaternion.Euler(0, 0, 90);
                infoText.text = (pos.y + 2).ToString();
                infoText1.text = "Tinggi Target: ";
            }

            Instantiate(target, pos, rot);
            shoot += 1;
        }
        else
        {
            manager.GameOver(goPanel);
        }
    }
}
