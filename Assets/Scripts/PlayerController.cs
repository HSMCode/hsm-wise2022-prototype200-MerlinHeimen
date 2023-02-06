using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementDirection;

    [SerializeField] private float _speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //Movement Left/Right
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * _speed * Time.deltaTime);
        
        
    }
}
