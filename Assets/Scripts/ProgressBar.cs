using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    public Transform LoadingBar;
    public Transform TextIndicator;
    [SerializeField] private float currentAmount;
    private Texture2D bar_tex;
    public Image LoadingBarImage;
    public Color minColor = Color.red;
    public Color maxColor = Color.green;

    void Start()
    {
        //currentAmount = 25;
        setPercentage(0);
    }

	public void setPercentage (float currentAmount)
    {
        TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
        GetBlendedColor((int)currentAmount);
    }

    public Color GetBlendedColor(int percentage)
    {
        if (percentage < 50)
            return Interpolate(Color.red, Color.yellow, TransformPercentage(percentage));
        return Interpolate(Color.green, Color.yellow, TransformPercentage(100 - percentage));
    }

    private float TransformPercentage(int p)
    {
        return (float)((p / 100f) * 2f);
    }

    public Color Interpolate(Color c1, Color c2, float p)
    {
        return LoadingBarImage.color = Color.Lerp(c1, c2, p);
    }
}


