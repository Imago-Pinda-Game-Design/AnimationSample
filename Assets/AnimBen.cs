using UnityEngine;

public class AnimBen : MonoBehaviour
{
    public Animator Animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animator.SetTrigger("Jump");
        }

        Animator.SetBool("Walking", Input.GetKey(KeyCode.RightArrow));
    }
}
