using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speedColor = 1f;
    public float speedRotation = 1f;
    private Material material;
    private float timeCooldown = 0f;
    void Start()
    {
        transform.position = new Vector3(5, 12, 2);
        transform.localScale = Vector3.one * 2.5f;

        material = Renderer.material;
        
        material.color = new Color(0.5f, 0.0f, 0.0f, 0.0f);
        timeCooldown = Time.time + speedColor;
    }
    
    void Update()
    {
        ChangeRotation();
        if (Time.time >= timeCooldown)
        {
            ChangeColor();
            timeCooldown = Time.time + speedColor;
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

        material.color = new Color(channelRed, 
            channelGreen, 
            channelBlue, 
            channelAlpgha);
    }
    private void ChangeRotation()
    {
        float rotationX = 0f, 
            rotationY = 0f, 
            rotationZ = 0f;
        rotationX = RandFloat(rotationX);
        rotationY = RandFloat(rotationY);
        rotationZ = RandFloat(rotationZ);
        transform.Rotate(speedRotation * rotationX * Time.deltaTime, 
            speedRotation * rotationY * Time.deltaTime, 
            speedRotation * rotationZ * Time.deltaTime);
    }
    private float RandFloat(float number) => number = Random.Range(0.0f, 1.0f);
}
