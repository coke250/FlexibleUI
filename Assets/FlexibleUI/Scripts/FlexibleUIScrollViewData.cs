using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI ScrollView Data")]
public class FlexibleUIScrollViewData : ScriptableObject{

    [Header("Background Color")]
    public Color BackgroundColor = new Color(255f/255f, 255f / 255f, 255f / 255f, 100f / 255f);

    [Header("Background Sprite")]
    public Sprite BackgroundSprite;

    [Header("UI Mask Color")]
    public Color UIMaskColor = Color.white;

    [Header("UI Mask Sprite")]
    public Sprite UIMaskSprite;

}
