using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoText : MonoBehaviour
{
    GameManager mgr;
    Text text;

	// Use this for initialization
	void Start ()
    {
        mgr = GameObject.Find("GameManager").GetComponent<GameManager>();
        text = GetComponent<Text>();
	}

    // Update is called once per frame
    void Update()
    {
        if (mgr.firstTime == false && mgr.finish == false)
        {
            text.text = "Klik Tes untuk memulai tes. Kalau masih belum yakin, klik Main.";
        }
        if (mgr.finish == true)
        {
            text.text = "Terima kasih! :)";
        }
	}
}
