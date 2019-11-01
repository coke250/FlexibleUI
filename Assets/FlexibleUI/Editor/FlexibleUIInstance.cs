using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FlexibleUIInstance : Editor {

    static GameObject clickedObject;

    [MenuItem("GameObject/Flexible UI/Button", priority = 0)]
    public static void CreateButton()
    {
        Create("Button");
    }

    [MenuItem("GameObject/Flexible UI/Toggle", priority = 0)]
    public static void CreateToggle()
    {
        Create("Toggle");
    }

    [MenuItem("GameObject/Flexible UI/Dropdown", priority = 0)]
    public static void CreateDropdown()
    {
        Create("Dropdown");
    }

    [MenuItem("GameObject/Flexible UI/Scrollbar", priority = 0)]
    public static void CreateScrollbar()
    {
        Create("Scrollbar");
    }

    [MenuItem("GameObject/Flexible UI/InputField", priority = 0)]
    public static void CreateInputField()
    {
        Create("InputField");
    }

    [MenuItem("GameObject/Flexible UI/Slider", priority = 0)]
    public static void CreateSlider()
    {
        Create("Slider");
    }

    [MenuItem("GameObject/Flexible UI/Scroll View", priority = 0)]
    public static void CreateScrollView()
    {
        Create("Scroll View");
    }

    [MenuItem("GameObject/Flexible UI/Text", priority = 0)]
    public static void CreateText()
    {
        Create("Text");
    }

    [MenuItem("GameObject/Flexible UI/Image", priority = 0)]
    public static void CreateImage()
    {
        Create("Image");
    }

    private static GameObject Create(string objectName)
    {
        GameObject instance = Instantiate(Resources.Load<GameObject>(objectName));
        instance.name = objectName;
        clickedObject = Selection.activeObject as GameObject;

        if(clickedObject != null)
        {
            instance.transform.SetParent(clickedObject.transform, false);
        }

        return instance;
    }
}
