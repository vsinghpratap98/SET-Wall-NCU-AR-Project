using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //declare
    private Animator anim;
    void Start(){
        // initialize
        anim = this.GetComponent<Animator>();
    }
    public void ChangeAnimation(){
        if(anim.GetBool("alive") == true){
            anim.SetBool("alive", false);
        }
        else{
            anim.SetBool("alive", true);
        }
    }
}
