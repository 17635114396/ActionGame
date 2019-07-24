using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimTiorController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Sta();
    }
    private void Sta()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("PlayerStand"))
        {
            anim.SetBool("attackA", false);
            anim.SetBool("attackRange", false);
            anim.SetBool("attackGun", false);
            anim.SetBool("attackB", false);
        }
    }
    public void Nor() {
        anim.SetBool("attackA", true);  
    }
    public void Ran() {
        anim.SetBool("attackRange", true);
    }
    public void Red() {
        anim.SetBool("attackA", true);
    }
}
