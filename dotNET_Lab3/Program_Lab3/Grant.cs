using Program_Lab3.States;

namespace Program_Lab3
{
    public class Grant
    {
        private NoRequestState NoRequest { get; }
        public CreatedState Created { get; }
        public UnderConsiderationState UnderConsideration { get; }
        public ConfirmedState Confirmed { get; }
        public RejectedState Rejected { get; }
        public WithdrawnState Withdrawn { get; }

        private IState _currentState;

        public Grant()
        {
            NoRequest = new NoRequestState(this);
            Created = new CreatedState(this);
            UnderConsideration = new UnderConsiderationState(this);
            Confirmed = new ConfirmedState(this);
            Rejected = new RejectedState(this);
            Withdrawn = new WithdrawnState(this);

            _currentState = NoRequest;
        }

        public void NextState()
        {
            _currentState.NextState();
        }
        
        public void ShowState()
        {
            _currentState.ShowState();
        }

        public void GetMoney()
        {
            _currentState.GetMoney();
        }

        public void GetRequestAmount()
        {
            _currentState.GetRequestAmount();
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }
    }
}