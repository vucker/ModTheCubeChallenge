using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speedTimer = 2f;
    public float speedRotation = 30f;
    private Material material;
    private float timeCooldown = 0f;
    void Start()
    {
        transform.position = new Vector3(5, 12, 2);
        transform.localScale = Vector3.one * 1.0f;
        material = Renderer.material;

        timeCooldown = Time.time + speedTimer;
    }
    
    void Update()
    {
        ChangeRotation();
        if (Time.time >= timeCooldown)
        {
            ChangeColor();
            ChangeScale();

            timeCooldown = Time.time + speedTimer;
        }
    }
    private void ChangeColor()
    {
        float channelRed = RandFloat(),
            channelGreen = RandFloat(),
            channelBlue = RandFloat(),
            channelAlpha = RandFloat();

        material.color = new Color(channelRed, 
            channelGreen, 
            channelBlue, 
            channelAlpha);
    }
    private void ChangeRotation()
    {
        float rotationX = RandFloat(), 
            rotationY = RandFloat(), 
            rotationZ = RandFloat();

        transform.Rotate(speedRotation * rotationX * Time.deltaTime, 
            speedRotation * rotationY * Time.deltaTime, 
            speedRotation * rotationZ * Time.deltaTime);
    }
    private void ChangeScale()
    {
        float scaleMultiplier = RandFloat();
        transform.localScale = Vector3.one * scaleMultiplier * 10;
    }
    private float RandFloat() => Random.Range(0.0f, 1.0f);
}
