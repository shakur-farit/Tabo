using Assets.Code.Gameplay.Input.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Input
{
	public sealed class InputFeature : Feature
	{
		public InputFeature(ISystemsFactory systems)
		{
			Add(systems.Create<InitializeInputSystem>());

			Add(systems.Create<EmitAxisInputSystem>());
			Add(systems.Create<EmitLeftMouseButtonInputSystem>());
			Add(systems.Create<EmitEscButtonInputSystem>());
		}
	}
}