using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 1f;
    private Material material;
    private float timeCooldown = 0f;
    void Start()
    {
        transform.position = new Vector3(5, 12, 2);
        transform.localScale = Vector3.one * 2.5f;

        material = Renderer.material;
        
        material.color = new Color(0.5f, 0.0f, 0.0f, 0.0f);
        timeCooldown = Time.time + speed;
    }
    
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);
        if (Time.time >= timeCooldown)
        {
            ChangeColor();
            timeCooldown = Time.time + speed;
        }
    }
    private void ChangeColor()
    {
        float channelRed = 0f, 
            channelGreen = 0f, 
            channelBlue = 0f,
            channelAlpgha = 0f;

        channelRed = RandFloat(channelRed);
        channelGreen = RandFloat(channelGreen);
        channelBlue = RandFloat(channelBlue);
        channelAlpgha = RandFloat(channelAlpgha);

        material.color = new Color(channelRed, channelGreen, channelBlue, channelAlpgha);

    }
    private float RandFloat(float channel) => channel = Random.Range(0.0f, 1.0f);
}
