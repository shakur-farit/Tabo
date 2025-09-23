using Code.Gameplay.Features.Dungeon.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Dungeon
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