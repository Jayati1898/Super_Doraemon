using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float yOffset = 1f;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, yOffset, transform.position.z);
    }
}
