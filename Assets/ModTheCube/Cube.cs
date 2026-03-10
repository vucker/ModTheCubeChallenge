using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speedRotatiom = 1f;
    void Start()
    {
        transform.position = new Vector3(5, 12, 2);
        transform.localScale = Vector3.one * 2.5f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

        speedRotatiom = 20f;
    }
    
    void Update()
    {
        transform.Rotate(speedRotatiom * Time.deltaTime, 0.0f, 0.0f);
    }
}
