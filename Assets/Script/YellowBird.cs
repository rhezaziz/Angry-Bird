using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBird : Bird
{
    // Start is called before the first frame update
    [SerializeField]
    public float _boostForce = 100;
    public bool _hasBoost = false;

    public void Boost()
    {
        Debug.Log("Booooost");
        if (State == BirdState.Thrown && !_hasBoost)
        {
            RigidBody.AddForce(RigidBody.velocity * _boostForce);
            _hasBoost = true;
        }
    }

    //public virtual void OnTap()
    //{
    //    
    //}
    public override void OnTap()
    {
        Boost();
    }
}
