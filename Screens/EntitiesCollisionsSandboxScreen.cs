using EntitiesCollisionsSandbox.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Input;
using MonoGame.Extended.Screens;

namespace EntitiesCollisionsSandbox.Screens
{
    internal class EntitiesCollisionsSandboxScreen : GameScreen
    {
        private World _world;
        private EntityFactory _entityFactory;

        public EntitiesCollisionsSandboxScreen(Game game) : base(game) 
        {
            GameState.FireTemperature = 1000;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void LoadContent()
        {            
            base.LoadContent();

            _world = new WorldBuilder()
                .AddSystem(new FireSystem())
                .AddSystem(new WaterSystem())
                .AddSystem(new SandSystem())
                .AddSystem(new RenderSystem(new SpriteBatch(GraphicsDevice)))
                .Build();

            Game.Components.Add(_world);

            _entityFactory = new EntityFactory(_world, Content, GraphicsDevice);
        }

        public override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Game.Exit();

            var mouseState = MouseExtended.GetState();

            if (mouseState.IsButtonDown(MouseButton.Left))
                _entityFactory.CreateSand(new Vector2(mouseState.X, mouseState.Y));
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _world.Draw(gameTime);
        }
    }
}
