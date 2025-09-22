using Assets.Code.Gameplay.Features.Dungeon.Systems;
using Assets.Code.Infrastructure.Systems;

namespace Assets.Code.Gameplay.Features.Dungeon
{
	public sealed class DungeonFeature : Feature
	{
		public DungeonFeature(ISystemsFactory systems)
		{
			Add(systems.Create<CreateDungeonSystem>());
			Add(systems.Create<GetValidPositionsOnCollisionTilemapSystem>());
		}
	}
}