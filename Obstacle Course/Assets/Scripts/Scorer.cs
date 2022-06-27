using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{

    int bumped = 0;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Finish")
        {
            if (collision.gameObject.tag != "Hit")
            {
                bumped++;
                Debug.Log($"You've bumped into a thing this many times: {bumped}");

            }
        }


    }
}
