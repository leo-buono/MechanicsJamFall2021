using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject cubeToRespawn;


    Vector3 startPos;
    
    void Start()
    {
        //Redundancy
        cubeToRespawn.GetComponent<Rigidbody>().useGravity = false;
        cubeToRespawn.GetComponent<Rigidbody>().isKinematic = false;
        startPos = new Vector3(0f, 1.2f, 3.375f);
    }
    private void OnTriggerEnter(Collider other) 
    {
        GameObject meme = other.gameObject;
        meme.GetComponent<Rigidbody>().useGravity = true;
        meme.GetComponent<Rigidbody>().isKinematic = false;
        if(meme.tag == cubeToRespawn.tag)
        {
            GameObject temp = Instantiate(cubeToRespawn, startPos, Quaternion.identity);
            meme.tag = "usedCube";
        }
    }
    
}
