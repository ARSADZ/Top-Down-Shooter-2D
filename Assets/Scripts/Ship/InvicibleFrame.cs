using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvicibleFrame : MonoBehaviour
{
    public float duration;

    private float durationTimer;

    void Start()
    {
        durationTimer = 0;
    }

    void Update()
    {
        durationTimer = durationTimer - Time.deltaTime < 0 ? 0 : durationTimer - Time.deltaTime;

        if (durationTimer > 0) {
            GetComponent<Collider2D>().enabled = false;
        } else {
            GetComponent<Collider2D>().enabled = true;
        }
    }

    public void invicible() {
        durationTimer = duration;
        StartCoroutine(blinking());
    }

    private IEnumerator blinking() {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Color defaultColor = sr.color;
        Color transparent = sr.color;
        transparent.a = 0.3f;

        while (durationTimer > 0) {
            sr.color = transparent;
            yield return new WaitForSeconds(0.1f);
            sr.color = defaultColor;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
