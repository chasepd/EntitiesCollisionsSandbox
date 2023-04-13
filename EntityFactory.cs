using EntitiesCollisionsSandbox.Collisions;
using EntitiesCollisionsSandbox.Components;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCollisionsSandbox
{
    internal class EntityFactory
    {
        private readonly World _world;
        private readonly ContentManager _contentManager;
        private readonly GraphicsDevice _graphicsDevice;

        public EntityFactory(World world, ContentManager contentManager, GraphicsDevice graphicsDevice)
        {
            _world = world;
            _contentManager = contentManager;
            _graphicsDevice = graphicsDevice;
        }

        public Entity CreateFire(Vector2 Position)
        {
            var fireTexture = new Texture2D(_graphicsDevice, 1, 1);
                        
            if (GameState.FireTemperature <=  799)
                fireTexture.SetData(new Color[] { Color.Red });
            else if(GameState.FireTemperature < 1400 &&  GameState.FireTemperature > 799)
                fireTexture.SetData(new Color[] { Color.Orange });
            else
                fireTexture.SetData(new Color[] { Color.Blue });

            var entity = _world.CreateEntity();
            entity.Attach(fireTexture);
            entity.Attach(new FireBody(Position));
            entity.Attach(new Fire() { Temperature = GameState.FireTemperature });
            return entity;
        }

        public Entity CreateWater(Vector2 Position) 
        {
            var waterTexture = new Texture2D(_graphicsDevice, 1, 1);
            waterTexture.SetData(new Color[] { Color.CornflowerBlue });

            var entity = _world.CreateEntity();
            entity.Attach(waterTexture);
            entity.Attach(new WaterBody(Position));
            entity.Attach(new Water() { Temperature = GameState.WaterTemperature });
            return entity;
        }

        public Entity CreateSand(Vector2 Position) 
        { 
            var sandTexture = new Texture2D(_graphicsDevice, 1, 1);
            sandTexture.SetData(new Color[] {Color.Tan});

            var entity = _world.CreateEntity();
            entity.Attach(sandTexture);
            entity.Attach(new SandBody(Position));
            entity.Attach(new Sand() { Temperature = GameState.SandTemperature });
            return entity;
        }
    }
}
