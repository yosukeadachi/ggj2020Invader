using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public enum EnemyTypes {
        A,
        B,
        C
    }
    public EnemyTypes type;

    private Rigidbody rb;

    private float fireTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody> ();  // rigidbodyを取得
        fireTime = _getFireTime(type);
    }

    // Update is called once per frame
    void Update()
    {
        fireTime -= Time.deltaTime;
        if(fireTime < 0.0f) {
            fireTime = _getFireTime(type);
            GameObject loadObj = (GameObject)Resources.Load ("EnemyMissile");
            GameObject missile =Instantiate (loadObj, this.transform.position, Quaternion.identity);
            missile.transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
        }
    }

    void FixedUpdate()
    {
        Vector3 force = new Vector3 (0.0f,0.0f,-40.0f);    // 力を設定
        rb.AddForce (force);  // 力を加える
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Missile")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }


    float _getFireTime(EnemyTypes aType) {
        float _time = 100.0f;
        switch(aType) {
        case EnemyTypes.A:
            _time = Random.Range(30.0f, 40.0f);
            break;
        case EnemyTypes.B:
            _time = Random.Range(20.0f, 30.0f);
            break;
        case EnemyTypes.C:
            _time = Random.Range(10.0f, 20.0f);
            break;
        }
        return _time;
    }


}
