using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    private Rigidbody2D E_rb;
    private SpriteRenderer E_Sprite;

    [SerializeField] private float speed = 2f;

    void Start()
    {
        E_rb = GetComponent<Rigidbody2D>();
        E_Sprite = GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            E_Sprite.flipX = !E_Sprite.flipX;
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        
    }
}
