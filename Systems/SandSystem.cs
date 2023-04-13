using EntitiesCollisionsSandbox.Collisions;
using EntitiesCollisionsSandbox.Components;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;

namespace EntitiesCollisionsSandbox.Systems
{
    internal class SandSystem : EntityProcessingSystem
    {
        private ComponentMapper<Sand> _sandMapper;
        private ComponentMapper<Body> _bodyMapper;
        private ComponentMapper<Texture2D> _textureMapper;
        public SandSystem() : base(Aspect.All(typeof(Sand), typeof(Body), typeof(Texture2D)))
        {
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _sandMapper = mapperService.GetMapper<Sand>();
            _bodyMapper = mapperService.GetMapper<Body>();
            _textureMapper = mapperService.GetMapper<Texture2D>();
        }

        public override void Process(GameTime gameTime, int entityId)
        {
            var sand = _sandMapper.Get(entityId);
            var body = _bodyMapper.Get(entityId);
            var texture = _textureMapper.Get(entityId);
        }
    
    }
}
