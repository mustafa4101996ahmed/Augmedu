using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Mustafa
{
	public class SubjectSelector : MonoBehaviour {

        public List<GameObject> subjectList;
        public int index = 0;
        public static int subjectSelected = 0;

		void Start () 
		{
            GameObject[] subjects = Resources.LoadAll<GameObject>("SubjectsPrefab");
            foreach(GameObject c in subjects)
            {
                GameObject _sub = Instantiate(c) as GameObject;
                _sub.transform.SetParent(GameObject.Find("SubjectList").transform);

                subjectList.Add(_sub);
                _sub.SetActive(false);
                subjectList[index].SetActive(true);
            }
		}

        public void Next()
        {
            subjectList[index].SetActive(false);
            if(index == subjectList.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            subjectList[index].SetActive(true);
        }

        public void Previous()
        {
            subjectList[index].SetActive(false);
            if (index == 0)
            {
                index = subjectList.Count - 1;
            }
            else
            {
                index--;
            }
            subjectList[index].SetActive(true);
        }
            
        public void ConfirmSubject()
        {
            if (index == 0)
            {
                subjectSelected = 0;
                SceneManager.LoadScene("5LearnOrQuiz");
            }
            else if (index == 1)
            {
                subjectSelected = 1;
                SceneManager.LoadScene("5LearnOrQuiz");
            }
            else if (index == 2)
            {
                subjectSelected = 2;
                SceneManager.LoadScene("5LearnOrQuiz");
            }
        }

        void Update () 
		{
            subjectList[index].transform.Rotate(0, 0.5f, 0);
		}
	}
}


