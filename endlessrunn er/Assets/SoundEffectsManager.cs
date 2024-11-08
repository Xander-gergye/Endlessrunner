using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip coin;
    public AudioClip doubleJump;
    public AudioClip gameOverHit;
    public AudioClip jump;
    public AudioClip land;
    public AudioClip doubleJumpPowerUp;
    public AudioClip shieldPowerUp;
    public AudioClip shieldBreak;

    public void PlaySFX(string clipToPlay)
    {
        if (clipToPlay == "Coin")
        {
            audioSource.clip = coin;
        }
        if (clipToPlay == "DoubleJump")
        {
            audioSource.clip = doubleJump;
        }
        if (clipToPlay == "Jump")
        {
            audioSource.clip = jump;
        }
        if (clipToPlay == "Land")
        {
            audioSource.clip = land;
        }
        if (clipToPlay == "DoubleJumpPowerUp")
        {
            audioSource.clip = doubleJumpPowerUp;
        }
        if (clipToPlay == "ShieldPowerUp")
        {
            audioSource.clip = shieldPowerUp;
        }
        if (clipToPlay == "ShieldBreak")
        {
            audioSource.clip = shieldBreak;
        }
        

        audioSource.Play();
    }
}
