using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    private Quaternion StartRotation;
    // Start is called before the first frame update
    void Start()
    {
        StartRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetToStartRotation()
    {
        transform.rotation = StartRotation;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}