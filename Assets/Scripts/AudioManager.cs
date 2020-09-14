using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource[] music;
    public AudioSource[] soundEffects;

    private Dictionary<string, AudioSource> soundEffectMap = new Dictionary<string, AudioSource>();
    private Dictionary<string, AudioSource> musicMap = new Dictionary<string, AudioSource>();

    public string levelMusicToPlay;

    public AudioMixerGroup musicMixer, sfxMixer;

    public void Awake()
    {
        instance = this;
        foreach(var m in music)
        {
            musicMap.Add(m.name, m);
        }
        foreach (var soundEffect in soundEffects)
        {
            musicMap.Add(soundEffect.name, soundEffect);
        }
    }

    void Start()
    {
        PlayMusic(levelMusicToPlay);
    }

    public void PlayMusic(string musicToPlay)
    {
        foreach (var m in musicMap)
        {
            m.Value.Stop();
        }
        musicMap[musicToPlay].Play();
    }

    public void PlaySoundEffect(string soundEffectName)
    {
        soundEffectMap[soundEffectName].Play();
    }

    public void SetMusicLevel()
    {
        musicMixer.audioMixer.SetFloat("MusicVol",UIManager.instance.musicVolSlider.value);
    }
    public void SetSFXLevel()
    {
        sfxMixer.audioMixer.SetFloat("SfxVol", UIManager.instance.sfxVolSlider.value);
    }
}
