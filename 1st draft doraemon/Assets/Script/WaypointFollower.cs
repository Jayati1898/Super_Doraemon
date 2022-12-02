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

    //code for follow player
    //public GameObject player;
    //public float follow_speed;
    //private float distance;
    //public float distanceBetween;
    void Start()
    {
        E_rb = GetComponent<Rigidbody2D>();
        E_Sprite = GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        //code for follow player
        //distance = Vector2.Distance(transform.position, player.transform.position);
        //Vector2 direction = player.transform.position - transform.position;
        //direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //if(distance < distanceBetween)
        //{
            //transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, follow_speed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        //}

        //else
        //{
            //if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
                //{
                    //E_Sprite.flipX = !E_Sprite.flipX;
                    //currentWaypointIndex++;
                    //if (currentWaypointIndex >= waypoints.Length)
                    //{
                        //currentWaypointIndex = 0;
                    //}
                //}
                //transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        //}
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
