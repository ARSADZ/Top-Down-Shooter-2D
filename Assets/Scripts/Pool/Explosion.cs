using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void Start() {
        deactivate();
    }

    private void Update() {
        if (gameObject.activeInHierarchy) {
            if (animationIsDone()) {
                deactivate();
            }
        }
    }

    private bool animationIsDone() {
        Animator animator = GetComponent<Animator>();

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator.IsInTransition(0)) {
            return true;
        }
        return false;
    }

    internal void deactivate() {
        gameObject.SetActive(false);
    }

    internal void activate(Vector3 position) {
        transform.position = position;

        gameObject.SetActive(true);
    }

    internal bool isActive() {
        return gameObject.activeInHierarchy;
    }
}
