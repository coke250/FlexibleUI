using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
[RequireComponent(typeof(Image))]
public class FlexibleUIDropdown : FlexibleUI
{
    public enum DropdownType { Default }

    public FlexibleUIDropdownData Data;
    public DropdownType Type;

    // Dropdown
    private Image image;
    private Image arrowImage;
    private Text text;
    private Dropdown dropdown;

    // Template
    private Image templateImage;
    private Image uiMaskImage;
    private Image itemImage;
    private Toggle itemToggle;
    private Image itemChekmarkImage;
    private Text itemText;

    public override void Awake()
    {
        dropdown = GetComponent<Dropdown>();
        image = GetComponent<Image>();
        arrowImage = transform.Find("Arrow").GetComponent<Image>();
        text = transform.Find("Label").GetComponent<Text>();

        templateImage = dropdown.template.GetComponent<Image>();
        uiMaskImage = templateImage.GetComponent<ScrollRect>().viewport.GetComponent<Image>();
        itemToggle = GetComponentInChildren<Toggle>(true);
        itemImage = itemToggle.targetGraphic.GetComponent<Image>();
        itemChekmarkImage = itemToggle.transform.Find("Item Checkmark").GetComponent<Image>();
        itemText = dropdown.itemText;

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Selectable.Transition transition = Selectable.Transition.SpriteSwap;
        Sprite sprite = Data.DefaultSprite;
        Sprite arrowSprite = Data.ArrowSprite;
        SpriteState spriteState = Data.DefaultSpriteState;
        ColorBlock colors = new ColorBlock();

        colors.colorMultiplier = 1;
        colors.fadeDuration = 0.1f;

        Selectable.Transition itemTransition = Selectable.Transition.SpriteSwap;
        Sprite itemSprite = Data.ItemDefaultSprite;
        Sprite itemCheckmarkSprite = Data.ItemCheckmarkSprite;
        Sprite templateSprite = Data.TemplateSprite;
        Sprite uiMaskSprite = Data.UIMaskSprite;
        SpriteState itemSpriteState = Data.ItemDefaultSpriteState;
        ColorBlock itemColors = new ColorBlock();

        itemColors.colorMultiplier = 1;
        itemColors.fadeDuration = 0.1f;

        int fontSize = Data.FontSize;
        Font font = Data.Font;
        Color fontColor = Data.FontColor;

        int itemFontSize = Data.ItemFontSize;
        Font itemFont = Data.ItemFont;
        Color itemFontColor = Data.ItemFontColor;

        switch (Type)
        {
            case DropdownType.Default:
                transition = Selectable.Transition.ColorTint;

                colors.normalColor = Data.NormalColor;
                colors.highlightedColor = Data.HighlightedColor;
                colors.pressedColor = Data.PressedColor;
                colors.disabledColor = Data.DisableColor;

                itemTransition = Selectable.Transition.ColorTint;

                itemColors.normalColor = Data.ItemNormalColor;
                itemColors.highlightedColor = Data.ItemHighlightedColor;
                itemColors.pressedColor = Data.ItemPressedColor;
                itemColors.disabledColor = Data.ItemDisableColor;

                break;

        }

        // Set Dropdown
        image.sprite = sprite;
        dropdown.spriteState = spriteState;
        dropdown.transition = transition;
        dropdown.colors = colors;
        arrowImage.sprite = arrowSprite;

        templateImage.sprite = templateSprite;
        uiMaskImage.sprite = uiMaskSprite;
        itemImage.sprite = itemSprite;
        itemToggle.spriteState = itemSpriteState;
        itemToggle.transition = itemTransition;
        itemToggle.colors = itemColors;
        itemChekmarkImage.sprite = itemCheckmarkSprite;

        text.fontSize = fontSize;
        text.font = font;
        text.color = fontColor;

        itemText.fontSize = itemFontSize;
        itemText.font = itemFont;
        itemText.color = itemFontColor;
    }
}
