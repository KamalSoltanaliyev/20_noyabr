using _20_noyabr_sinifdeki;

namespace _20_noyabr_sinifdeki 
{
    public class MyList<T, K> where T : class, IPerson, new() where K : class, IPerson, new()
    {
        private T[] _arr;
        public MyList()
        {
            _arr = new T[0];
        }
        public T this[int index]
        {
            get { return _arr[index]; }
            set { _arr[index] = value; }
        }
        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }
    }
}









//namespace ExampleNamespace
//{
//    public class MyList<T> : IPerson<>
//    {
//        private List<T> myList = new List<T>();  

//                                                      // я добавляю элемент в список
//        public void Add(T item)
//        {
//            myList.Add(item);
//        }

        
//        public IEnumerator<T> GetEnumerator()           // реализирую все это
//        {
//            return myList.GetEnumerator();
//        }
//        IEnumerator IEnumerable.GetEnumerator()          

//        {
//            return myList.GetEnumerator();
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            MyList<int> myList = new MyList<int>();
//            myList.Add(1);
//            myList.Add(2);
//            myList.Add(3);

//            foreach (int item in myList)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}
