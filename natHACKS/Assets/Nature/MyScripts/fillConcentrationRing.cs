using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillConcentrationRing : MonoBehaviour
{
    public Image ring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        concentrationFiller();
    }

    public void concentrationFiller()
    {
        ring.fillAmount = Mathf.Lerp(ring.fillAmount, concentrationClass.concentration_lvl, 3f*Time.deltaTime);
    }
}
