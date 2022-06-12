using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseFollow : MonoBehaviour
{
    private Vector3 mousePoosition;
    public float moveSpeed = 0.1f;
    private Rigidbody2D rb;
    Vector2 position = new Vector2(0, 0);
     
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePoosition = Input.mousePosition;
        mousePoosition = Camera.main.ScreenToWorldPoint(mousePoosition);
        position = Vector2.Lerp(transform.position,mousePoosition,moveSpeed);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
