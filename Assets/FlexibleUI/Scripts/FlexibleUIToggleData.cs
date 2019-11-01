using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Toggle Data")]
public class FlexibleUIToggleData : ScriptableObject {

    [Header("Color")]
    public Color NormalColor = Color.white;
    public Color HighlightedColor = new Color(245f / 255f, 245f / 255f, 245f / 255f);
    public Color PressedColor = new Color(200f / 255f, 200f / 255f, 200f / 255f);
    public Color DisableColor = new Color(200f / 255f, 200f / 255f, 200f / 255f, 128f / 255f);

    [Header("Sprite")]
    public Sprite DefaultSprite;
    public SpriteState DefaultSpriteState;

    [Header("Checkmark")]
    public Sprite CheckmarkSprite;
}
