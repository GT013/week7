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

            Teacher teacher = new Teacher("Tom", 350f); // ประกาศคลาส Teacher teacher = สร้างวัตถุใหม่ส่งค่าพารามิเตอร์ Tom,350
            Professor prof = new Professor("Jerry", 500f, 5000f); // ประกาศคลาส Professor prof = สร้างวัตถุใหม่ส่งค่าพารามิเตอร์ Jerry,500,5000
                                                                  // teacher work 20Hr/month
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                teacher.CalculateCharge(20f)); // เรียกใช้เมธอดจากคลาส Teacher .TypeName(),.CalculateCharge(20f)(ส่งค่าพารามิเตอร์เท่ากับ 20)
                                               // professor work 12Hr/month
            Console.WriteLine("{0} charge = {1}", prof.TypeName(),
                    prof.CalculateCharge(12F));// เรียกใช้เมธอดจากคลาส Professor มี .TypeName(),.CalculateCharge(12F)(ส่งค่าพารามิเตอร์เท่ากับ 12)
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


    class Professor : Teacher // คลาส Professor สืบทอดจาก Teacher
    {
        private float emolument;  // เงินประจำตำแหน่ง //ไม่สามารถเข้าถึงได้

        public Professor(string name, float billingRate) : base(name, billingRate) //เนื่องจากพ้องรูปกับคลาส Teacher เพิ่ม(name, billingRate)เพื่อเก็บค่าลงฟิลด์
        {
        }

        public Professor(string name, float billingRate, float emolument)// : this(name, billingRate)ใช้การทำงานจากคลาสแม่
        : this(name, billingRate)                                       
        {
            this.emolument = emolument;   // เก็บค่า emolument = 5000 ลงในฟิลด์  private float emolument    
        }

        // new function, because it's different than the base version
        public new float CalculateCharge(float hours) // สร้างวัตถุใหม่เพราะการทำงานไม่เหมือนกับคลาสแม่
        {
            if (hours < 1.0F) // ถ้า hours น้อยกว่า 1.0 
                hours = 1.0F; // minimum charge. // hours = 1.0
            return (hours * billingRate) + emolument;// hours = 12,billingRate = 500 , emolument = 5000 // (12*500)+5000 = 11000
                                                       // ส่งค่า 11000 เมื่อเมธอดถูกเรียกใช้ //ค่าที่นำมาคำนวณได้จากพารามิเตอร์ที่กำหนดไว้ที่ Main
        }
        // new function, because it's different than the base version
        public new string TypeName()// สร้างวัตถุใหม่เพราะการทำงานไม่เหมือนกับคลาสแม่
        {
            return ("Professor"); // ส่งค่าสตริง Professor เมื่อเมธอดถูกเรียกใช้
        }
    }



}


