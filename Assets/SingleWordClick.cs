using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SingleWordClick : MonoBehaviour,IPointerDownHandler {

    [SerializeField] RectTransform rectTransform;
    Rect rect;

   

    // Use this for initialization
    void Start () {
        rect = rectTransform.rect;

    }
    private void Update()
    {
        Debug.Log(rect.Contains(Input.mousePosition));

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(rect.Contains(Input.mousePosition));
    }
}
