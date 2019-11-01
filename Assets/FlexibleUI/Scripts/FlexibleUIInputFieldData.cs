using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI InputField Data")]
public class FlexibleUIInputFieldData : ScriptableObject {
    [Header("Font")]
    public int FontSize = 14;
    public Font Font;
    public Color FontColor = Color.black;
    public Font PlaceHolderFont;
    public Color PlaceHolderFontColor = new Color(50f/255f, 50f / 255f, 50f / 255f, 128f / 255f);

    [Header("Color Tint")]
    public Color NormalColor = Color.white;
    public Color HighlightedColor = new Color(245f / 255f, 245f / 255f, 245f / 255f);
    public Color PressedColor = new Color(200f / 255f, 200f / 255f, 200f / 255f);
    public Color DisableColor = new Color(200f / 255f, 200f / 255f, 200f / 255f, 128f / 255f);

    [Header("Sprite")]
    public Sprite DefaultSprite;
    public SpriteState DefaultSpriteState;
}
