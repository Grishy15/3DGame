 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class IPointerHandler : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //1:Shtobi polzavatsia functsianalam nushno biblioteka - using UnityEngine.EventSystems;
    //2:Nushno pocliuchit interfaces - IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
    //3:Nushno realizovat interface toest podcluichit functsie - OnPointerClick, OnPointerEnter, OnPointerExit (PointerEventData data)
    //4:Obezatilno na camere dolshen bit component PhysicsRayCast - dlia 3D Project, dlia 2D Project -  component PhysicsRayCast 2D
    //5:Shtobi raboti s 3D/2D objects nushen component Collider na objects
    //6:Obezatelno dolshen bit UI objects - EventSystems
    //7:Script dolshen viset na obekte s kotorim hotim vsaimaidestvovat ili viset na roditele
    private Image image;
    private RectTransform imageTransform;
    private Material cubeMaterial;
    private Transform cubeTransform;
    private Canvas UIcanvas;  
    private TextMeshProUGUI text;

    private void Awake()
    {
        image = GetComponent<Image>();
        imageTransform = GetComponent<RectTransform>();
        UIcanvas = GetComponentInParent<Canvas>();
        text = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
    }
    public void OnPointerClick(PointerEventData data)
    {
        if (data.button==PointerEventData.InputButton.Right)
        {
            //image.color=Color.blue;
            //cubeMaterial.color=Color.blue;
        }
        else if (data.button==PointerEventData.InputButton.Left)
        {
            //image.color=Color.red;
            //cubeMaterial.color=Color.red;
        }
    }
    public void OnPointerEnter(PointerEventData data)
    {
        //imageTransform.localScale = new Vector2(2,2);
        //cubeTransform.localScale = new Vector3(1.5f,1.5f,1.5f);
    }
    public void OnPointerExit(PointerEventData data)
    {
        //imageTransform.localScale = new Vector2(1,1);
        //cubeTransform.localScale = new Vector3(1,1,1);
    }
    public void OnBeginDrag(PointerEventData data)
    {
        Debug.Log("OnBeginDrag");
        image.color=Color.red;
        imageTransform.SetAsLastSibling();
    }
    public void OnDrag(PointerEventData data)
    {
        imageTransform.anchoredPosition+=data.delta/UIcanvas.scaleFactor;

    }
    public void OnEndDrag(PointerEventData data)
    {
        Debug.Log("OnEndDrag");
        image.color=Color.magenta;
    }

}

