using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public int x; // 
    public GameObject[] my_light; // Array of lights
    public string y;
   

    // Start is called once before the first frame update
    void Start()
    {

        /*for (int i = 0; i < 3; i++)
        {
            my_light[i].SetActive(false); 
        }*/
        Invoke("obj0", 1);
    }

    void Update()
    {
        
        /*if (my_light[0].name == y)
        {
            obj0();
        }
            
        
            else if (my_light[1].name == y)
            {
            obj1();
            }
        else if (my_light[2].name == y)
        {
            obj2();
        }*/ 
    }
    public void obj0()
    {
        
        my_light[0].SetActive(false);
        my_light[1].SetActive(true);
        my_light[2].SetActive(true);
        Invoke("obj1", 1);


    }
    public void obj1()
    {
        
        my_light[1].SetActive(false);
        my_light[0].SetActive(true);
        my_light[2].SetActive(true);
        Invoke("obj2", 1);
    }
    public void obj2()
    {
        my_light[2].SetActive(false);
        my_light[0].SetActive(true);
        my_light[1].SetActive(true);
        Invoke("obj0", 1);
    }
}

