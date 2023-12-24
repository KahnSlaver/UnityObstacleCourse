using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            IncreaseScore();
        }
    }

    private void IncreaseScore()
    {
        score += 1;
        Debug.Log($"You have bumped into the object {score} times");
    }
}
