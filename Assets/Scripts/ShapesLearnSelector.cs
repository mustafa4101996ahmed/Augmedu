using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesLearnSelector : MonoBehaviour {

    public List<GameObject> shapesList;
    public UImanager options;
    public int shapesIndex = 0;
    public GameObject shapesOptions;
    public MeshRenderer currentShape;
    public List<MeshRenderer> meshList;
    public ShapesLearnController drawing;

    void Start () 
	{
        GameObject[] shapes = Resources.LoadAll<GameObject>("ShapesLearningPrefab");    
        foreach(GameObject c in shapes)
        {
            GameObject _shape = Instantiate(c) as GameObject;
            _shape.transform.SetParent(GameObject.Find("ShapesList").transform);

            shapesList.Add(_shape);
            MeshRenderer myMesh = _shape.GetComponent<MeshRenderer>();
            meshList.Add(myMesh);
            _shape.SetActive(false);
            //shapesList[shapesIndex].SetActive(true);
        }
    }

    public void Cube()
    {
        drawing.shapeDrawn = false;
        shapesList[shapesIndex].SetActive(false);
        shapesIndex = 0;
        currentShape = meshList[0];
        shapesOptions.SetActive(false);
        options.optionsOpen1 = false;
        Debug.Log("coroutine started");
        StartCoroutine(drawing.DrawCube());
        StartCoroutine(CubeSetActive());
    }

    IEnumerator CubeSetActive()
    {
        while (drawing.shapeDrawn)
            yield return new WaitForSeconds(0.1f);
        shapesList[0].SetActive(true);
    }

    public void Pyramid()
        {
            shapesList[shapesIndex].SetActive(false);
            shapesIndex = 1;
            shapesOptions.SetActive(false);
            options.optionsOpen1 = false;
        Debug.Log("coroutine started");
        StartCoroutine(drawing.DrawPyramid());
        StartCoroutine(PyramidSetActive());
        //currentShape = GameObject.FindGameObjectWithTag("Shape").gameObject;
    }

    IEnumerator PyramidSetActive()
    {
        while (drawing.shapeDrawn)
            yield return new WaitForSeconds(0.1f);
        shapesList[1].SetActive(true);
    }

    public void Sphere()
        {
            shapesList[shapesIndex].SetActive(false);
            shapesIndex = 2;
            shapesOptions.SetActive(false);
            options.optionsOpen1 = false;
        Debug.Log("coroutine started");
        StartCoroutine(drawing.DrawSphere());
        StartCoroutine(SphereSetActive());
        //currentShape = GameObject.FindGameObjectWithTag("Shape").gameObject;
    }

    IEnumerator SphereSetActive()
    {
        while (drawing.shapeDrawn)
            yield return new WaitForSeconds(0.1f);
        shapesList[2].SetActive(true);
    }
}

