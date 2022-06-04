using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public static String firstNum = "";         // 첫번째 숫자
        public static String SecondNum = "";        // 두번째 숫자
        public static double Result = 0;               // 결과값
        public static bool logicBool = false;       // 연산기호 누렀는지 확인
        public static int logicSymbol = 0;          // 연산기호 구별(1:더하기, 2:빼기, 3:곱하기, 4:나누기)


        public Form1()
        {
            InitializeComponent();
            firstNum += "0";
            SecondNum += "0";
            label1.Text += "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)                    // 숫자 0버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")                    // 첫번째 숫자가 0일때(숫자를 입력하지 않은 경우)
            {

            }
            else if (SecondNum == "0")              // 두번째 숫자가 0일때(숫자를 입력하지 않은 경우)
            {

            }
            else
            {
                if (logicBool == false)                             // 연산기호를 누르기 전
                {
                    firstNum += "0";               // 두번째 숫자에 0을 입력
                    label1.Text = firstNum;         // 첫번째 숫자를 입력
                }
                else                                                // 연산기호를 눌렀을 때
                {
                    SecondNum += "0";               // 두번째 숫자에 0을 입력
                    label1.Text = SecondNum;        // 두번째 숫자를 입력
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)                     // 숫자 1버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            SetStyle(ControlStyles.Selectable, false);
            if (firstNum == "0")
            {
                firstNum = "1";
                label1.Text = firstNum;
            }
            else if(logicBool==true && SecondNum == "0")
            {
                SecondNum = "1";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "1";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "1";
                    label1.Text = SecondNum;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)                     // 숫자 2버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "2";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "2";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "2";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "2";
                    label1.Text = SecondNum;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)                     // 숫자 3버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "3";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "3";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "3";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "3";
                    label1.Text = SecondNum;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)                     // 숫자 4버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "4";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "4";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "4";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "4";
                    label1.Text = SecondNum;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)                     // 숫자 5버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "5";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "5";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "5";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "5";
                    label1.Text = SecondNum;
                }
            }
        }

        private void btn6_Click(object sender, EventArgs e)                        // 숫자 6버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "6";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "6";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "6";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "6";
                    label1.Text = SecondNum;
                }
            }
        }

        private void btn7_Click(object sender, EventArgs e)                        // 숫자 7버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "7";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "7";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "7";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "7";
                    label1.Text = SecondNum;
                }
            }
        }

        private void btn8_Click(object sender, EventArgs e)                        // 숫자 8버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "8";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "8";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "8";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "8";
                    label1.Text = SecondNum;
                }
            }
        }

        private void btn9_Click(object sender, EventArgs e)                        // 숫자 9버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "0")
            {
                firstNum = "9";
                label1.Text = firstNum;
            }
            else if (logicBool == true && SecondNum == "0")
            {
                SecondNum = "9";
                label1.Text = SecondNum;
            }
            else
            {
                if (logicBool == false)
                {
                    firstNum += "9";
                    label1.Text = firstNum;
                }
                else
                {
                    SecondNum += "9";
                    label1.Text = SecondNum;
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)                      // 더하기 버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "")
            {
                firstNum = "0";
            }
            else if (firstNum == "")
            {
                SecondNum = "0";
            }
            logicSymbol = 1;                                // 연산기호 부여
            logicBool = true;                               // 연산기호를 눌렀을 다는 것을 구분
            SecondNum = "";                                 // 기존에 사용했던 두번째 숫자를 초기화
            label2.Text = firstNum + "+";                   // 임시식에 첫번째 숫자와 기호 입력


        }

        private void btnSub_Click(object sender, EventArgs e)                      // 빼기 버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "")
            {
                firstNum = "0";
            }
            else if (firstNum == "")
            {
                SecondNum = "0";
            }
            logicSymbol = 2;
            logicBool = true;
            SecondNum = "";
            label2.Text = firstNum + "-";

        }

        private void btnMul_Click(object sender, EventArgs e)                      // 곱하기 버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "")
            {
                firstNum = "0";
            }
            else if (firstNum == "")
            {
                SecondNum = "0";
            }
            logicSymbol = 3;
            logicBool = true;
            SecondNum = "";
            label2.Text = firstNum + "×";

        }

        private void btnDiv_Click(object sender, EventArgs e)                      // 나누기 버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "")
            {
                firstNum = "0";
            }
            else if (firstNum == "")
            {
                SecondNum = "0";
            }
            logicSymbol = 4;
            logicBool = true;
            SecondNum = "";
            label2.Text = firstNum + "÷";

        }

        private void btnResult_Click(object sender, EventArgs e)                   // 결과버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            if (firstNum == "")
            {
                firstNum = "0";
            }
            if (SecondNum == "")
            {
                SecondNum = "0";
            }
            double intfirstNum = Convert.ToDouble(firstNum);                        // String첫번쨰 숫자를 .int첫번째 숫자로 변경
            double intsecondNum = Convert.ToDouble(SecondNum);                      // String두번쨰 숫자를 .int두번째 숫자로 변경


            if (logicSymbol == 1)                                               // 더하기 계산
            {
                Result = intfirstNum + intsecondNum;                        // 결과값 계산
                String stringresult = Convert.ToString(Result);             // 결과값을 String으로 변경
                label1.Text = stringresult;                                 // 결과값을 출력
                firstNum = stringresult;                                    // 다음계산을 위해 계산결과값을 첫번째 숫자로 입력
                label2.Text = intfirstNum + "+" + intsecondNum;             // 임시식에 최종식을 입력
            }
            if(logicSymbol == 2)                                               // 빼기 계산
            {
                Result = intfirstNum - intsecondNum;
                String stringresult = Convert.ToString(Result);
                label1.Text = stringresult;
                firstNum = stringresult;
                label2.Text = intfirstNum + "-" + intsecondNum;
            }
            if (logicSymbol == 3)                                               // 곱하기 계산
            {
                Result = intfirstNum * intsecondNum;
                String stringresult = Convert.ToString(Result);
                label1.Text = stringresult;
                firstNum = stringresult;
                label2.Text = intfirstNum + "×" + intsecondNum;
            }
            if (logicSymbol == 4)                                               // 나누기 계산
            {
                Result = intfirstNum / intsecondNum;
                String stringresult = Convert.ToString(Result);
                label1.Text = stringresult;
                firstNum = stringresult;
                label2.Text = intfirstNum + "÷" + intsecondNum;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)                    // 리셋버튼을 눌렀을 때
        {
            this.ActiveControl = label1;
            firstNum = "0";
            SecondNum = "0";
            Result = 0;
            logicBool = false;
            logicSymbol = 0;
            label1.Text = "0";
            label2.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)                // BackSpace키를 눌렀을 때
        {
            if (logicBool == false)                             // 연산기호를 누르기 전
            {
                if (firstNum.ToString().Length <= 0)
                {
                    // 첫번째 숫자가 없을 경우
                }
                else
                {
                    firstNum = firstNum.Substring(0, firstNum.ToString().Length - 1);                // 첫번째 숫자에 0을 입력
                    label1.Text = firstNum;         // 첫번째 숫자를 입력
                }
            }
            else                                                // 연산기호를 눌렀을 때
            {
                if (firstNum.ToString().Length <= 0)
                {
                    // 두번째 숫자가 없을 경우
                }
                else
                {
                    SecondNum = SecondNum.Substring(0, SecondNum.ToString().Length - 1);               // 두번째 숫자에 0을 입력
                    label1.Text = SecondNum;        // 두번째 숫자를 입력
                }
            }
        }



        private void Key_Down(object sender, KeyEventArgs e)
        {
            // 숫자 키다운 이벤트
            if (e.KeyCode == Keys.NumPad0|| e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4
                ||e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                if (e.KeyCode == Keys.NumPad0 && firstNum == "0" && SecondNum == "0")
                {

                }
                else
                {
                    if (firstNum == "0")
                    {
                        firstNum = "";
                    }
                    else if (SecondNum == "0")
                    {
                        SecondNum = "";
                    }

                    if (logicBool == false)
                    {
                        firstNum += e.KeyData.ToString().Substring(e.KeyData.ToString().Length - 1);
                        label1.Text = firstNum;
                    }
                    else
                    {
                        SecondNum += e.KeyData.ToString().Substring(e.KeyData.ToString().Length - 1);
                        label1.Text = SecondNum;
                    }
                }
            }

            // 초기화 키다운 이벤트(버튼 R)
            else if (e.KeyCode == Keys.R)
            {
                btnReset_Click(sender, e);
            }

            // BackSpace키 키다운
            else if (e.KeyCode == Keys.Back)
            {
                btnBackspace_Click(sender, e);
            }


            // 엔터키 키다운 이벤트
            else if(e.KeyCode == Keys.Enter)
            {
                btnResult_Click(sender, e);
            }

            // 더하기키 키다운 이벤트
            else if (e.KeyCode == Keys.Add)
            {
                btnSum_Click(sender, e);
            }

            // 빼기키 키다운 이벤트
            else if (e.KeyCode == Keys.Subtract)
            {
                btnSub_Click(sender, e);
            }

            // 곱하기 키다운 이벤트
            else if (e.KeyCode == Keys.Multiply)
            {
                btnMul_Click(sender, e);
            }

            // 나누기키 키다운 이벤트
            else if (e.KeyCode == Keys.Divide)
            {
                btnDiv_Click(sender, e);
            }

            // "."(dot)키 키다운 이벤트
            else if (e.KeyCode == Keys.Decimal)
            {
                if (logicBool == false)                             // 연산기호를 누르기 전
                {
                    if (firstNum.ToString().Length <= 0)
                    {
                        // 첫번째 숫자가 없을 경우
                    }
                    else
                    {
                        firstNum = firstNum + ".";                // 첫번째 숫자에 0을 입력
                        label1.Text = firstNum;                   // 첫번째 숫자를 입력
                    }
                }
                else                                                // 연산기호를 눌렀을 때
                {
                    if (firstNum.ToString().Length <= 0)
                    {
                        // 두번째 숫자가 없을 경우
                    }
                    else
                    {
                        SecondNum = SecondNum + ".";               // 두번째 숫자에 0을 입력
                        label1.Text = SecondNum;        // 두번째 숫자를 입력
                    }
                }
            }





        }                   // 키다운 이벤트
    }
}

