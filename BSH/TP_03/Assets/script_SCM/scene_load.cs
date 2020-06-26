using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class scene_load : MonoBehaviour
{
    public Slider progressbar;
    public Text loadtext;

    void Start()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);
        operation.allowSceneActivation = false;

        while(!operation.isDone)
        {
            yield return null;
            if(progressbar.value<1f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, 0.5f*Time.deltaTime);

            }
            else
            {
                loadtext.text ="Press SpaceBar";
            }
            if (Input.GetKeyDown(KeyCode.Space) && progressbar.value >= 1f && operation.progress >= 0.9f)
            {
                float fadeTime = GameObject.Find("fading").GetComponent<fading>().BeginFade(1);
                yield return new WaitForSeconds(fadeTime);
         


                operation.allowSceneActivation = true;
            }

        }

    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
