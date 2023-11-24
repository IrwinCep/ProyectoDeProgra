using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 checkPointPos;
    // Start is called before the first frame update
    void Start()
    {
        checkPointPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateCheckpoint(Vector2 pos)
    {
        checkPointPos = pos);
    }
}
