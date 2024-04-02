using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("VolumeMusique", ConvertToLogarithmique(volume));
    }

    public void AjusteVolumeFX(float volume){
        audioMixer.SetFloat("VolumeFX", ConvertToLogarithmique(volume));
    }

    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }
    
    
}
