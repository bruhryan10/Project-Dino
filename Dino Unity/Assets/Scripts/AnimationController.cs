using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] Animator playerAnim;

    void Start()
    {

    }

    void Update()
    {
        //playerAnim.Play("Dino_wheel");
        //playerAnim.Play("Dino_Idle");

    }
    public void AnimMove(float direction, float velocity)
    {
        if (IsAnimationPlaying("Dino_Jump"))
            return;
        if (direction > 0f)
            playerAnim.Play("DinoWalk_Right");
        if (direction < 0f)
            playerAnim.Play("DinoWalk_Left");
/*        if (velocity < 0.03)
            playerAnim.Play("Dino_Idle");*/
    }
    public void AnimJump(float direction)
    {
        //if (direction > 0f)
/*            playerAnim.Play("Dino_Jump");

        Debug.Log("Anim Jump Ran!");*/
    }
    bool IsAnimationPlaying(string animName)
    {
        return playerAnim.GetCurrentAnimatorStateInfo(0).IsName(animName);
    }
}
