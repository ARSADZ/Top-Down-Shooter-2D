using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public string triggerWith;
    public UnityEvent OnTrigger;
    public UnityEvent<GameObject> OnTriggerWithObject;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == triggerWith) {
            OnTrigger?.Invoke();
            OnTriggerWithObject?.Invoke(collision.gameObject);
        }
    }
}
