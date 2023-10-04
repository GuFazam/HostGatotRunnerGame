using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private Vector3 startScale;
    void Start()
    {
        startScale = transform.localScale;

        float height = Camera.main.orthographicSize * 2; //height = altura
        float width = height * Screen.width / Screen.height; //width = largura

        transform.localScale = new Vector3(width, height, startScale.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
