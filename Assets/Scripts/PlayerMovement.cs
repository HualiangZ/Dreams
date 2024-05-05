using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public Transform movePointer;
    private Vector2 point;
    public LayerMask colliders;
    public bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        movePointer.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePointer.position, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, movePointer.position) <= 0.02f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePointer.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0), 0.2f, colliders))
                {
                    movePointer.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
                    move = true;
                }
                    
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePointer.position + new Vector3(0, Input.GetAxisRaw("Vertical"), 0), 0.2f, colliders))
                {
                    movePointer.position += new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
                    move = true;
                }
                    
            }
            else
            {
                move = false;
            }
        }
    }




}
