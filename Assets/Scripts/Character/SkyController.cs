using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Light sky;
    [SerializeField] float IntensityMult = 2;
 
    private float R = 230, G = 230, B = 70, A = 255;
    private GUIStyle _style = new GUIStyle();

    private void Start()
    {
        _style.alignment = TextAnchor.MiddleCenter;
    }
    void OnGUI()
    {
        GUI.Box(new Rect(100, 20, 200, 100), "");

        GUILayout.BeginArea(new Rect(100, 20, 200, 100));
        GUILayout.BeginVertical();
        GUILayout.Label("Sky color", _style);

        R = LabelSlider(R, "R", 255);
        G = LabelSlider(G, "G", 255);
        B = LabelSlider(B, "B", 255);
        A = LabelSlider(A, "A", 255);

        GUILayout.EndVertical();
        GUILayout.EndArea();

        sky.color = new Color(R/255, G/255, B/255, A);
    }


    private float LabelSlider(float sliderValue, string labelText, float sliderMaxValue, float sliderMinValue=0)
    {

        GUILayout.BeginHorizontal();
        GUILayout.Label(labelText, _style);
        sliderValue = GUILayout.HorizontalSlider(sliderValue, sliderMinValue, sliderMaxValue);
        GUILayout.EndHorizontal();

        return sliderValue;
    }
}
