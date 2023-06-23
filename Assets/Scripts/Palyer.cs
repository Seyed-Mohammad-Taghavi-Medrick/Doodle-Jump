using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
/*using UnityEditor.UIElements;*/
using UnityEngine;

public class Palyer : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite deathSprite;
    [SerializeField] private LevelLoader levelLoader;

    bool faceTORight = true;
    public Rigidbody2D PlayerRgb2d;
    int inputHorizontal;
    float targetInput;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float lerpSpeed = 2f;

    private bool isDead;

    void Start()
    {
        PlayerRgb2d = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        targetInput = Mathf.Lerp(targetInput, inputHorizontal, Time.deltaTime * lerpSpeed);

        if (!isDead)
        {

            transform.Translate(targetInput * moveSpeed * Time.deltaTime, 0, 0);
            FlipSprite();
        }
        else
        {
            transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        }
    }

    void FlipSprite()
    {
        bool PlayerHasHorizontalSpeed = Mathf.Abs(inputHorizontal) > Mathf.Epsilon;

        if (PlayerHasHorizontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(inputHorizontal), 1f);
        }
    }

    public void Die()
    {
        spriteRenderer.sprite = deathSprite;
        isDead = true;
        PlayerRgb2d.simulated = false;

        Invoke(nameof(LoadMenuDelayed), 2f);
    }

    private void LoadMenuDelayed()
    {
        levelLoader.LoadLevel("MenueScne");
    }

    public bool IsDead() => isDead;

    public void HorizontalMovment(int value)
    {
        inputHorizontal = value;
    }
}