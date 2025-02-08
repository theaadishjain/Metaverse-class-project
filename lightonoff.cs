using UnityEngine;

public class lightonoff : MonoBehaviour
{
    public int x;
    public GameObject[] my_light;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            my_light[i].SetActive(false);
        }
       /* my_light[0].SetActive(false);
        my_light[1].SetActive(false);
        my_light[2].SetActive(false);*/


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
