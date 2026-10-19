using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    [SerializeField] private float speed = 0;
    [SerializeField] private Transform target;
    [SerializeField] private List<Transform> sprites = new List<Transform>();

    private void Update()
    {
        for (int i = 0; i < sprites.Count; i++)
        {
            sprites[i].localPosition += Vector3.left * (speed * Time.deltaTime);
        }
        if (sprites[0].transform.localPosition.x < -sprites[0].transform.localScale.x/2)
        {

            Transform current = sprites[0];
            Transform target = sprites[sprites.Count - 1];

            sprites.Remove(current);
            sprites.Add(current);

            float posX = target.localPosition.x;
            float scaleX = target.localScale.x;
            if (gameObject.CompareTag("ParalaxBackground2"))
            {
                current.localPosition = new Vector3(posX + scaleX, 4f, 0f);

            }
            else if (gameObject.CompareTag("ParalaxBackground3"))
            {
                current.localPosition = new Vector3(posX + scaleX, 5f, 0f);
            }
            else
            {
                current.localPosition = new Vector3(posX + scaleX, 4f, 0f);
            }
        }
    }
}
