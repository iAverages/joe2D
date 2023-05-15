using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    private Collider2D collider2d;

    [SerializeField]
    private ContactFilter2D filter;
    private List<Collider2D> collidedObjects = new List<Collider2D>(1);
    protected bool hasCollided = false;

    protected virtual void Start()
    {
        collider2d = GetComponent<Collider2D>();
    }

    protected virtual void Update()
    {
        collider2d.OverlapCollider(filter, collidedObjects);
        foreach (var i in collidedObjects)
        {
            if (i.gameObject == null)
            {
                Debug.Log("Im fucked");
                continue;
            }
            hasCollided = true;
            Debug.Log(i.gameObject.name);
            OnCollided(i.gameObject);
        }

        if (collidedObjects.Count == 0 && hasCollided)
        {
            OnCollidedExit();
            hasCollided = false;
        }
    }

    protected virtual void OnCollided(GameObject collidedObject) { }

    protected virtual void OnCollidedExit() { }
}
