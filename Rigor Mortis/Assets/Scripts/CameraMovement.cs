﻿using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, -1);

    void FixedUpdate()
    {
        if (player)
        {
            transform.position = new Vector3(
                player.transform.position.x + offset.x + 7,
                player.transform.position.y + offset.y + 1,
                player.transform.position.z + offset.z);
        }
    }
}