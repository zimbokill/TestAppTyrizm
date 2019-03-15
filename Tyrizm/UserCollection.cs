using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TrainingGenerator
{
    public class UserCollection : IEnumerable, IEnumerator
    {
        

     

        // Указатель текущей позиции элемента в массиве.
        private int position = -1;

        public void SetPosition(int value)
        {
            position = value;
        }

        // ------------------------------------------------------------------------------------------------------------------
        // Реализация интерфейса IEnumerator.

        // Передвинуть внутренний указатель (position) на одну позицию.
        public bool MoveNext()
        {
            if (position < Users.users.Count - 1)
            {

                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Установить указатель (position) перед началом набора.
        public void Reset()
        {
            position = -1;
        }

        // Получить текущий элемент набора. 
        public object Current
        {
            get { return Users.users[position]; }
        }

        // -----------------------------------------------------------------------------------------------------------------
        // Реализация интерфейса - IEnumerable.

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
