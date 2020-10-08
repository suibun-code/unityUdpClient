using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class cubePrefab : MonoBehaviour
{
    public NetworkMan NetManager;
    public Vector3 cubePosition = new Vector3(0, 0, 0);

    public string id;
    // Start is called before the first frame update
    void Start()
    {
        NetManager = GameObject.Find("NetworkMan").GetComponent<NetworkMan>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cubePosition.y += 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            cubePosition.x -= 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            cubePosition.y -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            cubePosition.x += 1;
        }
    }
}
