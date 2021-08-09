using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class CubeColors : MonoBehaviour
{
    public GameObject CubeColorMenu;

    MeshRenderer meshRenderer;
    Material material;
    Texture2D texture;
    static int color = 0;


    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;
        texture = new Texture2D(256, 256, TextureFormat.RGBA32, true, true);
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.filterMode = FilterMode.Point;
        material.SetTexture("_MainTex", texture);

        switch (color)
        {
            default:
                break;
            case 0:
                ChangeToRed(); break;
            case 1:
                ChangeToBlack(); break;
            case 2:
                ChangeToYellow(); break;
            case 3:
                ChangeToOrange(); break;
            case 4:
                ChangeToBlue(); break;
            case 5:
                ChangeToPink(); break;
            case 6:
                ChangeToGreen(); break;
        }
    }

    public void CubeColorMenuOpen()
    {
        if (CubeColorMenu.activeSelf)
        {
            CubeColorMenu.SetActive(false);
        } else
        {
            CubeColorMenu.SetActive(true);
        }
    }

    public void ChangeToRed()
    {
        color = 0;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(255, 0, 0, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();
    }
    public void ChangeToBlack()
    {
        color = 1;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(0, 0, 0, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();
    }
    public void ChangeToYellow()
    {
        color = 2;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(255, 255, 0, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();

    }
    public void ChangeToOrange()
    {
        color = 3;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(255, 165, 0, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();

    }
    public void ChangeToBlue()
    {
        color = 4;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(0, 0, 254, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();

    }
    public void ChangeToPink()
    {
        color = 5;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(255, 105, 180, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();

    }
    public void ChangeToGreen()
    {
        color = 6;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                Color32 temp = new Color32(0, 255, 0, 255); ;
                texture.SetPixel(x, y, temp);
            }
        }
        texture.Apply();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
