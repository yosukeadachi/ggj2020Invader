using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Rigidbody rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
        Vector3 force = new Vector3 (0.0f,0.0f,10.0f);    // 力を設定
        rb.AddForce (force);  // 力を加える

        //離れすぎると自爆
        if(transform.position.z > 50) {
            Destroy(this.gameObject);
        }
    }
}
