using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 10f;
    private MeshRenderer renderer;
    private Material material;

    private void Start()
    {
        //this.renderer = GetComponent<MeshRenderer>();
        //this.material = renderer.material; 
    }
    // Update is called once per frame
    void Update()
    {
        var renderer = GetComponent<MeshRenderer>();
        var material = renderer.material;
        var offset = material.mainTextureOffset;

        offset.x += Time.deltaTime / scrollSpeed;

        material.mainTextureOffset = offset;
    }
}
