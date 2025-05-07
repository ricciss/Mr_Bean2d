using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JiggleScript : MonoBehaviour
{
    [Range(0, 1)]
    public float power = 0.1f;

    [Header("Position Jiggler")]
    public bool positionJiggler = true;
    public Vector3 positionJigglerAmount;
    [Range(0, 100)]
    public float positionFrequency = 10f;
    float positionTime;
    Vector3 basePosition;

    [Header("Rotation Jiggler")]
    public bool rotationJiggler = true;
    public Vector3 rotationJigglerAmount;
    [Range(0, 100)]
    public float rotationFrequency = 10f;
    float rotationTime;
    Quaternion baseRotation;

    [Header("Scale Jiggler")]
    public bool scaleJiggler = true;
    public Vector3 scaleJigglerAmount = new Vector3(0.1f, -0.1f, 0.1f);
    [Range(0, 100)]
    public float scaleFrequency = 10f;
    float scaleTime;
    Vector3 baseScale;

    private void Start()
    {
        basePosition = transform.localPosition;
        baseRotation = transform.rotation;
        baseScale = transform.localScale;
    }
    private void Update()
    {
        var dt = Time.deltaTime;
        positionTime += dt * positionFrequency;
        rotationTime += dt * rotationFrequency;
        scaleTime += dt * scaleFrequency;
        if (positionJiggler)
            transform.localPosition = basePosition + positionJigglerAmount * Mathf.Sin(positionTime) * power;

        if(rotationJiggler)
            transform.localRotation = baseRotation * Quaternion.Euler(rotationJigglerAmount * Mathf.Sin(rotationTime) * power);

        if(scaleJiggler)
            transform.localScale = baseScale + scaleJigglerAmount * Mathf.Sin(scaleTime) * power;   
    }
}
