using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    public float forceValue;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 force = new Vector3 (0.0f,0.0f,forceValue);    // 力を設定
        rb.AddForce (force);  // 力を加える

        //離れすぎると自爆
        if(transform.position.z > 50) {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Missile")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
