using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SlideScroll : MonoBehaviour
{
    public GameObject target;
    public int value;

    Slider slide;

    RectTransform rekt;

    void Start()
    {
        rekt = target.GetComponent<RectTransform>();
        slide = GetComponent<Slider>();
    }

    void Update()
    {
        value = (int)slide.value;
        rekt.anchoredPosition = new Vector2(0, value);
    }
}
