using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script3 : MonoBehaviour
{
    Vector3 startPos;
    Vector3 endPos;

    float moveDuration = 1f;
    float moveElapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        endPos = new Vector3(transform.position.x, 2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        moveElapsed += Time.deltaTime;

        float t = moveElapsed / moveDuration;

        if (t > 1f) t = 1f;

        transform.position = Vector3.Lerp(startPos, endPos, t);

        if (t >= 1f)
        {
            moveElapsed = 0f;
            var temp = startPos;
            startPos = endPos;
            endPos = temp;
        }
    }
}
