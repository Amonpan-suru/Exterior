using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    Animator animator;

    [SerializeField] int randomtime;

    float rantime = 0;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        randomtime = Random.Range(0, 5);
    }

    void Update()
    {
        rantime += Time.deltaTime;
        if (rantime >= randomtime)
        {
            animator.SetBool("ST", true);
        }
    }
}
