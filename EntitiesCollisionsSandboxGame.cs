using EntitiesCollisionsSandbox.Screens;
using Microsoft.Xna.Framework;
using MonoGame.Extended;
using MonoGame.Extended.Screens;

namespace EntitiesCollisionsSandbox
{
    public class EntitiesCollisionsSandboxGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private ScreenManager _screenManager;

        public EntitiesCollisionsSandboxGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.PreferredBackBufferWidth = 1920;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _screenManager = Components.Add<ScreenManager>();
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _screenManager.LoadScreen(new EntitiesCollisionsSandboxScreen(this));
        }
    }
}