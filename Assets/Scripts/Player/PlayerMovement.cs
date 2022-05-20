using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isActive = false;
    public BoxCollider2D player;
    [SerializeField] float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<BoxCollider2D>();
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
            Touch screenTouch =Input.GetTouch(0);
            if(screenTouch.phase==TouchPhase.Moved)
            {
                player.transform.position=new Vector3(
                    transform.position.x + screenTouch.deltaPosition.x * speed, transform.position.y + screenTouch.deltaPosition.y * speed, transform.position.z);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("limit"))
        {
            player.transform.position = Vector3.zero;
        }
    }
}
