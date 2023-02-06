using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{
    public GameObject gameCharacter1;
    
    public bool gotCrushed = false;

    private void OnCollisionEnter(Collision other)
    {
        //Disables the Player game object if the Stone hits the player
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("BucketTag"))
        {
            gameCharacter1.SetActive(false);
            gotCrushed = true;
            Debug.Log("You caught a Stone!");
        }

        //Destroys the Stone one Second after it hits the Ground
        if (other.gameObject.CompareTag("GroundTag") && gotCrushed == false)
        {
            
            Destroy(this.gameObject, 1);
            
        }

    }
}
