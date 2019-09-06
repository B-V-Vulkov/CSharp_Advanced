namespace P07.Tuple
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Tuple<T, K>
    {
        private T itam1;
        private K itam2;

        public Tuple(T itam1, K itam2)
        {
            this.itam1 = itam1;
            this.itam2 = itam2;
        }

        public override string ToString()
        {
            return $"{this.itam1} -> {this.itam2}";
        }
    }
}
