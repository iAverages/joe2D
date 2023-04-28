using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    private Collider2D z_Collider;
    [SerializeField]
    private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>(1);

    public GameObject PlayerPrompt;
    public static bool isDisplayed = false;

    protected virtual void Start(){
        z_Collider = GetComponent<Collider2D>();
        isDisplayed = false;
        PlayerPrompt.SetActive(false);
    }

    protected virtual void Update(){        
        
        z_Collider.OverlapCollider(z_Filter, z_CollidedObjects);
        foreach (var i in z_CollidedObjects)
        {
            OnCollided(i.gameObject);            
        }

        if (z_CollidedObjects.Count == 0)   
        {
            OnCollided(null);
        }

    }

    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("collided with " + collidedObject.name);
    }

    
    

    // public void DisplayPrompt(){
    //     PlayerPrompt.SetActive(true);
    //     isDisplayed = true;
    // }

    // public void HidePrompt(){
    //     PlayerPrompt.SetActive(false);
    //     isDisplayed = false;
    // }
}

