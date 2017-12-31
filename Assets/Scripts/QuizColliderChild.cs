using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizColliderChild : MonoBehaviour
{
    public TracingQuizScript theScore;

    void OnTriggerEnter(Collider col)
    {
        switch (this.gameObject.tag)
        {
            case "Sphere1":
                if (theScore.collider0 == false)
                {
                    theScore.score++;
                }
                theScore.collider0 = true;
                Debug.Log("Sphere0 is hit");
                break;

            case "Sphere2":
                if (theScore.collider1 == false)
                {
                    theScore.score++;
                }
                theScore.collider1 = true;
                Debug.Log("Sphere1 is hit");
                break;

            case "Sphere3":
                if (theScore.collider2 == false)
                {
                    theScore.score++;
                }
                theScore.collider2 = true;
                Debug.Log("Sphere2 is hit");
                break;

            case "Sphere4":
                if (theScore.collider3 == false)
                {
                    theScore.score++;
                }
                theScore.collider3 = true;
                Debug.Log("Sphere3 is hit");
                break;

            case "Sphere5":
                if (theScore.collider4 == false)
                {
                    theScore.score++;
                }
                theScore.collider4 = true;
                Debug.Log("Sphere4 is hit");
                break;

            case "Sphere6":
                if (theScore.collider5 == false)
                {
                    theScore.score++;
                }
                theScore.collider5 = true;
                Debug.Log("Sphere5 is hit");
                break;

            case "Sphere7":
                if (theScore.collider6 == false)
                {
                    theScore.score++;
                }
                theScore.collider6 = true;
                Debug.Log("Sphere6 is hit");
                break;

            case "Sphere8":
                if (theScore.collider7 == false)
                {
                    theScore.score++;
                }
                theScore.collider7 = true;
                Debug.Log("Sphere7 is hit");
                break;

            case "Sphere9":
                if (theScore.collider8 == false)
                {
                    theScore.score++;
                }
                theScore.collider8 = true;
                Debug.Log("Sphere8 is hit");
                break;

            case "Sphere10":
                if (theScore.collider9 == false)
                {
                    theScore.score++;
                }
                theScore.collider9 = true;
                Debug.Log("Sphere9 is hit");
                break;
        }
    }
}


