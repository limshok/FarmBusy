using DependencyManagement;
using Player.Movement;
using Utilities;

namespace Player
{
    public class PlayerPresenter : IPresenter
    {
        private readonly IContext _context;
        private readonly PlayerModel _model;
        private readonly PlayerView _view;

        private PlayerMovementPresenter _movementPresenter;

        public PlayerPresenter(IContext context,PlayerModel model,PlayerView view)
        {
            _context = context;
            _model = model;
            _view = view;
        }
        
        public void Attach()
        {
            _movementPresenter = new PlayerMovementPresenter(_context,_model.PlayerMovementModel,_view.GetComponent<PlayerMovementView>());
            _movementPresenter.Attach();
        }

        public void Detach()
        {
            _movementPresenter.Detach();
        }
    }
}