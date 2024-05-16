using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdletoCrouch : MonoBehaviour
{
    public Animator animator;
    public float InputX;
    public float InputY;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        InputX = Input.GetAxis("Vertical");
        InputY = Input.GetAxis("Horizontal");
        animator.SetFloat("InputX", InputX);
        animator.SetFloat("InputY", InputY);
    }
}
