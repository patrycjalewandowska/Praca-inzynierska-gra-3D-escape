using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationItem : MonoBehaviour
{
    public float x_speed = 0f;
    public float y_speed = 0f;
    public float z_speed = 0.5f;
    public PauseMenu GameIsPause;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(x_speed, y_speed, z_speed);


    }
}