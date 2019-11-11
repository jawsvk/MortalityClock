using System;

namespace MortalityClock
{
    public class AppState
    {
        public DateTime BirthDate { get; private set; }
        public int Years { get; private set; }
        public event Action OnChange;
        public bool ShouldHide = true;

        public void SetState(DateTime date, int number)
        {
            BirthDate = date;
            Years = number;
            ShouldHide = false;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
        
     
    }
}
