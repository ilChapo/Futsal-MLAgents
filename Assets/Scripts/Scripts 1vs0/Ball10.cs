using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball10 : MonoBehaviour
{

  public GameObject agent;

  AgentControl10 agentControl;

    // Start is called before the first frame update
    void Start()
    {
      agentControl = agent.GetComponent<AgentControl10>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("goal"))
        {
            agentControl.AddScore();
            agentControl.EndOfEpisode(1);
        }
        else if (col.gameObject.CompareTag("out"))
        {

            agentControl.EndOfEpisode(2);

        }
    }
}
