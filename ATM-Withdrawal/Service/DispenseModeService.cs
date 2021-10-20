using ATM_Withdrawal.Repository;

namespace ATM_Withdrawal.Service
{
    public class DispenseModeService
    {
        MainRepository mainRepository = MainRepository.Instance;

        public void SetMode(int mode)
        {
            mainRepository.dispenseMode = mode;
        }
    }
}
