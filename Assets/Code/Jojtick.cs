using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Jojtick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{

    private Image treshold;
    private Image touch;

    [HideInInspector] public Vector3 inputDir;
    public bool shoot;
    

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 position = Vector2.zero;

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(treshold.rectTransform, eventData.position,
                eventData.pressEventCamera, out position))
        {
            position.x = (position.x / treshold.rectTransform.sizeDelta.x);
            position.y = (position.y / treshold.rectTransform.sizeDelta.y);


            float x = (treshold.rectTransform.pivot.x == 1f ? position.x * 2 + 1 : position.x * 2 - 1);
            float y = (treshold.rectTransform.pivot.y == 1f ? position.y * 2 + 1 : position.y * 2 - 1);

            inputDir = new Vector3(x, y, 0);
            inputDir = (inputDir.magnitude > 1) ? inputDir.normalized : inputDir;
            

            touch.rectTransform.anchoredPosition = new Vector3(inputDir.x * (treshold.rectTransform.sizeDelta.x / 2.5f),
                inputDir.y * (treshold.rectTransform.sizeDelta.y / 2.5f));
            
            
        }
        
        if (shoot)
        {
            FindObjectOfType<PlayerController>().canShooter = true;
            
          
        }

      
        
        
            
            
            

    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {

        if (!shoot)
        {
            inputDir = Vector3.zero;
        }
        else
        {
            
            FindObjectOfType<PlayerController>().canShooter = false;
        }
        touch.rectTransform.anchoredPosition = Vector3.zero;
        
    }
    
    
    
    void Start()
    {
        treshold = GetComponent<Image>();
        touch = transform.GetChild(0).GetComponent<Image>();
        inputDir = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
