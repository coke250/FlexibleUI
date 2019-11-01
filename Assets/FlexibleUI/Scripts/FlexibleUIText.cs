using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FlexibleUIText : FlexibleUI
{
    public enum TextType { Default}

    public FlexibleUITextData Data;
    public TextType Type;

    private Text text;

    public override void Awake()
    {
        text = GetComponent<Text>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Font font = Data.DefaultFont;
        FontStyle fontStyle = Data.DefaultFontStyle;
        int fontSize = Data.DefaultFontSize;
        int lineSpacing = Data.DefaultLineSpacing;
        TextAnchor textAnchor = Data.DefaultTextAnchor;
        bool isGeometry = Data.IsDefaultGeometry;
        HorizontalWrapMode horizontalWrapMode = Data.DefaultHorizontalWrapMode;
        VerticalWrapMode verticalWrapMode = Data.DefaultVerticalWrapMode;
        bool isBestFit = Data.IsDefaultBestFit;
        Color fontColor = Data.DefaultFontColor;

        switch(Type)
        {
            case TextType.Default:
                break;
        }

        text.font = font;
        text.fontStyle = fontStyle;
        text.fontSize = fontSize;
        text.lineSpacing = lineSpacing;
        text.alignment = textAnchor;
        text.alignByGeometry = isGeometry;
        text.horizontalOverflow = horizontalWrapMode;
        text.verticalOverflow = verticalWrapMode;
        text.resizeTextForBestFit = isBestFit;
        text.color = fontColor;
    }
}
