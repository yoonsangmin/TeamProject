using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class talkmanager : MonoBehaviour,IPointerDownHandler
{
    public Text dialoguetext;
    public GameObject nexttext;

    public Queue<string> sentences;
    public CanvasGroup dialoguegroup;
    private string currentsentences;

    public float typingspeed = 0.1f;
    private bool istyping;

    public static talkmanager instance;

    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

    }

    public void ondialogue(string[]lines)
    {
        sentences.Clear();
        foreach(string line in lines)
        {
            sentences.Enqueue(line);
        }
        dialoguegroup.alpha = 1;
        dialoguegroup.blocksRaycasts = true;

        nextsentence();
    }
    public void nextsentence()
    {
        if(sentences.Count !=0)
        {
            currentsentences = sentences.Dequeue();
            istyping = true;
            nexttext.SetActive(false);
            StartCoroutine(typing(currentsentences));
        }
        else
        {
            dialoguegroup.alpha = 0;
            dialoguegroup.blocksRaycasts = false;

        }
    }
    IEnumerator typing(string line)
    {
        dialoguetext.text = "";
        foreach(char letter in line.ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(typingspeed);
        }

    }
    // Update is called once per frame
    private void Update()
    {
        if(dialoguetext.text.Equals(currentsentences))
        {
            nexttext.SetActive(true);
            istyping = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!istyping)
        {
            nextsentence();
        }
    }
    
   
}
