using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Flexible Text Data")]
public class FlexibleUITextData : ScriptableObject {
    [Header("Default")]
    public Font DefaultFont;
    public FontStyle DefaultFontStyle = FontStyle.Normal;
    public int DefaultFontSize = 14;
    public int DefaultLineSpacing = 1;
    public TextAnchor DefaultTextAnchor = TextAnchor.UpperLeft;
    public bool IsDefaultGeometry = false;
    public HorizontalWrapMode DefaultHorizontalWrapMode = HorizontalWrapMode.Wrap;
    public VerticalWrapMode DefaultVerticalWrapMode = VerticalWrapMode.Truncate;
    public bool IsDefaultBestFit = false;
    public Color DefaultFontColor = Color.black;
}
