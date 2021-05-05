namespace Program_Lab3.States
{
    public interface IState
    {
        void ShowState();
        void GetMoney();
        void GetRequestAmount();
        void NextState();
    }
}