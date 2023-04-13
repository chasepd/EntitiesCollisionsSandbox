using EntitiesCollisionsSandbox.Collisions;
using EntitiesCollisionsSandbox.Components;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace EntitiesCollisionsSandbox.Systems
{
    internal class WaterSystem : EntityProcessingSystem
    {
        private ComponentMapper<Water> _waterMapper;
        private ComponentMapper<Body> _bodyMapper;
        private ComponentMapper<Texture2D> _textureMapper;
        public WaterSystem() : base(Aspect.All(typeof(Water), typeof(Body), typeof(Texture2D)))
        {
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _waterMapper = mapperService.GetMapper<Water>();
            _bodyMapper = mapperService.GetMapper<Body>();
            _textureMapper = mapperService.GetMapper<Texture2D>();
        }

        public override void Process(GameTime gameTime, int entityId)
        {
            var water = _waterMapper.Get(entityId);
            var body = _bodyMapper.Get(entityId);
            var texture = _textureMapper.Get(entityId);
        }
    }
}
