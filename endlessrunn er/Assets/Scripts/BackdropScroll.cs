using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackdropScroll : MonoBehaviour
{
    public SpriteRenderer renderer;
    public float speed = 1f;
    public float offset = 0f;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        offset += Time.deltaTime * speed;
        renderer.material.mainTextureOffset = new Vector2(offset, 0);
    }
}
