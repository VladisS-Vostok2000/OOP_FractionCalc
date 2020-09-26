using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalc {
    public static class UpMatch {
        public static Int32 FindNOK(Int32 _denum1, Int32 _denum2) {
            return _denum1 * _denum2 / FindNOD(_denum1, _denum2);
        }
        public static Int32 FindNOD(Int32 _denum1, Int32 _denum2) {
            if (_denum1 == 0) {
                return _denum2;
            }
            else {
                var min = FindMin(_denum1, _denum2);
                var max = FindMax(_denum1, _denum2);
                //вызываем метод с новыми аргументами
                return FindNOD(max - min, min);
            }
        }
        private static Int32 FindMin(Int32 _number1, Int32 _number2) {
            return _number1 > _number2 ? _number2 : _number1;
        }
        private static Int32 FindMax(Int32 _number1, Int32 _number2) {
            return _number1 > _number2 ? _number1 : _number2;
        }
    }
}
