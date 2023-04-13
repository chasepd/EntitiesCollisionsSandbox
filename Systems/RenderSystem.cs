using EntitiesCollisionsSandbox.Collisions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox.Systems
{
    internal class RenderSystem : EntityDrawSystem
    {
        private readonly SpriteBatch _spriteBatch;
        private ComponentMapper<Body> _bodyMapper;
        private ComponentMapper<Texture2D> _textureMapper;

        public RenderSystem(SpriteBatch spriteBatch) : base(Aspect.All(typeof(Body), typeof(Texture2D))) 
        {
            _spriteBatch = spriteBatch;
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            _bodyMapper = mapperService.GetMapper<Body>();
            _textureMapper = mapperService.GetMapper<Texture2D>();
        }

        public override void Draw(GameTime gameTime)
        {
            _spriteBatch.Begin();

            foreach(var entity in ActiveEntities)
            {
                var texture = _textureMapper.Get(entity);
                var body = _bodyMapper.Get(entity);

                _spriteBatch.Draw(
                    texture,
                    new Rectangle((int)body.Position.X, (int)body.Position.Y, 1, 1),
                    Color.White
                    );
            }

            _spriteBatch.End();
        }
    }
}
