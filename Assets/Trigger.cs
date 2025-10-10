using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Animator animator;

    public void PlayAnimation()
    {
        animator.SetTrigger("HitButton");
        Debug.Log("Hit button Triggered!");

    }
}