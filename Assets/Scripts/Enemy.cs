using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public float speed = 1f;
    private GameObject _player;
    private Transform _target;

    int count = 0;
    
    private bool move = false;

    Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        originalPosition = this.transform.localPosition;
        _player = GameObject.FindGameObjectWithTag("MainCamera");
        _target = _player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        move = false;
        this.transform.localPosition = originalPosition;
    }

    void OnSelect()
    {
        if(count < 1)
        {
            count++;
            AudioSource audio = this.GetComponent<AudioSource>();
            audio.Play();
        }
        move = true;
    }
}
