using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashlightOnOff : MonoBehaviour
{

    public GameObject noLight;
    public GameObject light;
    public Text flashlightMessage;
    public Timer t;
    //bool button = false;
    // Start is called before the first frame update
    
    IEnumerator waitTime() {
        yield return new WaitForSeconds(1f);
        noLight.active = false;
        light.active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            light.active = false;
            Destroy(flashlightMessage);
            light.active = !light.active;
            noLight.active = !noLight.active;
        }

        if (t.time == 0) {
            noLight.active = true;
            StartCoroutine(waitTime());
        }
    }
}
