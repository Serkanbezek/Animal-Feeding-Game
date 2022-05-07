using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float PlayerSpeed = 10.0f;
    public float Xrange = 15.5f;
    public GameObject ProjectilePrefab;
    
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * PlayerSpeed * Time.deltaTime * HorizontalInput);

        var tempPos = transform.position;
        tempPos.x = Mathf.Clamp(tempPos.x, -Xrange, Xrange);
        transform.position = tempPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
        }
    }
}
