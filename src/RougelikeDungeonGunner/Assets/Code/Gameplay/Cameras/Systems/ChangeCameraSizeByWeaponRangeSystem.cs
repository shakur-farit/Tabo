using System.Collections.Generic;
using Code.Gameplay.Cameras.Provider;
using Entitas;

namespace Code.Gameplay.Cameras.Systems
{
	public class ChangeCameraSizeByWeaponRangeSystem : ReactiveSystem<GameEntity>
	{
		private readonly ICameraProvider _cameraProvider;

		public ChangeCameraSizeByWeaponRangeSystem(Contexts contexts, ICameraProvider cameraProvider) : base(contexts.game) => 
			_cameraProvider = cameraProvider;


		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) =>
			context.CreateCollector(GameMatcher.AllOf(
					GameMatcher.Weapon,
					GameMatcher.HeroWeapon,
					GameMatcher.Radius)
				.Added());

		protected override bool Filter(GameEntity weapons) =>
			weapons.isWeapon && weapons.isHeroWeapon && weapons.hasRadius;

		protected override void Execute(List<GameEntity> weapons)
		{
			foreach (GameEntity weapon in weapons)
				_cameraProvider.SetCameraSize(weapon.Radius);
		}
	}
}