using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public enum SoundEffect
    {
        Fire1,
        Fire2,
        Fire3,
        Jump,
        BackgroundMusic
    }

    public enum BackgroundMusic
    {
        BackgroundMusic1
    }


    public AudioSource fire1Effectt;
    public AudioSource fire2Effectt;
    public AudioSource fire3Effectt;
    public AudioSource jumpEffectt;
    public AudioSource backgroundMusic;

    public static AudioManager Instance;

    private void Awake()
    {
        Instance = this;        
    }
    public void PlaySoundEffect(SoundEffect type)
    {
      switch(type)
        {
            case SoundEffect.Fire1:
                fire1Effectt.Play();

                break;
            case SoundEffect.Fire2:

                fire2Effectt.Play();
                break;
            case SoundEffect.Fire3:

                fire3Effectt.Play();
                break;
            case SoundEffect.Jump:
                jumpEffectt.Play();

                break;
            case SoundEffect.BackgroundMusic:
                backgroundMusic.Play();

                break;
        }
    }

    public void PlayBackgroundMusic(BackgroundMusic type)
    {
        switch (type)
        {
            case BackgroundMusic.BackgroundMusic1:
                backgroundMusic.Play();

                break;
        }
    }
    }
