using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3_ : MonoBehaviour

   
{

    public GameObject Player, Box;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Player && Box) == true)
        {
            Vector3 V_Player = Player.transform.position;
            Vector3 V_Box = Box.transform.position;
            Vector3 przesuniecie = V_Box - V_Player;

            Vector3 V1 = Player.transform.forward;
            Debug.DrawRay(V_Player, V1 * 10f, Color.green);
            Debug.DrawLine(V_Player, V_Box, Color.blue);

            Vector3 od = Vector3.Cross(przesuniecie, Player.transform.up);
            float leftright = Vector3.Dot(od, V1);
            if (leftright >= 0) {
                Debug.Log("right" + leftright);
            }
            else {
                Debug.Log("left" + leftright);
            }
            Debug.DrawRay(V_Player, od, Color.red);

        }
    }
}
