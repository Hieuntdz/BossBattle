using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        StartCoroutine(DamageAnimation());

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Lose
        MapController.Instance.gameObject.SetActive(false);
        OnReset();
        UIManager.Instance.pfb_Result.EndGame("Lose");
    }
    void OnReset()
    {
        health = 100;
        SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();
        foreach (var sr in srs)
        {
            Color c = sr.color;
            c.a = 1;
            sr.color = c;
        }
    }
    IEnumerator DamageAnimation()
    {
        SpriteRenderer[] srs = GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < 3; i++)
        {
            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 0;
                sr.color = c;
            }

            yield return new WaitForSeconds(.1f);

            foreach (SpriteRenderer sr in srs)
            {
                Color c = sr.color;
                c.a = 1;
                sr.color = c;
            }

            yield return new WaitForSeconds(.1f);
        }
    }

}
