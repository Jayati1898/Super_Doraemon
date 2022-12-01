using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_level2 : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y - 1.5f, transform.position.z);
    }
}
