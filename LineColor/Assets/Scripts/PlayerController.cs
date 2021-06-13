using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    [SerializeField]
    private Transform line;

    [SerializeField]
    private ParticleSystem effectMove, effectDestroy;

    [SerializeField]
    private GameObject loseTable, winTable;

    public float maxSpeed;

    public static float speed;

    public float what;

    private void Start()
    {
    }

    private void Update()
    {
        what = speed;
        line.position = new Vector3(transform.position.x, line.transform.position.y, transform.position.z);

        if (Input.GetMouseButtonDown(0))
        {
            speed = maxSpeed;

            if (speed != 0f)
            {
                effectMove.Play();
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            speed = 0f;

            effectMove.Stop();
        }
    }

    private void Lose()
    {
        speed = 0f;
        maxSpeed = 0f;

        Destroy(gameObject, 0.2f);

        effectMove.Stop();
        effectDestroy.Play();

        loseTable.SetActive(true);
    }

    private void Win()
    {
        speed = 0f;
        maxSpeed = 0f;

        winTable.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Barier")
        {
            Lose();
        }
        
        else if(other.gameObject.tag == "Win")
        {
            Win();
        }
    }
}
