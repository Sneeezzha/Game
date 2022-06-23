using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    float speed;
    private Transform back_Tranform;
    private float back_Size;
    private float back_pos;
    void Start()
    {
        back_Tranform = GetComponent<Transform>();
        back_Size = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        speed = 1;

        Move();
    }

    public void Move()
    {
        back_pos += speed * Time.deltaTime;
        back_pos = Mathf.Repeat(back_pos, back_Size);
        back_Tranform.position = new Vector3(back_pos,0, 0);
    }
}
