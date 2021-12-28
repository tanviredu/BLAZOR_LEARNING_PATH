namespace GenericClass.SimpleStack
{
    public class SimpleStackString{
        private string[] _items;
        private int _currentIndex = -1;
        public int Count => _currentIndex+1;

        public SimpleStackString()
        {
            _items = new String[10];
            
        }

        public void Push(String item){
            _items[++_currentIndex] = item;
        }

        public string Pop(){
            return _items[_currentIndex--];
        }
    }

    public class SimpleStackGeneric<T>
    {
        private T[] _items;
        private int _currentIndex = -1;
        public int Count =>_currentIndex+1;
        public SimpleStackGeneric()
        {
            _items = new T[10];
        }
        public void Push(T item){
            _items[++_currentIndex] = item;
        }
        public T Pop(){
            return _items[_currentIndex --];
        }
       
    }
}