using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    int score = 0;
    private void OnTriggerEnter(Collider other)
    {
        // we check if the other collider has
        // the tag "Amogu" on its object
        if (other.tag == "Amogu")
        // this is the same as "score = score +1"
        score++;
        Debug.Log("Entered");
    }
}
