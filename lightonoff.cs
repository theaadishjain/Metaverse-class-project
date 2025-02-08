using UnityEngine;

public class LightOnOff : MonoBehaviour
{
    public int x; 
    public GameObject[] my_light; 
    public string y; 

    // Start is called once before the first frame update
    void Start()
    {
   
        /*for (int i = 0; i < 3; i++)
        {
            my_light[i].SetActive(false); 
        }*/
    }

    void Update()
    {
       
        for (int i = 0; i < my_light.Length; i++)
        {
        
            if (my_light[i].name == y)
            {
                my_light[i].SetActive(false); 
            }
        }
    }
}
