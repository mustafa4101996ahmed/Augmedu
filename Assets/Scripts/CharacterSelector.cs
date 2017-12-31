using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mustafa
{
	public class CharacterSelector : MonoBehaviour {

        public List<GameObject> characterList;
        public UImanager options;
        public int index = 0;
        public GameObject characterOptions;

        void Start () 
		{
            GameObject[] character = Resources.LoadAll<GameObject>("CharacterPrefab");
            foreach(GameObject c in character)
            {
                GameObject _char = Instantiate(c) as GameObject;
                _char.transform.SetParent(GameObject.Find("CharacterList").transform);

                characterList.Add(_char);
                _char.SetActive(false);
                characterList[index].SetActive(true);
            }
		}

        public void Andromeda()
        {
            characterList[index].SetActive(false);
            characterList[1].SetActive(true);
            index = 1;
            characterOptions.SetActive(false);
            options.optionsOpen1 = false;
        }

        public void Malcolm()
        {
            characterList[index].SetActive(false);
            characterList[2].SetActive(true);
            index = 2;
            characterOptions.SetActive(false);
            options.optionsOpen1 = false;
        }

        public void Remy()
        {
            characterList[index].SetActive(false);
            characterList[0].SetActive(true);
            index = 0;
            characterOptions.SetActive(false);
            options.optionsOpen1 = false;
        }
    }
}


