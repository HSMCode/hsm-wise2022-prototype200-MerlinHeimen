using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    //Attaching Player-Character Game Object
    public GameObject gameCharacter1;

    //Variable to check if the player is dead
    public bool IsDead = false;

    private void OnCollisionEnter(Collision other)
    {
        //Destroys the Player Game Object if the Player hits the Killbox
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameCharacter1);
            IsDead = true;
            Debug.Log("You got eaten by lizard people :(");

        }
    }
}
