using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kinProblem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
    private void Update() {
        if(transform.position.y < -20f)
        {
            Destroy(this);    
        }
    }
}
