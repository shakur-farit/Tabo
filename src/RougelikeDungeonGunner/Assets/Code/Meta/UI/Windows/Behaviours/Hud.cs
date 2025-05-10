using UnityEngine;
using Zenject;

namespace Code.Meta.UI.UIRoot.Factory
{
	public class Hud : BaseWindow
	{
		[Inject]
		public void Constructor() => 
			Id = WindowId.Hud;

		protected override void Initialize()
		{
		}
	}
}