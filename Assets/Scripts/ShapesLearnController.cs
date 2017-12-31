using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesLearnController : MonoBehaviour {

    private Animator anim;
    public ShapesLearnSelector drawShape;
    public bool shapeDrawn = false;

    IEnumerator Start () 
	{
        GetComponent<Animator>().Play("breathing_idle", 0, 0.0f);
        yield return new WaitForSeconds(4); // Character Speaks to user first
    }

    public IEnumerator DrawCube () 
	{
        shapeDrawn = true;
        Debug.Log("drawing shape");
        GetComponent<Animator>().SetTrigger("DrawSquare");
        yield return new WaitForSeconds(5);
        shapeDrawn = false;
        Debug.Log("coroutine ended");
    }

    public IEnumerator DrawPyramid()
    {
        shapeDrawn = true;
        Debug.Log("drawing shape");
        GetComponent<Animator>().SetTrigger("DrawTriangle");
        yield return new WaitForSeconds(4);
        shapeDrawn = false;
        Debug.Log("coroutine ended");
    }

    public IEnumerator DrawSphere()
    {
        shapeDrawn = true;
        Debug.Log("drawing shape");
        GetComponent<Animator>().SetTrigger("DrawCircle");
        yield return new WaitForSeconds(8);
        shapeDrawn = false;
        Debug.Log("coroutine ended");
    }
}


