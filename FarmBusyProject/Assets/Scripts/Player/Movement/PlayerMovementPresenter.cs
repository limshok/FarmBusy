namespace Player.PlayerEntity
{
    public class PlayerMovementPresenter
    {
        private readonly PlayerMovementModel _model;
        private readonly PlayerMovementView _view;

        public PlayerMovementPresenter(PlayerMovementModel model,PlayerMovementView view)
        {
            _model = model;
            _view = view;
        }
    }
}