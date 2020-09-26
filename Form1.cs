using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalc {
    public partial class Form1 : Form {
        private enum Operation {
            Add,
            Substract,
            Multiply,
            Divide,
        }


        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(Object sender, EventArgs e) {
            MainFormCmbbxOperation.SelectedIndex = 0;
        }


        private void MainFormBttnEquality_Click(Object sender, EventArgs e) {
            Boolean isOk = CheckInput();
            if (!isOk) {
                SystemSounds.Beep.Play();
                return;
            }

            var fract1 = new Fraction(Int32.Parse(MainFormTxtbxNumerator1.Text), Int32.Parse(MainFormTxtbxDenumerator1.Text));
            var fract2 = new Fraction(Int32.Parse(MainFormTxtbxNumerator2.Text), Int32.Parse(MainFormTxtbxDenumerator2.Text));

            GetCurrentOperation(out Operation currOperation1);
            Fraction result = currOperation1 switch
            {
                Operation.Add => fract1.Sum(fract2),
                Operation.Substract => fract1.Substact(fract2),
                Operation.Multiply => fract1.Multiply(fract2),
                Operation.Divide => fract1.Divide(fract2),
                _ => throw new Exception(),
            };

            result.Reduse();

            MainFromTxtbxNumerator3.Text = result.Numerator.ToString();
            MainFormTxtbxDenumerator3.Text = result.Denumenator.ToString();
        }
        private void GetCurrentOperation(out Operation operation) {
            operation = MainFormCmbbxOperation.Text switch
            {
                "+" => Operation.Add,
                "-" => Operation.Substract,
                "*" => Operation.Multiply,
                "/" => Operation.Divide,
                _ => throw new Exception(),
            };
        }
        private Boolean CheckInput() {
            if (Int32.TryParse(MainFormTxtbxNumerator1.Text, out Int32 dummy) &&
                Int32.TryParse(MainFormTxtbxNumerator2.Text, out dummy) &&
                Int32.TryParse(MainFormTxtbxDenumerator1.Text, out dummy) &&
                Int32.TryParse(MainFormTxtbxDenumerator2.Text, out dummy)
                ) {
                return true;
            }
            return false;
        }


        private void TextInput_Changed(Object sender, EventArgs e) {
            MainFormTxtbxDenumerator3.Text = "";
            MainFromTxtbxNumerator3.Text = "";
        }
    }
}
