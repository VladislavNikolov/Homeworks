namespace C.GenericList
{
    using System;
    using System.Linq;
    using System.Text;
    using D.GenericListVersion;

    [Version(1, 5)]
    class GenericList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] array;
        private int size;
        private int capacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Size = 0;
            this.Capacity = capacity;
            this.Array = new T[this.Capacity];
        }

        public T[] Array
        {
            get
            {
                return this.array;
            }

            protected set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("Inner", "array array can not be null!");
                }

                this.array = value;
            }
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("GenericList size can not be negative!");
                }

                this.size = value;

                if (value >= this.Capacity)
                {
                    this.DoubleSize();
                }
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("GenericList size can not be negative!");
                }

                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                return this.Array[index];
            }

            set
            {
                if (index >= this.Size || index < 0)
                {
                    throw new IndexOutOfRangeException("The required index is invalid!");
                }

                this.Array[index] = value;
            }
        }

        public void Add(T element)
        {
            this.Array[this.Size] = element;
            this.Size++;
        }

        public void Insert(T element, int position)
        {
            T[] newArr = new T[this.Capacity];

            System.Array.Copy(this.Array, newArr, position);
            System.Array.Copy(new T[1] { element }, 0, newArr, position, 1);
            System.Array.Copy(this.Array, position, newArr, position + 1, this.Array.Length - position - 2);

            this.Array = newArr;
            this.Size++;
        }

        public void Remove(int position)
        {
            T[] newArr = new T[this.Capacity];

            System.Array.Copy(this.Array, newArr, position);
            System.Array.Copy(this.Array, position + 1, newArr, position, this.Array.Length - position - 1);

            this.Array = newArr;
            this.Size--;
        }

        public void Clear()
        {
            this.Array = new T[DefaultCapacity];
            for (int i = 0; i < this.Array.Length; i++)
            {
                this.Array[i] = default(T);
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T element)
        {
            return this.Array.Contains(element);
        }

        public T Min<B>()
        {
            return this.Array.Min();
        }

        public T Max<B>()
        {
            return this.Array.Max();
        }

        public override string ToString()
        {
            StringBuilder elementsSB = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                elementsSB.Append(this.Array[i]);

                if (i != this.Size - 1)
                {
                    elementsSB.Append(", ");
                }
            }

            return elementsSB.ToString();
        }

        private void DoubleSize()
        {
            this.Capacity *= 2;
            T[] newArr = new T[this.Capacity];

            for (int i = 0; i < this.Size; i++)
            {
                newArr[i] = this.Array[i];
            }

            this.Array = newArr;
        }
    }
}
