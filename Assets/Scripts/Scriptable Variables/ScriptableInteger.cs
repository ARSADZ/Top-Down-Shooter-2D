using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Scriptable Integer", menuName = "Scriptable Variables/Integer")]
public class ScriptableInteger : ScriptableObject
{
    public int value;
    public int defaultValue;
    public bool resetOnEnabled;

    private void OnEnable() {
        if (resetOnEnabled) {
            resetValue();
        }
    }

    public void resetValue() {
        value = defaultValue;
    }
}
