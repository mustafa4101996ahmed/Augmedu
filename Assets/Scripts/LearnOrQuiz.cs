using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mustafa
{
	public class LearnOrQuiz : MonoBehaviour {

        public List<GameObject> classList;
        public int index = 0;

		void Start () 
		{
            GameObject[] classes = Resources.LoadAll<GameObject>("ClassPrefab");
            foreach(GameObject c in classes)
            {
                GameObject _sub = Instantiate(c) as GameObject;
                _sub.transform.SetParent(GameObject.Find("ClassList").transform);

                classList.Add(_sub);
                _sub.SetActive(false);
                classList[index].SetActive(true);
            }
		}

        public void Next()
        {
            classList[index].SetActive(false);
            if(index == classList.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            classList[index].SetActive(true);
        }

        public void Previous()
        {
            classList[index].SetActive(false);
            if (index == 0)
            {
                index = classList.Count - 1;
            }
            else
            {
                index--;
            }
            classList[index].SetActive(true);
        }

        public void ConfirmClass()
        {
            if (index == 0)
            {
                if (SubjectSelector.subjectSelected == 0)
                {
                    Debug.Log("Math Learn Loaded");
                    SceneManager.LoadScene("6MathLearn");
                }
                else if (SubjectSelector.subjectSelected == 1)
                {
                    Debug.Log("Shapes Learn Loaded");
                    SceneManager.LoadScene("7ShapesLearn");
                }
                else if (SubjectSelector.subjectSelected == 2)
                {
                    Debug.Log("Tracing Learn Loaded");
                    SceneManager.LoadScene("8TracingLearn");
                }
            }
            else if (index == 1)
            {
                if (SubjectSelector.subjectSelected == 0)
                {
                    Debug.Log("Math Quiz Loaded");
                    SceneManager.LoadScene("6MathQuiz");
                }
                else if (SubjectSelector.subjectSelected == 1)
                {
                    Debug.Log("Shapes Quiz Loaded");
                    SceneManager.LoadScene("7ShapesQuiz");
                }
                else if (SubjectSelector.subjectSelected == 2)
                {
                    Debug.Log("Tracing Quiz Loaded");
                    SceneManager.LoadScene("8TracingQuiz");
                }
            }


        }

        void Update () 
		{
            classList[index].transform.Rotate(0, 0.5f, 0);
		}
	}
}


