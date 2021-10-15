using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comment
            
            // ctrl k + c -- comment
            // ctrl k + u -- uncomment
            
            // 1.Biến và kiểu dữ liệu
            
                // string a = "Xin chao mn"; // kiểu dữ liệu string
                // int b = 1; // integer kiểu dữ liệu số nguyên
                // double c = 1.23;
                // float d = 1.23f;
                // decimal e = 1.23m;
                // char f = 's';
                // bool g = true;
            
            // 2.Xuất dữ liệu ra màn hình Console

                // Console.WriteLine("Hello world 1");
                // Console.WriteLine();
                // Console.WriteLine("Hello world 2");
            
            // ==> Console.Write(value) // in ra ko xuống dòng
            // ==> Console.Writeline(value) // in ra có xuống dòng

                // Console.ForegroundColor = ConsoleColor.Red; // Đặt màu chữ
                // Console.WriteLine("Hello world các bạn");
                // Console.ResetColor(); // reset màu
                // Console.WriteLine("Hello world các bạn 2");

                // double pi = 3.1415;
                // Console.Write("Giá trí biến pi là:");
                // Console.WriteLine(pi);

                //int a = 123;
                //double b = 567.789;

                //Console.WriteLine("Biến a = {0}, Biến b = {1}", a, b);
                    //Biến a = 123, Biến b = 567.789

                //Console.WriteLine($"Biến a = {b}, Biến b = {a}");
                
            // 3. Nhập dữ liệu vào

                //Console.ReadLine(); // đọc dữ liệu vào // luôn luôn trả về kiểu string 
             
   
                // int Userlogin;
                // Console.WriteLine("Nhap Username: ");
                // Userlogin = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine($"Ten nhap vao: {Userlogin}");
                
            // 4. Khai báo biến dữ liệu ngầm đinh

                // int c;
                // c = 1;
                //
                // var d = 1; // biến dữ liệu ngầm định

            // 5. Hằng số trong c#
                 //const string Mon = "Thu hai"; // hằng số là không có thể thay thế được
                 //Console.WriteLine(Mon);

            // + Cộng
            // - trừ
            // * nhân
            // / lấy phần nguyên của phép chia
            // % lấy phần dư của phép chia
            
                // int a = 3;
                // int b = 2;
                // Console.WriteLine(a/(float)b); // 1,5 // ép kiểu 
                // Console.WriteLine(a/b); // 1 lấy phần nguyên 
                // Console.WriteLine(a%b); // 1 lấy số dư

                // int a = 1; 
                // a = a + 10; // a= 1+ 10;
                // a += 10; // a = 11 + 10; (a+=value) == (a = a+ value)
                // a -= 10;// a = 21 - 10;
                // a *= 100;// a = 11 * 100;
                //
                // Console.WriteLine(a);

                // int a = 10;
                // a++; // a++ == a+=1 // 11
                // ++a; // 12 
                // a--; // 11
                // --a; // 10 
                // Console.WriteLine(a);


                // int a = 5; 
                // int b = 2 * a--;  // b = 10; a = 4
                //
                // int c = 5;
                // int d = 2 * --c; // d = 8; c = 4
                
            // so sanh 
            // so sang bang ==
            // lon hon > 
            // lớn hơn bằng >=
            // nhỏ hơn <
            // nhỏ hơn bằng <= 
            // khác != 
                
           
            
            //if (Điểu kiên){} else
            
            // viết phần mềm đăng nhập useraname password

            Console.WriteLine("Input Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Input Password: ");
            int password = Convert.ToInt32(Console.ReadLine());

            if (username == "nmtri")
            {
                if (password == 123456)
                {
                    Console.WriteLine("Login successfully!!!");
                }
                else
                {
                    Console.WriteLine("Login fail!!!");
                }
            }
            else
            {
                Console.WriteLine("Login fail!!!");
            }
            
            // Bài tập: 1/ viết lại lại toàn bộ kiến thức trên
            //          2/ Viết phần mềm nhập vào tên, tuổi kiểm tra nếu trên 18 tên bắt dầu đầu bằng chữ "Tên các bạn" thì cho phép vào còn lại thì ko  
        }
    }
}