// See https://aka.ms/new-console-template for more information
using DSLKDon;
using System.Collections.Generic;

static void TextInput()
{
    MyList list = new MyList();
    list.Input();
    Console.WriteLine("DSLK số nguyên: ");
    list.ShowList();
   
  
    int x = int.Parse(Console.ReadLine());
    IntNode kq = list.SearchX(x);
    if (kq == null)
        Console.WriteLine($"Tìm không thấy {x}");
    else
        Console.WriteLine($"Tìm thấy {x}");
}
static MyList TestInput1()
{
    MyList list1=new MyList();
    list1.Input1();
    Console.Write("DSLK số nguyên AddFrist: ");
    list1.ShowList();
    return list1;
}
static void TestInput2()
{
    MyList list1=TestInput1();
    MyList list2 = new MyList();
    list2.Input2();
}
static int Menu()
{
    Console.WriteLine("/t/MENU");
    Console.WriteLine("1. Thêm một node có giá trị x vào đầu danh sách");
    Console.WriteLine("2. Thêm một node có giá trị x vào cuối danh sách");
    Console.WriteLine("3. Nhập các giá trị thêm vào đầu danh sách");
    Console.WriteLine("4. Nhập các giá trị thêm vào cuối danh sách");
    Console.WriteLine("5. Hiển thị giá trị của danh sách ra màn hình");
    Console.WriteLine("6. Tìm và trả về node có giá trị x (nếu có)");
    Console.WriteLine("7. Trả về node có giá trị lớn nhất");
    Console.WriteLine("8. Trả về node có giá trị nhỏ nhất");
    Console.WriteLine("9. Trả về danh sách chỉ chứa số chẵn");
    Console.WriteLine("10. Trả về danh sách chỉ chứa số lẻ");
    Console.WriteLine("11. Tạo danh sách list2 vào cuối danh sách list1");
    Console.WriteLine("12. Tạo danh sách nối 2 danh sách chứa số chẵn và số lẻ đan xen");
    Console.WriteLine("0. Thoát");
    while (true)
    {
        Console.Write("Mời bạn nhập chức năng (1 - 12): ");
        int chon;
        if (int.TryParse(Console.ReadLine(), out chon){
            if(chon>=0&&chon<=12) return chon;
            Console.WriteLine("Bạn nhập sai, mời nhập lại");
        }
        Console.WriteLine("Bạn phải nhập số nguyên");
    }
}
static void XuLy(MyList objList, int chon)
{
    MyList evenList=new MyList(), oddList=new MyList();
    switch (chon)
    {
        case 1: Console.Write("Mời nhập giá trị x cho node mới: ");
            int x=int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            objList.AddFirst(newNode);
            break;
        case 2: Console.Write("Mời nhập giá trị x cho node mới: ");
            x = int.Parse(Console.ReadLine());
           newNode=new IntNode(x);
            objList.AddLast(newNode);
            break ;
        case 3: objList.Input1();
            break;
        case 4: objList.Input2();
            break;
        case 5: objList.ShowList();
            break;
        case 6: Console.Write("Mời nhập giá trị x cần tìm: ");
            x=int.Parse(Console.ReadLine());
            IntNode kq = objList.SearchX(x);
            if (kq == null)
            {
                Console.WriteLine($"Tìm không thấy {x}");
            }
            else Console.WriteLine($"Tìm thấy {x}");
            break;
        case 7:
            IntNode maxNode = objList.GetMax();
            Console.WriteLine($"Giá trị lớn nhất trong danh sách là {maxNode.Data}");
            break;
        case 8:
            IntNode minNode = objList.GetMin();
            Console.WriteLine($"Giá trị nhỏ nhất trong danh sách là {minNode.Data}");
            break;
        case 9:
            MyList evenlist = objList.GetEvenList();
            Console.WriteLine("Danh sách số chẵn: ");
            evenlist.ShowList();
            break ;
        case 10:
            MyList oddlist = objList.GetOddList();
            Console.WriteLine("Danh sách số lẻ: ");
            oddlist.ShowList();
            break;
        case 11: MyList list3=evenList.JoinList1(oddList);
            Console.WriteLine("DSLK số nguyên sau khi Join1: ");
            list3.ShowList();
            break;
        case 12:
            MyList listKq = evenList.JoinList1(oddList);
            Console.WriteLine("DSLK số nguyên sau khi Join2: ");
            listKq.ShowList();
            break;

    }
}

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
static void
TextInput();