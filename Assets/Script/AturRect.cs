using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AturRect : MonoBehaviour
{
    public RectTransform buttonRectTransform;
    public Vector2 targetScale = new Vector2(1.5f, 1.5f); // Skala tujuan untuk memperbesar tombol
    /*private void Update()
    {
        SomeCondition();
        ResetButtonScale();
    }
    // Contoh penggunaan dalam suatu kondisi tertentu
    private void SomeCondition()
    {
        if (Input.GetKey(KeyCode.L))
        {// Memperbesar tombol
            buttonRectTransform.localScale = targetScale;
        }
    }
    // Contoh penggunaan untuk mengembalikan ke ukuran awal
    private void ResetButtonScale()
    {
        // Mengembalikan tombol ke ukuran awal (1, 1, 1)
        if (Input.GetKey(KeyCode.M))
        {// Memperbesar tombol
            buttonRectTransform.localScale = Vector2.one;

        }
       
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            buttonRectTransform.localScale = targetScale;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trigger"))
        {
            buttonRectTransform.localScale = Vector2.one;
        }
    }
}
