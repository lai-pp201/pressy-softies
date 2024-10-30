using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : SaveSystem
{
    float currentTime = 0;
    float score = 0;
    float bestScore = 0;
    [SerializeField] float playTime = 1200;
    public static int amount = 0;
    public SaveData data = new SaveData();
    //掛在網子上

    public class SaveData
    {
        //放入要儲存的變數
        //記得儲存前要更新這裡的數據
        public float score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Save(data);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision != null)
        {
            if(collision.gameObject.tag == "Butterfly")
            {
                CatchButterfly(collision);
                amount -= 1;
            }
        }
    }


    void CatchButterfly(Collision collision)
    {
        data.score++;
        Destroy(collision.gameObject);
    }

    void CheckEndGame()
    {
        if(playTime >= currentTime)
        {
            EndGame();
        }
    }

    void EndGame()
    {

    }
}
