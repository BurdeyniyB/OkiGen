using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent <Animator> ();

        anim.Play("idle");
    }

    void Update()
    {

    }
}
