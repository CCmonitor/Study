using System;

namespace _Event
{
    class Person
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                if (value % 12 == 0)
                {
                    if (OnBenMingNian != null)
                    {
                        OnBenMingNian();
                    }
                }

            }
        }

        //public event Action OnBenMingNian;//event  委托类型 事件的名字
        public  Action OnBenMingNian;//加上event就是事件，不加event就是普通的委托
    }
}