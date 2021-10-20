using ATM_Withdrawal.Enum;

namespace ATM_Withdrawal.Repository
{
    public class MainRepository
    {
        public static MainRepository Instance { get; } = new MainRepository();

        public int dispenseMode = (int)DispenseMenuOptions.EFFICIENT_MODE;

        public int withdrawalAmount = 0;

        private MainRepository() { }
    }
}
