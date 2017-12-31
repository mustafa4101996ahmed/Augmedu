using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mustafa
{
	public class ShapesQuizSelector : MonoBehaviour {

        public List<GameObject> shapesList;
        public UImanager options;
        public int shapesIndex = 0;
        public GameObject shapesOptions;
        public MeshRenderer currentShape;
        public List<MeshRenderer> meshList;
        public ShapesLearnController drawing;

        void Start () 
		{
            GameObject[] shapes = Resources.LoadAll<GameObject>("ShapesPrefab");
            foreach(GameObject c in shapes)
            {
                GameObject _shape = Instantiate(c) as GameObject;
                _shape.transform.SetParent(GameObject.Find("ShapesList").transform);

                shapesList.Add(_shape);
                MeshRenderer myMesh = _shape.GetComponent<MeshRenderer>();
                meshList.Add(myMesh);
                _shape.SetActive(false);
                shapesList[shapesIndex].SetActive(true);
            }
		}

        public void Cube()
        {
            shapesList[shapesIndex].SetActive(false);
            shapesList[0].SetActive(true);
            shapesIndex = 0;
            currentShape = meshList[0];
            shapesOptions.SetActive(false);
            options.optionsOpen1 = false;
            drawing.DrawCube();
        }

        public void Pyramid()
        {
            shapesList[shapesIndex].SetActive(false);
            shapesList[1].SetActive(true);
            shapesIndex = 1;
            shapesOptions.SetActive(false);
            options.optionsOpen1 = false;
            //currentShape = GameObject.FindGameObjectWithTag("Shape").gameObject;
        }

        public void Sphere()
        {
            shapesList[shapesIndex].SetActive(false);
            shapesList[2].SetActive(true);
            shapesIndex = 2;
            shapesOptions.SetActive(false);
            options.optionsOpen1 = false;
            //currentShape = GameObject.FindGameObjectWithTag("Shape").gameObject;
        }
    }
}


