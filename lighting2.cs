using UnityEngine;

public class Lighting2 : MonoBehaviour
{
    public int x; // 
    public GameObject[] my_light; // Array of lights
    public string y;

    void Start()
    {


        Invoke("obj0", 2);
    }

    void Update()
    {


    }
    public void obj0()
    {

        my_light[0].SetActive(false);
        my_light[1].SetActive(false);
        my_light[2].SetActive(true);
        Invoke("obj1", 2);


    }
    public void obj1()
    {

        my_light[1].SetActive(true);
        my_light[0].SetActive(false);
        my_light[2].SetActive(false);
        Invoke("obj2", 1);
    }
    public void obj2()
    {
        my_light[2].SetActive(false);
        my_light[0].SetActive(true);
        my_light[1].SetActive(false);
        Invoke("obj0", 2);
    }
}

