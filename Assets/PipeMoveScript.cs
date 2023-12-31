using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static LogicScript;

public class PipeMoveScript : MonoBehaviour
{
    public float pipeMoveSpeed;
    public float deathZone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < deathZone)
        {
            Destroy(gameObject);
        }
        transform.position = transform.position + (Vector3.left * (pipeMoveSpeed + Time.timeSinceLevelLoad)) * Time.deltaTime;
    }
}
