using UnityEngine;
using System.Collections;

public class Tembak : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawnPoint;

    public GameObject sudut;
    Sudut sangle;
    int angle;

    public GameObject kecepatan;
    Kecepatan cepat;
    int speed;

    public int shoot;
    public bool bukanTutorial;

    void Start()
    {
        sangle = sudut.GetComponent<Sudut>();
        cepat = kecepatan.GetComponent<Kecepatan>();
    }

	void Update()
    {
        angle = sangle.angle;
        speed = cepat.speed;
	}

	public void Shoot()
    {
        GameObject clone = Instantiate(bullet, spawnPoint.transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        clone.transform.rotation = Quaternion.Euler(0, 0, angle);
        clone.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Mathf.Cos(angle * Mathf.Deg2Rad), speed * Mathf.Sin(angle * Mathf.Deg2Rad));
        if (bukanTutorial)
        {
            shoot += 1;
        }
	}
}
