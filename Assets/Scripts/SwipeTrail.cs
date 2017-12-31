using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTrail : MonoBehaviour {

    public GameObject trailPrefab;
	GameObject thisTrail;
	Vector3 startPos;
	Plane objPlane;
    GameObject[] gameObjects = null;

    void Start()
	{
		objPlane = new Plane (Camera.main.transform.forward * -1, transform.position);
	}

	void Update ()
	{
		if (((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) || Input.GetMouseButtonDown (0)))
        {
			
			Ray mRay = Camera.main.ScreenPointToRay (Input.mousePosition);
            
			float rayDistance;

            if (objPlane.Raycast(mRay, out rayDistance))
            {
                startPos = mRay.GetPoint(rayDistance);
            }
            thisTrail = (GameObject) Instantiate(trailPrefab, startPos, Quaternion.identity);
            
        }

        else if (((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) || Input.GetMouseButton (0)))
        {
			Ray mRay = Camera.main.ScreenPointToRay (Input.mousePosition);

			float rayDistance;

            if (objPlane.Raycast(mRay, out rayDistance))
            {
                thisTrail.transform.position = mRay.GetPoint(rayDistance);
            }
        } 

		else if ((Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp (0)) 
		{
            if (Vector3.Distance(thisTrail.transform.position, startPos) < 0.1)
            {
                Destroy(thisTrail);
            }
        }
    }
    
    public void Reset()
    {
        gameObjects = null;

        if(gameObjects == null)
        {
            Debug.Log("gameObjects was equal to null. Now filling up");
            gameObjects = GameObject.FindGameObjectsWithTag("Swipe");
        }
        else
        {
            Debug.Log("gameObjects is not equal to null");
        }

        foreach (GameObject target in gameObjects)
        {
            Destroy(target);
            Debug.Log("Deleted " + target);
        }
    }

}
