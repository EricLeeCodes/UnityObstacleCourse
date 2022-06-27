using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    [SerializeField] float dropTime = 1f;
    MeshRenderer _meshRenderer;
    Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _rigidbody = GetComponent<Rigidbody>();

        _meshRenderer.enabled = false;
        _rigidbody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
     
        //Time.time is a timer
        if (Time.time > dropTime)
        {
            _meshRenderer.enabled = true;
            _rigidbody.useGravity = true;

           
        }
    }

    
}
