using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class FlexibleUIImage : FlexibleUI{
    public enum ImageType { Default}

    public FlexibleUIImageData Data;
    public ImageType Type;

    private Image image;

    public override void Awake()
    {
        image = GetComponent<Image>();

        base.Awake();
    }

    protected override void GUI()
    {
        base.GUI();

        Sprite sprite = Data.DefaultSprite;
        Color color = Data.DefaultColor;
        Image.Type imageType = Data.DefaultImageType;

        switch(Type)
        {
            case ImageType.Default:
                break;
        }

        image.sprite = sprite;
        image.color = color;
        image.type = imageType;
    }
}
