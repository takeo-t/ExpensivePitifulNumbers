using System;

namespace MyNamespace2
{
    public class Complex
    {
        public double Re;// 実部を記憶しておく（外部からの読み出し/書き換えも可能）
        public double Im;// 虚部を記憶しておく（外部からの読み出し/書き換えも可能）

        // 絶対値を取り出す
        public double Abs()
        {
            // Math.Aqrtは平方根を求めるmethod
            return Math.Sqrt(Re * Re + Im * Im);
        }
    }
}