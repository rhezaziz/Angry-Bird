using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OwlBird : Bird
{
    public bool _boom = false;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (!_boom)
        {
            Debug.Log("boom");
            StartCoroutine(Kaboom(2));
        }
        
    }
    private IEnumerator Kaboom(float second)
    {
        yield return new WaitForSeconds(second);
        Collider.radius = 1.5f;
    }
}
