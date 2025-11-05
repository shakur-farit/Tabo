using UnityEngine;

namespace Code.Meta.UI.Windows.Config
{
  [CreateAssetMenu(menuName = "Dungeon Gunner/Dialogue Config", fileName = "DialogueConfig")]
  public class DialogueConfig : ScriptableObject
  {
    public string AppliedEnchant;
    public string NotEnoughCoins;
    public string MaxValue;
    public string EmptyNameField;
    public string LongName;
    public string ShortName;
  }
}