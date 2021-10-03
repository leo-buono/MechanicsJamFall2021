using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onCollisionScaleChange : MonoBehaviour
{
    public GameObject score;
    public float cubeScale = 1f;
    int cubeCount = 1;

    private void OnCollisionEnter(Collision other) 
    {
        score.GetComponent<TextMesh>().text = "Cube Count/score: " + cubeCount;
        cubeCount++;
        cubeScale += (0.1f * cubeCount);
        other.gameObject.transform.localScale *= cubeScale;
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
