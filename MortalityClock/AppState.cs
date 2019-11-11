using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MortalityClock
{
    public class AppState
    {
        public DateTime BirthDate { get; private set;}
        public int Duration;
        public event Action OnChange;

        public void SetBirthDate(DateTime date)
        {
            BirthDate = date;
            NotifyStateChanged();

        }

        private void NotifyStateChanged() => OnChange?.Invoke();
        
     
    }
}
