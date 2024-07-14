using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCheck : MonoBehaviour
{
    private GameObject player;
    public GameObject animP;
    public Animator anim;
    public float distanceToCheck = 50;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float distance = Mathf.Abs(transform.position.y - player.transform.position.y);
        if (distance <= distanceToCheck)
        {
            animP.SetActive(true);
            anim.SetBool("Go", true);
        }
        else
        {
            anim.SetBool("Go", false);
            if (distance + 500f <= distanceToCheck)
                animP.SetActive(false);
        }
    }
}
