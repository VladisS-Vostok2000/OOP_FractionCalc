using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FractionCalc.UpMatch;

namespace FractionCalc {
    public struct Fraction {
        public Int32 Numerator { private set; get; }
        public Int32 Denumenator { private set; get; }


        public Fraction(Int32 _numerator, Int32 _denumerator) {
            Numerator = _numerator;
            Denumenator = _denumerator;
        }


        public Fraction Sum(Fraction _fract2) {
            (Fraction _newFract1, Fraction _newFract2) = BringFractionsToComonDenumenator(this, _fract2);
            return new Fraction(_newFract1.Numerator + _newFract2.Numerator, _newFract1.Denumenator);
        }
        public Fraction Substact(Fraction _fract2) {
            (Fraction _newFract1, Fraction _newFract2) = BringFractionsToComonDenumenator(this, _fract2);
            return new Fraction(_newFract1.Numerator - _newFract2.Numerator, _newFract1.Denumenator);
        }
        public Fraction Multiply(Fraction _fract2) {
            return new Fraction(this.Numerator * _fract2.Numerator, this.Denumenator * _fract2.Denumenator);
        }
        public Fraction Divide(Fraction _fract2) {
            return new Fraction(this.Numerator * _fract2.Denumenator, this.Denumenator * _fract2.Numerator);
        }
        private (Fraction, Fraction) BringFractionsToComonDenumenator(Fraction _fract1, Fraction _fract2) {
            Int32 NOK = FindNOK(_fract1.Denumenator, _fract2.Denumenator);
            return (
                new Fraction(_fract1.Numerator * NOK / _fract1.Denumenator, _fract1.Denumenator * NOK / _fract1.Denumenator),
                new Fraction(_fract2.Numerator * NOK / _fract2.Denumenator, _fract2.Denumenator * NOK / _fract2.Denumenator)
                );
        }


        public void Reduse() {
            Int32 NOD = FindNOD(Numerator, Denumenator);
            Numerator /= NOD;
            Denumenator /= NOD;
        }
    }
}
