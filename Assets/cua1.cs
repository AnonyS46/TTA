using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cua1 : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            animator.Play("ngankeo1_ra");
        }

        if (Input.GetKey("down"))
        {
            animator.Play("ngankeo1_vao");
        }
    }
}
