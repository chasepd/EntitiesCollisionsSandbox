using EntitiesCollisionsSandbox.Systems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Input;
using MonoGame.Extended.Screens;
using MonoGame.Extended;

namespace EntitiesCollisionsSandbox.Screens
{
    internal class EntitiesCollisionsSandboxScreen : GameScreen
    {
        private World _world;
        private EntityFactory _entityFactory;
        private const double _spawnTimeDelay = 0.1f;
        private double _spawnTimeTracker;

        public EntitiesCollisionsSandboxScreen(Game game) : base(game) 
        {
            GameState.FireTemperature = 1000;
            _spawnTimeTracker = 0;
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
                .AddSystem(new WorldSystem())
                .Build();

            Game.Components.Add(_world);

            _entityFactory = new EntityFactory(_world, Content, GraphicsDevice);

            _entityFactory.CreateBottomBoundary();
        }

        public override void Update(GameTime gameTime)
        {
            if(_spawnTimeTracker < _spawnTimeDelay)
                _spawnTimeTracker += gameTime.GetElapsedSeconds();

            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                Game.Exit();

            var mouseState = MouseExtended.GetState();
            _world.Update(gameTime);

            if (mouseState.IsButtonDown(MouseButton.Left) && _spawnTimeTracker >= _spawnTimeDelay)
            {
                _entityFactory.CreateSand(new Vector2(mouseState.X, mouseState.Y));
                _spawnTimeTracker = 0;
            }
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _world.Draw(gameTime);
        }
    }
}
