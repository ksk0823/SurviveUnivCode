using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockController : MonoBehaviour
{
    public Animator animator;
    public bool isRinging;
    public AudioSource ringSFX;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        ringSFX = GameObject.Find("clockSFX").GetComponent <AudioSource>();
        animator.enabled = false;
        isRinging = false;
    }

    public void RingClock()
    {
        animator.enabled = true;
        this.animator.speed = 1.0f;
        isRinging = true;
        ringSFX.Play();
    }
}
