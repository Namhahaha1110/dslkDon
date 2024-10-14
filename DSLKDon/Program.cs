// See https://aka.ms/new-console-template for more information
using DSLKDon;

static MyList TestInput1()
{
    MyList list1 = new MyList();
    list1.Input1();
    Console.WriteLine("DSLK số nguyên AddFirst:");
    list1.ShowList();
    /**/



    return list1;
}
static void TestInput2()
{
    MyList list1 = TestInput1();
    MyList list2 = new MyList();
    list2.Input2();
    Console.WriteLine("DSLK số nguyên AddLast:");
    list2.ShowList();

}

static void TestInput()
{
    MyList list2 = new MyList();
    list2.Input2();
    Console.WriteLine("DSLK số nguyên thêm cuối:");
    list2.ShowList();
    MyList listKQ = list2.MaxSubString();
    Console.WriteLine("Đoạn DSLK con số nguyên dài nhất:");
    listKQ.ShowList();
    /*list2.RemoveAt(5);
    Console.WriteLine("DSLK số nguyên sau khi xóa:");
    list2.ShowList();
    list2.InsertXBeforeMax(10);
    Console.WriteLine("DSLK số nguyên sau khi thêm trước MAX:");
    list2.ShowList();*/
}


static int Menu()
{
    Console.WriteLine("\t\tMENU");
    Console.WriteLine("1. Thêm một node có giá trị x vào đầu danh sách");
    Console.WriteLine("2. Thêm một node có giá trị x vào cuối danh sách");
    Console.WriteLine("3. Nhập các giá trị vào danh sách (giá trị thêm vào đầu danh sách) ");
    Console.WriteLine("4. Nhập các giá trị vào danh sách (giá trị thêm vào cuối danh sách) ");
    Console.WriteLine("5. Hiển thị giá trị của danh sách ra màn hình");
    Console.WriteLine("6. Tìm và trả về node có giá trị x (nếu có)");
    Console.WriteLine("7. Trả về node có giá trị lớn nhất");
    Console.WriteLine("8. Trả về node có giá trị nhỏ nhất");
    Console.WriteLine("9. Trả về danh sách chỉ chứa số chẵn");
    Console.WriteLine("10. Trả về danh sách chỉ chứa số lẻ");
    Console.WriteLine("11. Tạo danh sách danh sách list2 vào cuối danh sách list1");
    Console.WriteLine("12. Tạo danh sách nối 2 danh sách chứa số chẵn và số lẻ đan xen chẵn lẻ");
    Console.WriteLine("13. Viết lại hàm nhập sao các giá trị của danh sách không được trùng nhau");
    Console.WriteLine("14. Tìm đoạn các phần tử có giá trị tăng dần dài nhất trong danh sách");
    Console.WriteLine("15. Xóa node tại vị trí thứ i (thứ tự node được tính bắt đầu từ 0)");
    Console.WriteLine("16. Xóa node có giá trị x");
    Console.WriteLine("17. Chèn x vào danh sách tại vị trí thứ i");
    Console.WriteLine("18. Chèn x vào sau node có giá trị nhỏ nhất");
    Console.WriteLine("19. Chèn x vào sau node có giá trị y");
    Console.WriteLine("20. Chèn x vào trước node có giá trị lớn nhất");
    Console.WriteLine("21. Chèn x vào trước node có giá trị y");
    Console.WriteLine("22. Trả về danh sách sau khi dịch trái ");
    Console.WriteLine("23. Trả về danh sách sau khi dịch phải xoay vòng");
    Console.WriteLine("24. InterchangeSort");
    Console.WriteLine("25. SelectionSort");
    Console.WriteLine("26. MergeList");
    Console.WriteLine("0. Thoát");
    while (true)
    {
        Console.Write("Mời bạn nhập chức năng (0...26) chọn: ");
        int chon;
        if (int.TryParse(Console.ReadLine(), out chon))
        {
            if (chon >= 0 && chon <= 26) return chon;
            Console.WriteLine("Bạn nhập sai chức năng, mời nhập lại....");
        }
        Console.WriteLine("Bạn phải nhập số nguyên....");
    }
}

static void XuLy(MyList objList, int chon)
{
    MyList myListEven = new MyList(), myListOdd = new MyList();
    switch (chon)
    {
        case 1:
            Console.Write("Mời nhập giá trị x cho node mới: ");
            int x = int.Parse(Console.ReadLine());
            IntNode newNode = new IntNode(x);
            objList.AddFirst(newNode); break;
        case 2:
            Console.Write("Mời nhập giá trị x cho node mới: ");
            x = int.Parse(Console.ReadLine());
            newNode = new IntNode(x);
            objList.AddLast(newNode);
            break;
        case 3:
            objList.Input1();
            break;
        case 4: objList.Input2(); break;
        case 5: objList.ShowList(); break;
        case 6:
            Console.Write("Mời nhập giá trị x cần tìm x: ");
            x = int.Parse(Console.ReadLine());
            IntNode kq = objList.SearchX(x);
            if (kq == null) Console.WriteLine($"Tìm không thấy {x}");
            else Console.WriteLine($"Tìm thấy {x}"); ; break;
        case 7:
            IntNode nodeMax = objList.GetMax();
            Console.WriteLine($"Giá trị lớn nhất {nodeMax.Data}");
            break;
        case 8:
            IntNode nodeMin = objList.GetMin();
            Console.WriteLine($"Giá trị nhỏ nhất {nodeMin.Data}");
            break;
        case 9:
            myListEven = objList.GetEvenList();
            Console.WriteLine("DSLK số nguyên chẵn:");
            myListEven.ShowList();
            break;
        case 10:
            myListOdd = objList.GetOddList();
            Console.WriteLine("DSLK số nguyên lẻ:");
            myListOdd.ShowList();
            break;
        case 11:
            MyList list3 = myListEven.JoinList1(myListOdd);
            Console.WriteLine("DSLK số nguyên sau khi join 1:");
            list3.ShowList();
            break;
        case 12:
            MyList listKq = myListEven.JoinList2(myListOdd);
            Console.WriteLine("DSLK số nguyên sau khi join 2:");
            listKq.ShowList();
            break;
        case 13:
            objList = new MyList();
            objList.Input();
            Console.WriteLine("DSLK số nguyên thêm cuối không trùng:");
            objList.ShowList();
            break;
        case 14: break;
        case 15: break;
        case 16: break;
        case 17: break;
        case 18: break;
        case 19: break;
        case 20: break;
        case 21: break;
        case 22: break;
        case 23: break;
        case 24:
            objList.InterchangeSort();
            Console.WriteLine("DSLK số nguyên sau khi sắp InterchangeSort:");
            objList.ShowList();
            break;
        case 25: break;
        case 26: break;
    }
}

static void Main(string[] args)
{
    //TestInput1();
    //TestInput2();
    MyList objList = new MyList();
    while (true)
    {
        int chon = Menu();
        if (chon == 0) break;
        XuLy(objList, chon);
        Console.WriteLine("***********************");
        Console.Write("Nhấn enter để tiếp tuc...");
        Console.ReadKey();
        Console.WriteLine();
    }
    //TestInput();
}

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Main(args);