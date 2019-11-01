using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class FlexibleUIInputField : FlexibleUI
{
    public enum InputFieldType { Default }

    public FlexibleUIInputFieldData Data;
    public InputFieldType Type;

    private Image image;
    private InputField inputField;
    private Text text;
    private Text placeHolderText;

    public override void Awake()
    {
        inputField = GetComponent<InputField>();
        image = inputField.image;
        text= inputField.textComponent;
        placeHolderText = inputField.placeholder.GetComponent<Text>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite sprite = Data.DefaultSprite;
        SpriteState spriteState = Data.DefaultSpriteState;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;

        int fontSize = Data.FontSize;
        Font font = Data.Font;
        Color fontColor = Data.FontColor;
        Font placeHolderFont = Data.PlaceHolderFont;
        Color placeHolderFontColor = Data.PlaceHolderFontColor;

        switch(Type)
        {
            case InputFieldType.Default:
                transition = Selectable.Transition.ColorTint;

                colors.normalColor = Data.NormalColor;
                colors.highlightedColor = Data.HighlightedColor;
                colors.pressedColor = Data.PressedColor;
                colors.disabledColor = Data.DisableColor;
                break;
        }

        inputField.transition = transition;
        inputField.colors = colors;
        inputField.spriteState = spriteState;
        image.sprite = sprite;

        text.fontSize = fontSize;
        text.font = font;
        text.color = fontColor;

        placeHolderText.fontSize = fontSize;
        placeHolderText.font = placeHolderFont;
        placeHolderText.color = placeHolderFontColor;
        placeHolderText.fontStyle = FontStyle.Italic;
    }
}
