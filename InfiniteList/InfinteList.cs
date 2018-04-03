using System;
using System.Collections;
using InfiniteList;


namespace InfiniteList
{
    public class IL : IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ILEnumerator GetEnumerator()
        {
            return new ILEnumerator();
        }
    }
   public class ILEnumerator : IEnumerator
   {
        private int _current = -1;

        public object Current
        {
            get => this._current;
        }

        public void Reset()
        {
            this._current = -1;
        }

        public bool MoveNext()
        {
            this._current += 1;

            return true;
        }
   }
           
        
}
