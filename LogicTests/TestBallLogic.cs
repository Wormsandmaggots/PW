﻿using Data;

namespace LogicTests
{
    internal class TestBallLogic : IBallLogic
    {
        public event Action<Object> PropertyChanged;

        private IBall _ball;

        public TestBallLogic(IBall ball)
        {
            _ball = ball;
            _ball.PropertyChanged += Update;
        }

        private void Update()
        {
            OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this);
        }

        public void ToggleBall(bool val)
        {
            _ball.ToggleBall(val);
        }

        public void Dispose()
        {
            _ball.PropertyChanged -= Update;
            PropertyChanged = (Action<Object>)Delegate.RemoveAll(PropertyChanged, PropertyChanged);
            _ball.Dispose();
        }

        public bool CanCollide()
        {
            throw new NotImplementedException();
        }

        public void SetCanCollide(bool canCollide)
        {
            throw new NotImplementedException();
        }

        public double X
        {
            get { return _ball.X; }
            set
            {
                _ball.X = value;
            }
        }

        public double Y
        {
            get { return _ball.Y; }
            set
            {
                _ball.Y = value;
            }
        }

        public int Radius
        {
            get { return _ball.Radius; }
        }

        double IBallLogic.X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IBallLogic.Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double XVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double YVelocity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Weight => throw new NotImplementedException();
    }
}
