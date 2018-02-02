using System;

namespace Functional
{
    public static class Curry
    {
        #region static method Make
        public static Func<TR> Make<TR>(Func<TR> func)
            => func;
        
        public static Func<T1, TR> Make<T1, TR>(Func<T1, TR> func)
            => in1
            => func(in1);

        public static Func<T1, Func<T2, TR>> Make<T1, T2, TR>(Func<T1, T2, TR> func)
            => in1
            => in2
            => func(in1, in2);

        public static Func<T1, Func<T2, Func<T3, TR>>> Make<T1, T2, T3, TR>(Func<T1, T2, T3, TR> func)
             => in1
             => in2
             => in3
             => func(in1, in2, in3);

        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Make<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> func)
            => in1
            => in2
            => in3
            => in4
            => func(in1, in2, in3, in4);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Make<T1, T2, T3, T4, T5, TR>(Func<T1, T2, T3, T4, T5, TR> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => func(in1, in2, in3, in4, in5);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Make<T1, T2, T3, T4, T5, T6, TR>(Func<T1, T2, T3, T4, T5, T6, TR> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => func(in1, in2, in3, in4, in5, in6);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Make<T1, T2, T3, T4, T5, T6, T7, TR>(Func<T1, T2, T3, T4, T5, T6, T7, TR> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => in7
            => func(in1, in2, in3, in4, in5, in6, in7);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> Make<T1, T2, T3, T4, T5, T6, T7, T8, TR>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => in7
            => in8
            => func(in1, in2, in3, in4, in5, in6, in7, in8);

        public static Action Make(Action func)
            => func;

        public static Action<T1> Make<T1>(Action<T1> func)
            => in1
            => func(in1);

        public static Func<T1, Action<T2>>  Make<T1, T2>(Action<T1, T2> func)
            => in1
            => in2
            => func(in1, in2);

        public static Func<T1, Func<T2, Action<T3>>> Make<T1, T2, T3>(Action<T1, T2, T3> func)
             => in1
             => in2
             => in3
             => func(in1, in2, in3);

        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Make<T1, T2, T3, T4>(Action<T1, T2, T3, T4> func)
            => in1
            => in2
            => in3
            => in4
            => func(in1, in2, in3, in4);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Make<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => func(in1, in2, in3, in4, in5);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Make<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => func(in1, in2, in3, in4, in5, in6);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Make<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => in7
            => func(in1, in2, in3, in4, in5, in6, in7);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Make<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> func)
            => in1
            => in2
            => in3
            => in4
            => in5
            => in6
            => in7
            => in8
            => func(in1, in2, in3, in4, in5, in6, in7, in8);

        #endregion

        #region Extension method

        public static Func<TR> Curried<TR>(this Func<TR> func)
            => Make(func);

        public static Func<T1, TR> Curried<T1, TR>(this Func<T1, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, TR>> Curried<T1, T2, TR>(this Func<T1, T2, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, TR>>> Curried<T1, T2, T3, TR>(this Func<T1, T2, T3, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Curried<T1, T2, T3, T4, TR>(this Func<T1, T2, T3, T4, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Curried<T1, T2, T3, T4, T5, TR>(this Func<T1, T2, T3, T4, T5, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Curried<T1, T2, T3, T4, T5, T6, TR>(this Func<T1, T2, T3, T4, T5, T6, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TR>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, TR> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TR>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8, TR>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TR> func)
            => Make(func);

        public static Action<T1> Curried<T1>(this Action<T1> func)
            => Make(func);

        public static Func<T1, Action<T2>> Curried<T1, T2>(this Action<T1, T2> func)
            => Make(func);

        public static Func<T1, Func<T2, Action<T3>>> Curried<T1, T2, T3>(this Action<T1, T2, T3> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curried<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curried<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curried<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> func)
            => Make(func);

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Curried<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> func)
            => Make(func);
        #endregion
    }
}
