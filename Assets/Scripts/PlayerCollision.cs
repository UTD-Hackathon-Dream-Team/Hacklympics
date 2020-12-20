﻿using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            var gameOver = FindObjectOfType<EndGame>();
            gameOver.ShowButtons();
            GameObject.Find("Player").SendMessage("Finish");
        }
        // && collisionInfo.collider.tag == "Mountain_winter_002"

    }

}
