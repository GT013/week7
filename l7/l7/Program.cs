using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Tom", 350f); // ประกาศคลาส Teacher teacher = สร้างวัตถุใหม่เพื่อการส่งค่าพารามิเตอร์
            // teacher work for 20Hr/month
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                teacher.CalculateCharge(20f)); // เรียกใช้เมธอดจากคลาส Teacher มี .TypeName() และ 
                                               // .CalculateCharge(20f)(กำหนดค่าพารามิเตอร์เท่ากับ 20) 
            Console.ReadLine();
        }
    }
    class Teacher
    {
        // constructor (for initial private/protected variables)
        public Teacher(string name, float billingRate) // รับค่าพารามิเตอร์ผ่าน name และ billingRate คือ Tom,350f
        {
            this.name = name; // name = Tom
            this.billingRate = billingRate; // billingRate = 350f
        }
        // figure out the charge based on teacher's rate
        public float CalculateCharge(float hours) // สร้างเมธอด CalculateCharge รับค่าพารามิเตอร์ผ่าน hours
        {
            return (hours * billingRate); // hours = 20 , billingRate = 350 // 350*20 = 7000
        }
        // return the name of this type
        public string TypeName() // สร้างเมธอด TypeName เป็นชนิดสตริง
        {
            return ("Teacher"); // ส่งค่าสตริงไปแสดงเมื่อเมธอดถูกเรียกใช้
        }
        private string name; // ข้อมูล name จะไม่ถูกเข้าถึง
        protected float billingRate; // เมธอดลูกสามารถเข้าถึงได้
    }


}


