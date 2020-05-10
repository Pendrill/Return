using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpdateShadow : MonoBehaviour
{
    public RectTransform portrait;
    public RectTransform shadow;

    public float xOffset = 0f;
    public float yOffset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        shadow.sizeDelta = new Vector2(portrait.sizeDelta.x, portrait.sizeDelta.y);
        //shadow.sizeDelta.y = portrait.sizeDelta.y;
    }

    // Update is called once per frame
    void Update()
    {
        shadow.anchoredPosition = new Vector2(portrait.anchoredPosition.x + xOffset, portrait.anchoredPosition.y + yOffset);
        //shadow.anchoredPosition.x = portrait.anchoredPosition.x + xOffset;
        //shadow.anchoredPosition.y = portrait.anchoredPosition.y + yOffset;
    }
}