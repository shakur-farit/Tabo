using System.IO;
using Code.Progress.Data.Progress;
using Code.Progress.Provider;
using UnityEngine;

namespace Code.Progress.SaveLoad
{
  public  class SaveLoadSystem : ISaveSystem, ILoadSystem
  {
    private  readonly string FilePath = Path.Combine(Application.persistentDataPath, "save.json");
    
    private readonly IProgressProvider _progressProvider;

    public SaveLoadSystem(IProgressProvider progressProvider) => 
      _progressProvider = progressProvider;

    public void Save()
    {
      string json = JsonUtility.ToJson(_progressProvider.ProgressData, true);

      File.WriteAllText(FilePath, json);
    }

    public ProgressData Load()
    {
      if (File.Exists(FilePath) == false)
        return null;

      string json = File.ReadAllText(FilePath);
      return JsonUtility.FromJson<ProgressData>(json);
    }
  }
}