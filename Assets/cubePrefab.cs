using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using static NetworkMan;

[Serializable]
public class cubePrefab : MonoBehaviour
{
    public NetworkMan NetManager;
    public Player player;
    public Vector3 cubePosition = new Vector3(0, 0, 0);
    public string id;
    // Start is called before the first frame update

    void Start()
    {
        cubePosition = new Vector3(0, 0, 0);
        NetManager = GameObject.Find("NetworkMan").GetComponent<NetworkMan>();
    }

    // Update is called once per frame
    void Update()
    {
        if (NetManager.connectedPlayers.Count != 0)
        {
            if (NetManager.thisID != id)
            {
                transform.position = cubePosition;
                return;
            }
            
            if (Input.GetKey(KeyCode.W))
            {
                cubePosition.y += 1 * Time.deltaTime;
                transform.SetPositionAndRotation(cubePosition, Quaternion.identity);
                Debug.Log("W");
            }

            if (Input.GetKey(KeyCode.A))
            {
                cubePosition.x -= 1 * Time.deltaTime;
                transform.SetPositionAndRotation(cubePosition, Quaternion.identity);
                Debug.Log("A");
            }

            if (Input.GetKey(KeyCode.S))
            {
                cubePosition.y -= 1 * Time.deltaTime;
                transform.SetPositionAndRotation(cubePosition, Quaternion.identity);
                Debug.Log("S");
            }

            if (Input.GetKey(KeyCode.D))
            {
                cubePosition.x += 1 * Time.deltaTime;
                transform.SetPositionAndRotation(cubePosition, Quaternion.identity);
                Debug.Log("D");
            }
        }
    }
}
