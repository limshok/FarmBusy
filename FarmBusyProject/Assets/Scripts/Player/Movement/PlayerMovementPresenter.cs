using DependencyManagement;
using Systems;
using UnityEngine;
using Utilities;

namespace Player.Movement
{
    public class PlayerMovementPresenter : IPresenter,ISystem
    {
        private readonly IContext _context;
        private readonly PlayerMovementModel _model;
        private readonly PlayerMovementView _view;

        public PlayerMovementPresenter(IContext context,PlayerMovementModel model,PlayerMovementView view)
        {
            _context = context;
            _model = model;
            _view = view;
        }


        public void Attach()
        {
            _context.SystemManager.Add(this);
        }

        public void Detach()
        {
            _context.SystemManager.Remove(this);
        }

        public void Update(float deltaTime)
        {
            if (_model.Input.sqrMagnitude > 0)
            {
                var direction = Mathf.Atan2(_model.Input.x, _model.Input.y);
                if (_view.transform.eulerAngles.y - direction > _model.Description.RotationSpeed * deltaTime)
                {
                    _view.transform.Rotate(Vector3.up,_model.Description.RotationSpeed * deltaTime);
                }
                else
                {
                    _view.transform.eulerAngles = new Vector3(_view.transform.eulerAngles.x,direction,_view.transform.eulerAngles.z);
                }
            }

            _model.Speed = Mathf.Clamp(_model.Speed + _model.Description.Acceleration * deltaTime,0,_model.Input.sqrMagnitude * _model.Description.MaxSpeed);
            _view.transform.Translate(Vector3.forward * _model.Speed);
        }
    }
}