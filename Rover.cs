namespace MarsRoverApp
{
    public class Rover
    {
        private int _x;
        private int _y;
        private char _direction;
        private readonly Plateau _plateau;

        public Rover(int x, int y, char direction, Plateau plateau)
        {
            _x = x;
            _y = y;
            _direction = direction;
            _plateau = plateau;
        }
        public void ExecuteCommands(string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                }
            }
        }
        private void TurnLeft()
        {
            _direction = _direction switch
            {
                'N' => 'W',
                'W' => 'S',
                'S' => 'E',
                'E' => 'N',
                _ => _direction
            };
        }
        private void TurnRight()
        {
            _direction = _direction switch
            {
                'N' => 'E',
                'E' => 'S',
                'S' => 'W',
                'W' => 'N',
                _ => _direction
            };
        }
        private void Move()
        {
            int newX = _x, newY = _y;

            switch (_direction)
            {
                case 'N': newY += 1; break;
                case 'E': newX += 1; break;
                case 'S': newY -= 1; break;
                case 'W': newX -= 1; break;
            }

            (newX, newY) = _plateau.ClampPosition(newX, newY);
            _x = newX;
            _y = newY;
        }

        public string GetCurrentPosition()
        {
            return $"{_x} {_y} {_direction}";
        }
    }
}
