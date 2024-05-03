using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorScript : MonoBehaviour
{
    public float speed = 5f;
    public Transform movePointer;
    public Transform movePointer2;

    public LayerMask colliders;
    // Start is called before the first frame update
    void Start()
    {
        movePointer.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePointer.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePointer.position) <= 0.02f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePointer.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0), 0.2f, colliders))
                {
                    if(!Physics2D.OverlapCircle(movePointer2.position + new Vector3(Input.GetAxisRaw("Horizontal"),0, 0), 0.2f, colliders))
                    {
                        movePointer.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
                    }
                    
                }
                    
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePointer.position + new Vector3(0, -Input.GetAxisRaw("Vertical"), 0), 0.2f, colliders))
                {
                    if(!Physics2D.OverlapCircle(movePointer2.position + new Vector3(0, Input.GetAxisRaw("Vertical"), 0), 0.2f, colliders))
                    {
                        movePointer.position += new Vector3(0, -Input.GetAxisRaw("Vertical"), 0);
                    }
                    
                }
                    
            }
        }
    }
}
