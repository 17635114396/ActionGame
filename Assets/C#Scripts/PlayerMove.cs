using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private CharacterController cc;
    public float speed = 3f;
    private Animator anim;

    // Start is called before the first frame update
    private void Awake()
    {
        cc = this.GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }
        
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //if (Joystick.h != 0 || Joystick.v != 0) {
        //    h = Joystick.h;v = Joystick.v;
        //}
        if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1f)
        {
            anim.SetBool("walk", true);
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("PlayerRun"))
            {
                Vector3 TargetDir = new Vector3(h, 0, v);
                transform.LookAt(TargetDir + transform.position);
                cc.SimpleMove(transform.forward * speed);
            }
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }
}
