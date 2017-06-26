﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pj4
{
    public interface Option<T>
    {
        void Visit(Action onNone, Action<T> onSome);
        U Visit<U>(Func<U> onNone, Func<T, U> onSome);
    }
    public class None<T> : Option<T>
    {
        public void Visit(Action onNone, Action<T> onSome)
        {
            onNone();
        }

        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onNone();
        }
    }
    public class Some<T> : Option<T>
    {
        T value;
        public Some(T value) { this.value = value; }

        public void Visit(Action onNone, Action<T> onSome)
        {
            onSome(value);
        }

        public U Visit<U>(Func<U> onNone, Func<T, U> onSome)
        {
            return onSome(value);
        }
    }
}
