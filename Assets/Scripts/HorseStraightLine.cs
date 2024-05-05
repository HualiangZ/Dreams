using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class HorseStraightLine : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {

        if(transform.position.x <= -7)
        {
            speed *= -1;
        }else if(transform.position.x >= 7)
        {
            speed *= -1;
        }
        var target = new Vector2(transform.position.x + 14, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}
