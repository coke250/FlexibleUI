using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible UI Dropdown Data")]
public class FlexibleUIDropdownData : ScriptableObject {
    [Header("Font")]
    public int FontSize = 14;
    public Font Font;
    public Color FontColor = Color.black;

    [Header("Color")]
    public Color NormalColor = Color.white;
    public Color HighlightedColor = new Color(245f / 255f, 245f / 255f, 245f / 255f);
    public Color PressedColor = new Color(200f / 255f, 200f / 255f, 200f / 255f);
    public Color DisableColor = new Color(200f / 255f, 200f / 255f, 200f / 255f, 128f / 255f);

    [Header("Sprite")]
    public Sprite DefaultSprite;
    public SpriteState DefaultSpriteState;

    [Header("Arrow")]
    public Sprite ArrowSprite;

    [Header("Template")]
    public Sprite TemplateSprite;
    public Sprite UIMaskSprite;

    [Header("Item Font")]
    public int ItemFontSize = 14;
    public Font ItemFont;
    public Color ItemFontColor = Color.black;

    [Header("Color")]
    public Color ItemNormalColor = Color.white;
    public Color ItemHighlightedColor = new Color(245f / 255f, 245f / 255f, 245f / 255f);
    public Color ItemPressedColor = new Color(200f / 255f, 200f / 255f, 200f / 255f);
    public Color ItemDisableColor = new Color(200f / 255f, 200f / 255f, 200f / 255f, 128f / 255f);

    [Header("Item Sprite")]
    public Sprite ItemDefaultSprite;
    public SpriteState ItemDefaultSpriteState;

    [Header("Item Chekmark")]
    public Sprite ItemCheckmarkSprite;
}
