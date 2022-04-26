using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float playerSpeed = 10.0f;
    public float xRange = 15.5f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * playerSpeed * Time.deltaTime * horizontalInput);

        var tempPos = transform.position;
        tempPos.x = Mathf.Clamp(tempPos.x, -xRange, xRange);
        transform.position = tempPos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
