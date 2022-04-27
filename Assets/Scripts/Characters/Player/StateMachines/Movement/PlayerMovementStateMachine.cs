namespace GIMovementSystem
{
    public class PlayerMovementStateMachine : StateMachine
    {
        public Player Player { get; }

        public PlayerIdlingState IdlingState { get; }

        public PlayerWalkingState WalkingState { get; }
        public PlayerSprintingState SprintingState { get; }
        public PlayerRunningState RunningState { get; }

        public PlayerMovementStateMachine(Player player)
        {
            Player = player;

            IdlingState = new PlayerIdlingState();

            WalkingState = new PlayerWalkingState();
            SprintingState = new PlayerSprintingState();
            RunningState = new PlayerRunningState();
        }
    }
}