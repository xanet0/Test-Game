using UnityEngine;
using TMPro;
using System.Collections;

public class DestroyerCollider : MonoBehaviour
{
    public Counter scriptCounter;

    // Проверка на то, тронулся ли обьект колайдера
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        scriptCounter.loseCount();
    }
}
