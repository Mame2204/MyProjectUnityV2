using UnityEngine;
using System.Collections;

/// <summary>
/// Création d'effets sonores en toute simplicité
/// </summary>
public class SoundEffectsHelper : MonoBehaviour
{

  /// <summary>
  /// Singleton
  /// </summary>
  public static SoundEffectsHelper Instance;

  public AudioClip pieceSound;
  public AudioClip chuteSound;
  public AudioClip buzzerSortieParcoursSound;
  public AudioClip applaudissementSound;

  void Awake()
  {
    if (Instance != null)
    {
      Debug.LogError("Multiple instances of SoundEffectsHelper!");
    }
    Instance = this;
  }

  public void MakePieceSound()
  {
    MakeSound(pieceSound);
  }

  public void MakeChuteSound()
  {
    MakeSound(chuteSound);
  }

  public void MakeBuzzerSortieParcoursSound()
  {
    MakeSound(buzzerSortieParcoursSound);
  }

  public void MakeApplaudissementSound()
  {
    MakeSound(applaudissementSound);
  }

  /*public void MakeEnemyShotSound()
  {
    MakeSound(enemyShotSound);
  }*/

  /// <summary>
  /// Lance la lecture d'un son
  /// </summary>
  /// <param name="originalClip"></param>
  private void MakeSound(AudioClip originalClip)
  {
    AudioSource.PlayClipAtPoint(originalClip, transform.position);
  }
}