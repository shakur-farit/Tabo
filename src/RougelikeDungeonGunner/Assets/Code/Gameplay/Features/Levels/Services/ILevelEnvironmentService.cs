using Code.Gameplay.Features.Levels.Configs;

namespace Code.Gameplay.Features.Levels
{
	public interface ILevelEnvironmentService
	{
		EnvironmentSetup GetEnvironmentSetup(LevelTypeId levelId);
	}
}