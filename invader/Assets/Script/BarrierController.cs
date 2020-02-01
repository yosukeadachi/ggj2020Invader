using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Missile") || (other.gameObject.tag == "EnemyMissile"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
