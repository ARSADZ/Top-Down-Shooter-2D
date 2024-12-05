using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float lifetime;

    private float timer;

    void Start()
    {
        timer = lifetime;

        StartCoroutine(countDown());
    }

    private void Update() {
        timer -= Time.deltaTime;
    }

    private IEnumerator countDown() {
        Color defaultColor = GetComponent<SpriteRenderer>().color;
        Color transparent = defaultColor;
        transparent.a = 0.4f;

        yield return new WaitForSeconds(lifetime * 0.7f);

        while (timer > 0f) {
            GetComponent<SpriteRenderer>().color = defaultColor;
            yield return new WaitForSeconds(0.1f);
            GetComponent<SpriteRenderer>().color = transparent;
            yield return new WaitForSeconds(0.1f);
        }

        Destroy(gameObject);
    }
}
