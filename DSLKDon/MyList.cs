using System;

namespace DSLKDon
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;
        private int count;
        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public int Count // Property Count
        {
            get { return count; }
        }
        public MyList() //khởi tạo DS rỗng
        {
            first = null; //DS rỗng
            last = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;//nối new node vào đầu DS
                first = newNode;//cập nhạt con trỏ đầu DS
            }
            count++;
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                last.Next = newNode;//nối nó vào đàng sau.
                last = newNode; //cập nhaatl con trỏ sau
            }
            count++;
        }
        public void AddAfterP(IntNode p, IntNode newNode) //Thêm node mới sau p
        {
            newNode.Next = p.Next;
            p.Next = newNode;
            count++;
        }
        public void Input1()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị (nhập số 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return; //kiểu dữ liệu trả về của hàm/phương thức là void
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);

            } while (true);
        }
        public void Input2()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị (nhập số 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return; //kiểu dữ liệu trả về của hàm/phương thức là void
                IntNode newNode = new IntNode(x);
                AddLast(newNode); //???????????????????????????????
            } while (true);
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Mời nhập giá trị (nhập số 0 để kết thúc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return; //kiểu dữ liệu trả về của hàm/phương thức là void
                if (SearchX(x) == null) //nếu không có => không trùng
                {
                    IntNode newNode = new IntNode(x);
                    AddLast(newNode); //???????????????????????????????
                }
                else Console.WriteLine("Bạn nhập trùng mời nhập lại...");
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first; //duyệt từ đầu DS, int i=0;
            while (p != null) //trong khi chưa hết DS while(i<arr.Length)
            {
                Console.Write($"{p.Data} -> ");//Console.Write($"{arr[i]} -> ");
                p = p.Next; //i++; qua phần tử kế
            }
            Console.WriteLine("null");
        }
        public IntNode SearchX(int x) //hàm tồn tại
        {
            IntNode p = first;//duyệt từ đầu DS, int i=0; pointer = con trỏ
            while (p != null) //trong khi chưa hết DS while(i<arr.Length)
            {
                if (p.Data == x) //nếu phần tử đang xét p.Data / arr[i] bằng chính x
                    return p; //return i; trả về con trỏ p
                p = p.Next;//i++; qua phần tử kế
            }
            return null; //return p; p=null => không tìm thấy 
        }
        public IntNode GetMax()
        {
            //b1: gán phần tử đầu tiên là M
            IntNode pM = first;
            //b2: duyệt DS / mảng từ phần tử thứ hai trở về sau
            IntNode p = pM.Next;
            while (p != null) //trong khi chưa hết DS
            {
                //b2.1  Nếu phần tử đang xét mà > M thì
                if (p.Data > pM.Data)
                    //b2.1.1    cập nhật lại M
                    pM = p;
                p = p.Next;//qua phần tử kế, i++;
            }
            //B3: trả về M
            return pM;
        }
        public IntNode GetMin()//?????????????????????????
        {
            //b1: gán phần tử đầu tiên là M
            IntNode pM = first;
            //b2: duyệt DS / mảng từ phần tử thứ hai trở về sau
            IntNode p = pM.Next;
            while (p != null) //trong khi chưa hết DS
            {
                //b2.1  Nếu phần tử đang xét mà < M thì
                if (p.Data < pM.Data) //????????????????????????????????????????????
                    //b2.1.1    cập nhật lại M
                    pM = p;
                p = p.Next;//qua phần tử kế, i++;
            }
            //B3: trả về M
            return pM;
        }
        public MyList GetEvenList()
        {
            MyList myListEven = new MyList();
            IntNode p = first;//duyệt từ đầu DS, int i=0; pointer = con trỏ
            while (p != null) //trong khi chưa hết DS while(i<arr.Length)
            {
                if (p.Data % 2 == 0) //nếu phần tử đang xét p.Data là số chẵn
                {
                    IntNode newNode = new IntNode(p.Data); //tạo 1 đối tượng mới
                    myListEven.AddLast(newNode); //thêm new node vào DS chẵn
                }
                p = p.Next;//i++; qua phần tử kế
            }
            return myListEven;
        }
        public MyList GetOddList()
        {
            MyList myListOdd = new MyList();
            IntNode p = first;//duyệt từ đầu DS, int i=0; pointer = con trỏ
            while (p != null) //trong khi chưa hết DS while(i<arr.Length)
            {
                if (p.Data % 2 != 0) //nếu phần tử đang xét p.Data là số lẻ
                {
                    IntNode newNode = new IntNode(p.Data); //tạo 1 đối tượng mới
                    myListOdd.AddLast(newNode); //thêm new node vào DS chẵn
                }
                p = p.Next;//i++; qua phần tử kế
            }
            return myListOdd;
        }
        public MyList JoinList1(MyList myList2)
        {
            MyList myList3 = new MyList(); //list chứa kết quả trả về
            //duyệt trên myList1
            IntNode p = first; //myList1 => this , đối tượng đang xét này
            while (p != null) //trong khi chưa hết myList1
            {
                IntNode newNode = new IntNode(p.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p = p.Next; //duyệt qua phần tử kế
            }
            //duyệt trên myList2
            p = myList2.first; //myList2 
            while (p != null) //trong khi chưa hết myList2
            {
                IntNode newNode = new IntNode(p.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p = p.Next;//qua phần tử kế
            }
            return myList3;
        }
        public MyList JoinList2(MyList myList2)
        {
            MyList myList3 = new MyList();
            //duyệt trên cả hai myList1, myList2
            IntNode p1 = first; //myList1 => this , đối tượng đang xét này
            IntNode p2 = myList2.first;
            while (p1 != null && p2 != null) //trong khi chưa hết cả hai DS
            {
                IntNode newNode = new IntNode(p1.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p1 = p1.Next; //duyệt qua phần tử kế
                newNode = new IntNode(p2.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p2 = p2.Next; //duyệt qua phần tử kế
            }
            //duyệt trên myList1
            while (p1 != null) //trong khi chưa hết myList1
            {
                IntNode newNode = new IntNode(p1.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p1 = p1.Next;
            }
            //duyệt trên myList2
            while (p2 != null) //trong khi chưa hết myList2
            {
                IntNode newNode = new IntNode(p2.Data); //tạo 1 đối tượng mới
                myList3.AddLast(newNode); //thêm new node vào DS kết quả myList3
                p2 = p2.Next;
            }
            return myList3;
        }

        public MyList MaxSubString()
        {
            MyList maxSubList = new MyList(); //khởi tạo DS rỗng
            MyList currentSubList = new MyList();//khởi tạo DS rỗng
            IntNode p = first; //duyệt từ đầu DS
            while (p != null) //trong khi chưa hết DS
            {
                // Nếu là phần tử đầu tiên (DS rỗng) hoặc lớn hơn phần tử trước đó, thêm vào danh sách hiện tại
                if (currentSubList.IsEmpty() || p.Data > currentSubList.Last.Data)
                    currentSubList.AddLast(new IntNode(p.Data));
                else
                {
                    // Nếu không, kiểm tra xem đoạn hiện tại có đủ dài (>= 2) để so sánh
                    if (currentSubList.Count >= 2 && currentSubList.Count > maxSubList.Count) // Nếu đoạn hiện tại dài hơn đoạn lớn nhất đã tìm thấy 
                        maxSubList = currentSubList; //cập nhật lại đoạn con dài nhất
                    // Reset đoạn hiện tại với phần tử hiện tại
                    currentSubList = new MyList();
                    currentSubList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;//qua phần tử kế
            }
            // Cuối cùng kiểm tra một lần nữa đoạn hiện tại
            if (currentSubList.Count >= 2 && currentSubList.Count > maxSubList.Count)
            {
                maxSubList = currentSubList;
            }
            return maxSubList;
        }
        public void RemoveHead()
        {
            IntNode pDel = first;
            first = first.Next;
            pDel.Next = null;
            pDel = null;
        }
        // 1->2->3->4->5 ->NULL
        public void RemoveLast()
        {
            IntNode pPre = first; //pPre con trỏ đứng trước con trỏ last
            while (pPre.Next != last)
                pPre = pPre.Next;
            last = pPre;
            last.Next = null;
        }

        public void RemoveAny(IntNode pDel)
        {
            IntNode pTM = pDel.Next;
            pDel.Data = pTM.Data;
            pDel.Next = pTM.Next;
            pTM = null;
        }
        public bool RemoveAt(int i)
        {
            if (i < 0 || i >= this.count) return false;
            if (i == 0) RemoveHead();
            else if (i == this.count - 1) RemoveLast();
            else
            {
                IntNode pDel = first;
                for (int j = 0; j < i; j++)
                    pDel = pDel.Next;
                RemoveAny(pDel);
            }
            return true;
        }
        //4)	RemoveX(): Xóa node có giá trị x
        public bool RemoveX(int x)
        {
            if (IsEmpty()) return false;
            if (first.Data == x) RemoveHead();
            else if (last.Data == x) RemoveLast();
            else
            {
                IntNode pDel = SearchX(x);
                RemoveAny(pDel);
            }
            return true;
        }
        //5)	InsertAt(int x, int i) : Chèn x vào danh sách tại vị trí thứ i(thứ tự node được tính bắt đầu từ 0)
        public bool InsertAt(int x, int i)
        {
            if (i < 0 || i >= this.count) return false;
            if (i == 0) AddFirst(new IntNode(x));
            else if (i == this.count - 1) AddLast(new IntNode(x));
            else
            {
                IntNode p = first;
                for (int j = 0; j < i - 1; j++) p = p.Next;
                AddAfterP(p, new IntNode(x));
            }
            return true;
        }
        //6)	InsertXAfterMin(): Chèn x vào sau node có giá trị nhỏ nhất
        public bool InsertXAfterMin(int x)
        {
            if (IsEmpty()) return false;
            IntNode pM = GetMin();
            AddAfterP(pM, new IntNode(x));
            return true;
        }
        public bool InsertXAfterY(int x, int y)
        {
            if (IsEmpty()) return false;
            IntNode p = SearchX(y);
            if (p == null) //không có y thì sao?
                return false;
            AddAfterP(p, new IntNode(x));
            return true;
        }
        public int HoanVi(IntNode x, IntNode y)
        {
            int t = x.Data; x.Data = y.Data; y.Data = t;
            return 0;
        }
        public bool InsertXBeforeMax(int x)
        {
            if (IsEmpty()) return false;
            IntNode pM = GetMax();
            if (pM == first) AddFirst(new IntNode(x));
            else
            {
                IntNode newNode = new IntNode(x);
                AddAfterP(pM, newNode);
                HoanVi(pM, newNode);
            }
            return true;
        }
        public bool ShiftLeft()
        {
            if (IsEmpty()) return false;
            RemoveHead();
            return true;
        }
        public bool RShiftRight()
        {
            if (IsEmpty()) return false;
            int x = last.Data;
            RemoveLast();
            AddFirst(new IntNode(x));
            return true;
        }
        public void InterchangeSort()
        {
            /*for (int i = 0; i < arr.Length - 1; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                        HoanVi(ref arr[i], ref arr[j]);*/
            for (IntNode i = first; i != last; i = i.Next)
                for (IntNode j = i.Next; j != null; j = j.Next)
                    if (i.Data > j.Data)
                        HoanVi(i, j);

        }
        public void SelectionSort()
        {
            /*for (int i = 0; i < arr.Length - 1; i++) //a[i] pt đầu dãy chưa được sắp
            {
                //B1: tìm min trong dãy lộn xộn chưa được sắp
                int vt = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[vt])
                        vt = j;
                //B2: hoán vị min với pt đầu dãy lộn xộn chưa được sắp
                HoanVi(ref arr[vt], ref arr[i]);
            }*/
            for (IntNode i = first; i != last; i = i.Next) //a[i] pt đầu dãy chưa được sắp
            {
                //B1: tìm min trong dãy lộn xộn chưa được sắp
                IntNode vt = i;
                for (IntNode j = i.Next; j != null; j = j.Next)
                    if (j.Data < vt.Data)
                        vt = j;
                //B2: hoán vị min với pt đầu dãy lộn xộn chưa được sắp
                HoanVi(vt, i);
            }
        }
        //14)	MergeList(): Tạo danh sách list3 từ 2 danh sách list1 và list2
        //(list1 và list2 đã được sắp tăng dần) sao cho list3 cũng có thứ tự tăng dần mà không cần phải sắp xếp lại list3. 
        public MyList MergeList(MyList list2)
        {
            MyList list3 = new MyList();
            IntNode p1 = first;
            IntNode p2 = list2.first;
            while (p1 != null && p2 != null)
            {
                if (p1.Data > p2.Data)
                {
                    list3.AddLast(new IntNode(p2.Data));
                    p2 = p2.Next;
                }
                else
                {
                    list3.AddLast(new IntNode(p1.Data));
                    p1 = p1.Next;
                }
            }
            //trong khi chưa hết list1
            while (p1 != null)
            {
                list3.AddLast(new IntNode(p1.Data));
                p1 = p1.Next;
            }
            //trong khi chưa hết list2
            while (p2 != null)
            {
                list3.AddLast(new IntNode(p2.Data));
                p2 = p2.Next;
            }
            return list3;
        }
    }
}

