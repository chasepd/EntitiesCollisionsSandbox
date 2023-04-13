using EntitiesCollisionsSandbox.Collisions;
using EntitiesCollisionsSandbox.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace EntitiesCollisionsSandbox.Systems
{
    internal class FireSystem : EntityProcessingSystem
    {
        private ComponentMapper<Fire> _fireMapper;
        private ComponentMapper<Body> _bodyMapper;
        private ComponentMapper<Texture2D> _textureMapper;
        public FireSystem() : base(Aspect.All(typeof(Fire), typeof(Body), typeof(Texture2D)))
        {
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _fireMapper = mapperService.GetMapper<Fire>();
            _bodyMapper = mapperService.GetMapper<Body>();
            _textureMapper = mapperService.GetMapper<Texture2D>();
        }

        public override void Process(GameTime gameTime, int entityId)
        {
            var fire = _fireMapper.Get(entityId);
            var body = _bodyMapper.Get(entityId);
            var texture = _textureMapper.Get(entityId);
        }

    }
}
