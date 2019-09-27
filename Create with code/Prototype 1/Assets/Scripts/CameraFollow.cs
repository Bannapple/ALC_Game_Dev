using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0,6,-10);


    // Update is called once per frame
    void Update()
    {
        // Match position of player
        transform.position = player.transform.position + offset;
    }
}
