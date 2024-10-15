using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 velocity = new Vector3(1, 2, 0);
    [SerializeField] Arrow arrow;
    public Color color = Color.yellow;
    SpriteRenderer sr; 
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sr.color = color;
        arrow.transform.position = transform.position;
        arrow.myVector = velocity;

        transform.position += velocity * Time.deltaTime;
        
    }
}
