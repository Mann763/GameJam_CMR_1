using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{
    public Animator anim; 

    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Lights").GetComponent<Animator>();
        
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(20.0f);
        
        Flicker();
    }

    void Update()
    {
           
    }

    public void Flicker()
    {
        anim.SetBool("Flicker", true);
    }
}
