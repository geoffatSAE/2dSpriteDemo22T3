using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float force;   
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D r = GetComponent<Rigidbody2D>();
        r.AddRelativeForce(Vector2.right * force * -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
