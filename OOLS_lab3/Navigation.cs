using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OOLS_lab3
{
    public class Navigation
    {
        private static Navigation instance;

        private Navigation()
        { }
        private readonly Stack<Page> history = new Stack<Page>();
        private Page currentPage;

        public event Action<Page> OnPageChanged;
        public static Navigation GetInstance()
        {
            if (instance == null)
                instance = new Navigation();
            return instance;
        }
        public void Navigate(Page target)
        {
            if(currentPage != null) 
                history.Push(currentPage);
            
            currentPage = target;
            OnPageChanged?.Invoke(target);
        }
        public void GoBack()
        {
            if (history.Count > 0)
            {
                Page oldpage = history.Pop();
                OnPageChanged?.Invoke(oldpage);
            }
        }
    }
}
