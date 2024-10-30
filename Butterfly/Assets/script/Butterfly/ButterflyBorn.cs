using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyBorn : MonoBehaviour
{
    Vector3 bornDirection;
    [SerializeField] GameObject butterflyPrefab;
    float bornDistance = 0.7f;
    bool setPos = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("set");
            setPos = true;
            bornDirection = Camera.main.transform.forward;
            bornDirection = Vector3.ClampMagnitude(bornDirection*1000, bornDistance);
        }
        GameObject[] Butterfly = GameObject.FindGameObjectsWithTag("Butterfly");
        if(GameController.amount < 2 && setPos)
        {
            GameController.amount += 1;
            StartCoroutine(Born());
        }
    }

    //void Born()
    //{
    //    RandomBornPosition();
    //    Debug.Log(bornDirection);
    //    Instantiate(butterflyPrefab, Camera.main.transform.position + bornDirection, new Quaternion(0,0,0,0));
    //}

    void RandomBornPosition()
    {
        bornDirection.y = Random.Range( -0.25f, 0.5f);
        bornDirection = Vector3.ClampMagnitude(bornDirection * 10, bornDistance);
    }

    IEnumerator Born()
    {
        yield return new WaitForSeconds(1f);
        RandomBornPosition();
        Instantiate(butterflyPrefab, Camera.main.transform.position + bornDirection, new Quaternion(0, 0, 0, 0));
    }
}