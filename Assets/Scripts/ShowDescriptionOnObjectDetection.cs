using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class ShowDescriptionOnObjectDetection : MonoBehaviour
{
    [Header("UI Description")]
    [TextArea]
    public string description;
    public Text descriptionTxt;
    public GameObject Description;

    void Start()
    {

    }

    void Update()
    {
        descriptionTxt.text = description;
    }

}
