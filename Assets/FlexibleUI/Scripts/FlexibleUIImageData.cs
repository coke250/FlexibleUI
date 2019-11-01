using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Image Data")]
public class FlexibleUIImageData : ScriptableObject
{
    [Header("Default Sprite")]
    public Sprite DefaultSprite;
    public Color DefaultColor = Color.white;
    public Image.Type DefaultImageType = Image.Type.Sliced;
}
