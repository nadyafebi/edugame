using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
    public GameObject cannon;
    public GameObject sudut;
    Sudut sangle;

    int angle;

    void Start()
    {
        sangle = sudut.GetComponent<Sudut>();
	}
	
	void Update()
    {
        angle = sangle.angle;
        cannon.transform.eulerAngles = new Vector3(0, 0, angle - 37.5f);
	}
}
