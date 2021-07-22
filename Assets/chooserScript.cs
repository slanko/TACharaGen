using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chooserScript : MonoBehaviour
{
    [SerializeField] Image mouthRenderer, eyeRenderer, earRenderer, accessoryRenderer, clothesRenderer, bandageRenderer;
    [SerializeField] List<Sprite> mouths, eyes, ears, accessories, clothes;
    int mouthIndex, eyeIndex, earIndex, accessoryIndex, clothesIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        randomizeAll();
    }

    public void randomizeAll()
    {
        mouthIndex = Random.Range(0, mouths.Count);
        eyeIndex = Random.Range(0, eyes.Count);
        earIndex = Random.Range(0, ears.Count);
        accessoryIndex = Random.Range(0, accessories.Count);
        clothesIndex = Random.Range(0, clothes.Count);
        setAll();
    }

    void setAll()
    {
        mouthRenderer.sprite = mouths[mouthIndex];
        eyeRenderer.sprite = eyes[eyeIndex];
        earRenderer.sprite = ears[earIndex];
        accessoryRenderer.sprite = accessories[accessoryIndex];
        clothesRenderer.sprite = clothes[clothesIndex];

        int bandageDecider = Random.Range(0, 2);
        if (bandageDecider == 0) bandageRenderer.enabled = false;
        else bandageRenderer.enabled = true;
    }

    public void nextInList(string neededType)
    {
        //this is fucking lame. thank ue unityevent
        switch (neededType)
        {
            case "mouth":
                mouthIndex++;
                if (mouthIndex > mouths.Count - 1) mouthIndex = 0;
                mouthRenderer.sprite = mouths[mouthIndex];
                break;
            case "eye":
                eyeIndex++;
                if (eyeIndex > eyes.Count - 1) eyeIndex = 0;
                eyeRenderer.sprite = eyes[eyeIndex];
                break;
            case "ear":
                earIndex++;
                if (earIndex > ears.Count - 1) earIndex = 0;
                earRenderer.sprite = ears[earIndex];
                break;
            case "accessory":
                accessoryIndex++;
                if (accessoryIndex > accessories.Count - 1) accessoryIndex = 0;
                accessoryRenderer.sprite = accessories[accessoryIndex];
                break;
            case "clothes":
                clothesIndex++;
                if (clothesIndex > clothes.Count - 1) clothesIndex = 0;
                clothesRenderer.sprite = clothes[clothesIndex];
                break;
        }
    }
    public void prevInList(string neededType)
    {
        //this is STILL fucking lame. thank ue unityevent
        switch (neededType)
        {
            case "mouth":
                mouthIndex--;
                if (mouthIndex < 0) mouthIndex = mouths.Count - 1;
                mouthRenderer.sprite = mouths[mouthIndex];
                break;
            case "eye":
                eyeIndex--;
                if (eyeIndex < 0) eyeIndex = eyes.Count - 1;
                eyeRenderer.sprite = eyes[eyeIndex];
                break;
            case "ear":
                earIndex--;
                if (earIndex < 0) earIndex = ears.Count - 1;
                earRenderer.sprite = ears[earIndex];
                break;
            case "accessory":
                accessoryIndex--;
                if (accessoryIndex < 0) accessoryIndex = accessories.Count - 1;
                accessoryRenderer.sprite = accessories[accessoryIndex];
                break;
            case "clothes":
                clothesIndex--;
                if (clothesIndex < 0 ) clothesIndex = clothes.Count - 1;
                clothesRenderer.sprite = clothes[clothesIndex];
                break;
        }
    }

    public void toggleBandages()
    {
        if (bandageRenderer.enabled) bandageRenderer.enabled = false;
        else bandageRenderer.enabled = true;
    }
}
