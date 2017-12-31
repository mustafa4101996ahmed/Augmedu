using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour {

    public GameObject loadingImage;
    public GameObject optionsTray1;
    public GameObject optionsTray2;
    public bool optionsOpen1 = false;
    public bool optionsOpen2 = false;

    public void GetStarted()
	{
		SceneManager.LoadScene ("2GetInfo");
		
	}

    public void MoreGetStarted()
    {
        SceneManager.LoadScene("2GetInfo_BBB");
    }

    public void Back()
	{
		SceneManager.LoadScene("1WelcomeScene");
	}

	public void OpenAR()
	{
        loadingImage.SetActive(true);
		SceneManager.LoadScene ("3MeetCharacter");
	}
	public void Home()
	{
		SceneManager.LoadScene ("3MeetCharacter");
	}

    public void LetsStudy()
    {
        SceneManager.LoadScene("4StudySelection");
    }

    public void ToggleDropDownMenu1()
    {
        if(optionsOpen1 == false)
        {
            optionsTray1.SetActive(true);
            optionsOpen1 = true;
        }
        else
        {
            optionsTray1.SetActive(false);
            optionsOpen1 = false;
        }
    }

    public void ToggleDropDownMenu2()
    {
        if (optionsOpen2 == false)
        {
            optionsTray2.SetActive(true);
            optionsOpen2 = true;
        }
        else
        {
            optionsTray2.SetActive(false);
            optionsOpen2 = false;
        }
    }

    public void Settings()
    {
        SceneManager.LoadScene("9Settings");
    }

    public void LogOut()
    {
        SceneManager.LoadScene("1WelcomeScene");
    }

    public void MathQuiz()
    {
        SceneManager.LoadScene("6MathQuiz");
    }
    public void MathLearn()
    {
        SceneManager.LoadScene("6MathLearn");
    }
}
