using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    //Attach scoreCount variable from ScoreScript component
    private ScoreScript scoreCount;

    void Start()
    {
        scoreCount = GameObject.FindGameObjectWithTag("ScoreCountTag").GetComponent<ScoreScript>();
    }
    
    private void OnCollisionEnter(Collision other)
    {
        //Destroy tomato if it hits the bucket and up scoreCount
        if (other.gameObject.CompareTag("BucketTag"))
        {
            scoreCount.IncreaseTomatoCount();
            Destroy(this.gameObject);
            Debug.Log("You caught a Tomato!");
        }

        //Destroy tomato if it hits the ground
        if (other.gameObject.CompareTag("GroundTag"))
        {
            Destroy(this.gameObject);
        }
    }
}
