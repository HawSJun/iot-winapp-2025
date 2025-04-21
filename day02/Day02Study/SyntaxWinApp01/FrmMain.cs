﻿namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        //var int09 = 10; // var는 전역변수 사용 불가

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // 정수 자료형
            sbyte byteVal = 127;    // signed byte : -128 ~ 127 수 저장
            System.SByte sbtVal = System.SByte.MinValue; // -128 할당
            byte btVal = 255;       // byte : 0 ~ 255 수 저장(1 byte)
            System.Byte btVal2 = System.Byte.MinValue; // 0 할당
            short stVal = 32767;    // short : -32768 ~ 32767 수 저장
            System.Int16 stVal2 = System.Int16.MinValue; // -32768 할당
            ushort uStVal = 65535;  // unsigned short : 0 ~ 65535 수 저장(2 bytes)
            System.UInt16 ustVal2 = System.UInt16.MinValue; // 0 할당
            int intVal = 2147483647; // int : -2억 ~ 2억 수 저장(4 bytes 크기)
            System.Int32 intVal2  = System.Int32.MinValue; // -21억 할당
            uint uIntVal = 4294967295; // unsigned int : 0 ~ 42억 수 저장(4 bytes)
            System.UInt32 uintVal2 = System.UInt32.MinValue; // 0 할당
            long lngVal = 9223372036854775807; // long : -9경 ~ 9경 수 저장(8 bytes)
            ulong uLngVal = 18446744073709551615; // unsigned long : 1800경 수 저장(8 bytes)
            System.Int64 longVal02; // (8bytes)
            System.Int128 bigLongVal03; // (16bytes)

            // 실수 자료형
            float fVal = 3.141592f; // float : 4bytes 소수점
            System.Single fVal2 = System.Single.MinValue; // +-1.5e-45 할당
            double dVal = 3.141592; // double : 8bytes 소수점
            System.Double dVal2;
            decimal dcVal = 3.141592m; // decimal : 16bytes 소수점
            System.Decimal dcVal2;

            // 문자형 타입
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World!";     // \0 : end of line
            System.String str02 = "Hello C#";

            // 불린 타입
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            //int int02 = null;   // 기본타입(정수형, 실수형, 불린 / 문자열 제외)은 NULL을 할당 불가
            int? int03 = null;  // 기본타입 뒤에 ? 붙여줄 것

            // 상수 타입
            const int int04 = 15;   // const를 만나면 상수. 한번 할당 후 변경 불가
            //int04 = 26;

            // 동적 타입 // 컴파일 되면서 해당 타입으로 형 결정
            var int05 = false;

            //int05 = "String";

            //MessageBox.Show(uintVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
