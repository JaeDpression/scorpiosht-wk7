using System;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class MathFSamples : MonoBehaviour
{
    public Slider lerpSlider, pingpongSlider, moveTowardSlider, repeatSlider;
    public float lerpT, pingpongSpeed, moveTowardSpeed = 0;
    public GameObject upDown, leftRight;

        void Start()
    {
        AbsSample();
        RoundSamples();
    }

    // Update is called once per frame
    void Update()
    {
        LerpSamples();
        PingPongSample();
        MoveTowardSample();
        RepeatSample();
        SinSamples();
    }

    public void LerpSamples()
    {
        // Lerp MathF implementation
        // Lerp - Linear intERPolation
        // Way to smoothly move/transition between 2 values

        // float startValue = 0f;
        // float endValue = 10f;
        // float value = Mathf.Lerp(startValue, endValue, lerpT); // t = 0.25
        //Debug.Log(lerpSlider.value);
        lerpT += Time.deltaTime * 0.01f;
        lerpSlider.value = Mathf.Lerp(0, 100, Mathf.Clamp01(lerpT));
        // Clamp (min, max, what variable should we clamp)
        // Mathf.Clamp01 clamps it to Min 0 and Max Value is 1
        // > same as Mathf.Clamp(0,1,<value>)
    }

    public void PingPongSample()
    {
        pingpongSlider.value = Mathf.PingPong(Time.time * pingpongSpeed, pingpongSlider.maxValue);
    }

    public void MoveTowardSample()
    {
        moveTowardSlider.value = Mathf.MoveTowards(moveTowardSlider.value, moveTowardSlider.maxValue, moveTowardSpeed * Time.deltaTime);
    }

    public void AbsSample()
    {
        // Returns positive values
        float absVal = Mathf.Abs(-25);
        // Debug.Log(absVal);
    }

    public void RepeatSample()
    {
        float repeatedValue = Mathf.Repeat(Time.time, 1);
        repeatSlider.value = repeatedValue;
        Debug.Log("Repeated Value: " + repeatedValue);
    }
    public void RoundSamples()
    {
        Debug.Log(Mathf.Round(123.35f));
    }

    public void SinSamples()
    {
        float amplitude = 2f;
        float frequency = 2f;

        Vector3 startPos, startPos2;
        startPos = upDown.transform.position;
        startPos2 = leftRight.transform.position;

        float verticalMovement = MathF.Sin(Time.time * frequency) * amplitude;
        float horizontalMovement = MathF.Cos(Time.time * frequency) * amplitude;
        upDown.transform.position = startPos + new Vector3(0, verticalMovement, 0);
        leftRight.transform.position = startPos2 + new Vector3(horizontalMovement, 0, 0);
    }
}