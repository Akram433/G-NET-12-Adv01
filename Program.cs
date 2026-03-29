using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //generics means that we can use any data type in our code without specifying it
            // we use generics to create reusable code that can work with any data type, and to improve performance by avoiding boxing and unboxing of value types.
            #endregion
            #region Q2
            //    public class Container<T>


            //   private List<T> _items = new List<T>();

            //public void Add(T item)
            //{
            //    _items.Add(item);
            //}

            //public T Get(int index)
            //{
            //    if (index < 0 || index >= _items.Count)
            //        throw new IndexOutOfRangeException($"Index {index} is out of range.");
            //    return _items[index];
            //}

            //public int Count => _items.Count;


            //// Usage:
            //var intContainer = new Container<int>();
            //intContainer.Add(10);
            //        intContainer.Add(20);
            //       Console.WriteLine(intContainer.Get(0)); 

            //        var strContainer = new Container<string>();
            //       strContainer.Add("Hello");
            //       Console.WriteLine(strContainer.Get(0)); 




            #endregion
            #region Q3
            //Multiple type parameters allow a generic class or method to accept more than one type placeholder. Each parameter is independent and can be constrained separately.
            //            public class Pair<TKey, TValue>
            //        {
            //            public TKey Key { get; }
            //            public TValue Value { get; }

            //            public Pair(TKey key, TValue value)
            //            {
            //                Key = key;
            //                Value = value;
            //            }

            //            public override string ToString()
            //                => $"Key: {Key}, Value: {Value}";
            //        }

            //       
            //        var pair = new Pair<string, int>("Age", 30);
            //        Console.WriteLine(pair);          

            //var pair2 = new Pair<int, bool>(1, true);
            //        Console.WriteLine(pair2.Key);    
            //Console.WriteLine(pair2.Value);   

            #endregion
            #region Q4
            //a generic method is a method that has its own type parameter
            //            public class Utilities
            //        {
            //            public static void Swap<T>(ref T a, ref T b)
            //            {
            //                T temp = a;
            //                a = b;
            //                b = temp;
            //            }
            //        }

            //        
            //        int x = 5, y = 10;
            //        Utilities.Swap(ref x, ref y);
            //Console.WriteLine($"x={x}, y={y}");  

            //string s1 = "Hello", s2 = "World";
            //        Utilities.Swap(ref s1, ref s2);
            //Console.WriteLine($"{s1} {s2}");      



            #endregion
            #region Q5
            //public static T FindMax<T>(T[] array) where T : IComparable<T>
            //{
            //    if (array == null || array.Length == 0)
            //        throw new ArgumentException("Array cannot be null or empty.");

            //    T max = array[0];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        if (array[i].CompareTo(max) > 0)
            //            max = array[i];
            //    }
            //    return max;
            //}


            //int[] nums = { 3, 1, 7, 4, 9, 2 };
            //Console.WriteLine(FindMax(nums));        

            //string[] words = { "banana", "apple", "cherry" };
            //Console.WriteLine(FindMax(words));        


            #endregion
            #region Q6
            //A generic interface defines a contract with type parameters
            //    public interface IRepository<T>
            //{
            //    void Add(T item);
            //    T GetById(int id);
            //    IEnumerable<T> GetAll();
            //    void Delete(int id);
            //}


            //public class User { public int Id { get; set; } public string Name { get; set; } }

            //public class UserRepository : IRepository<User>
            //{
            //    private List<User> _users = new List<User>();

            //    public void Add(User item) => _users.Add(item);

            //    public User GetById(int id)
            //        => _users.FirstOrDefault(u => u.Id == id);

            //    public IEnumerable<User> GetAll() => _users;

            //    public void Delete(int id) => _users.RemoveAll(u => u.Id == id);


            #endregion
            #region Q7
            //The struct constraint restricts T to value types only
            //            public class ValueWrapper<T> where T : struct
            //        {
            //            public T Value { get; private set; }

            //            public ValueWrapper(T value) => Value = value;

            //            public T? AsNullable() => Value;  // Works because T is a struct

            //            public override string ToString() => $"Wrapped({Value})";
            //        }


            //        var intWrapper = new ValueWrapper<int>(42);
            //        Console.WriteLine(intWrapper);             

            //var dateWrapper = new ValueWrapper<DateTime>(DateTime.Now);
            //        Console.WriteLine(dateWrapper.AsNullable().HasValue); 



            #endregion
            #region Q8
            //The class constraint restricts T to reference types only
            //            public class NullSafeProcessor<T> where T : class
            //        {
            //            private T _item;

            //            public NullSafeProcessor(T item) => _item = item;

            //            public bool IsNull() => _item == null;

            //            public string Describe()
            //                => _item != null ? _item.ToString() : "(null)";
            //        }


            //        var p1 = new NullSafeProcessor<string>("Hello");
            //        Console.WriteLine(p1.IsNull());   
            //Console.WriteLine(p1.Describe()); 

            //var p2 = new NullSafeProcessor<string>(null);
            //        Console.WriteLine(p2.IsNull());    
            //Console.WriteLine(p2.Describe()); 


            #endregion
            #region Q9
            //The new() constraint requires that T has a public parameterless constructor
            //            public class Factory<T> where T : new()
            //        {
            //            public T Create()
            //            {
            //                return new T();  // Possible only because of new() constraint
            //            }

            //            public List<T> CreateMany(int count)
            //            {
            //                var list = new List<T>();
            //                for (int i = 0; i < count; i++)
            //                    list.Add(new T());
            //                return list;
            //            }
            //        }

            //        public class Product { public string Name { get; set; } = "Default"; }

            //        var factory = new Factory<Product>();
            //        Product p = factory.Create();
            //        Console.WriteLine(p.Name);                

            //var products = factory.CreateMany(3);
            //        Console.WriteLine(products.Count);        


            #endregion
            #region Q10
            //An interface constraint requires that T implements the specified interface
            //            public interface IPrintable
            //        {
            //            void Print();
            //        }

            //        public class Printer<T> where T : IPrintable
            //        {
            //            public void PrintAll(IEnumerable<T> items)
            //            {
            //                foreach (var item in items)
            //                    item.Print();  
            //            }
            //        }

            //        public class Invoice : IPrintable
            //        {
            //            public int Number { get; set; }
            //            public void Print() => Console.WriteLine($"Invoice #{Number}");
            //        }


            //        var printer = new Printer<Invoice>();
            //        var invoices = new List<Invoice>
            //{
            //    new Invoice { Number = 101 },
            //    new Invoice { Number = 102 }
            //};
            //        printer.PrintAll(invoices);  


            #endregion
            #region Q11
            //A base class constraint restricts T to a specific class or any class that derives from it
            //            public abstract class Animal
            //        {
            //            public string Name { get; set; }
            //            public abstract string MakeSound();
            //        }

            //        public class AnimalShelter<T> where T : Animal
            //        {
            //            private List<T> _animals = new List<T>();

            //            public void Admit(T animal) => _animals.Add(animal);

            //            public void AllSpeak()
            //            {
            //                foreach (var a in _animals)
            //                    Console.WriteLine($"{a.Name} says: {a.MakeSound()}");
            //            }
            //        }

            //        public class Dog : Animal { public override string MakeSound() => "Woof!"; }
            //        public class Cat : Animal { public override string MakeSound() => "Meow!"; }

            //        var dogShelter = new AnimalShelter<Dog>();
            //        dogShelter.Admit(new Dog { Name = "Rex" });
            //dogShelter.AllSpeak();  


            #endregion
            #region Q12
            //Multiple constraints are combined with commas after the where T : clause. new() must always be last
            //    public interface IEntity
            //{
            //    int Id { get; set; }
            //    bool IsValid();
            //}

            //public abstract class BaseRecord
            //{
            //    public DateTime CreatedAt { get; set; } = DateTime.Now;
            //}


            //public class DataService<T> where T : BaseRecord, IEntity, new()
            //{
            //    private List<T> _store = new List<T>();

            //    public void Save(T item)
            //    {
            //        if (!item.IsValid())
            //            throw new InvalidOperationException("Entity is invalid.");
            //        _store.Add(item);
            //    }

            //    public T CreateNew() => new T();
            //}

            //public class Order : BaseRecord, IEntity
            //{
            //    public int Id { get; set; }
            //    public decimal Total { get; set; }
            //    public bool IsValid() => Total > 0;
            //}


            #endregion
            #region Q13
            //The 'default' keyword returns the default value for a type parameter T at runtime. For reference types (class), it returns null. For value types (struct),

            #endregion
            #region Q14
            //            public class SafeList<T>
            //        {
            //            private readonly List<T> _items = new List<T>();

            //            public void Add(T item) => _items.Add(item);

            //            public T Get(int index)
            //            {
            //                if (index < 0 || index >= _items.Count)
            //                    return default(T);  
            //                return _items[index];
            //            }

            //            public T this[int index] => Get(index);  

            //            public int Count => _items.Count;
            //        }

            //        var list = new SafeList<string>();
            //        list.Add("Alpha");
            //list.Add("Beta");

            //Console.WriteLine(list.Get(0));   
            //Console.WriteLine(list.Get(1));   
            //Console.WriteLine(list.Get(99));  

            //var numList = new SafeList<int>();
            //        numList.Add(42);
            //Console.WriteLine(numList.Get(5)); 


            #endregion
            #region Q15
            //            Covariance allows a generic type with a more derived type argument to be assigned to a variable of a generic type with a less derived type argument.It is declared using the 'out' keyword on a type parameter in an interface or delegate.
            //Rule: 'out T' means T can only appear as a return type (output), never as a method parameter (input). This makes it safe to assign IProducer<Dog> to IProducer<Animal>.


            #endregion
            #region Q16
            //            Contravariance is the opposite of covariance. It allows a generic type with a less derived type argument to be assigned to a variable expecting a more derived type argument.It is declared using the 'in' keyword.
            //Rule: 'in T' means T can only appear as a method parameter(input), never as a return type(output).This makes it safe to use Action<Animal> where Action< Dog > is expected.


            #endregion
            #region Q17
            // Difference between covariance and contravariance:
            //Covariance (out T): Allows assignment from more derived to less derived types. Used for producers (e.g., IEnumerable<out T>).
            //Contravariance (in T): Allows assignment from less derived to more derived types. Used for consumers (e.g., Action<in T>).

            #endregion
            #region Q18
            //Static members in generic classes are NOT shared across all type instantiations.Each closed generic type(e.g., Counter<int>, Counter<string>) gets its own copy of the static member.They are separate types at runtime.

            #endregion
            #region Q19
            //            Close the type parameter: Supply a concrete type to the base class.
            //	Keep it open: Pass T through to the derived class as well.
            //	Add new type parameters: The derived class can introduce new type params.


            #endregion
            #region Q20
            //            public class CacheEntry<TValue>
            //{
            //    public TValue Value { get; }
            //    public DateTime ExpiresAt { get; }
            //    public bool IsExpired => DateTime.UtcNow > ExpiresAt;

            //    public CacheEntry(TValue value, TimeSpan ttl)
            //    {
            //        Value = value;
            //        ExpiresAt = DateTime.UtcNow.Add(ttl);
            //    }
            //}

            //public class Cache<TKey, TValue>
            //{
            //    private readonly Dictionary<TKey, CacheEntry<TValue>> _store
            //        = new Dictionary<TKey, CacheEntry<TValue>>();

            //    private readonly TimeSpan _defaultTtl;

            //    public Cache(TimeSpan defaultTtl)
            //    {
            //        _defaultTtl = defaultTtl;
            //    }

            //    public void Add(TKey key, TValue value, TimeSpan? ttl = null)
            //    {
            //        var entry = new CacheEntry<TValue>(value, ttl ?? _defaultTtl);
            //        _store[key] = entry;
            //    }

            //    public TValue Get(TKey key)
            //    {
            //        if (!_store.TryGetValue(key, out var entry))
            //            throw new KeyNotFoundException($"Key not found: {key}");

            //        if (entry.IsExpired)
            //        {
            //            _store.Remove(key);
            //            throw new InvalidOperationException($"Cache entry for '{key}' has expired.");
            //        }
            //        return entry.Value;
            //    }

            //    public bool TryGet(TKey key, out TValue value)
            //    {
            //        value = default;
            //        if (!_store.TryGetValue(key, out var entry) || entry.IsExpired)
            //        {
            //            _store.Remove(key);
            //            return false;
            //        }
            //        value = entry.Value;
            //        return true;
            //    }

            //    public bool Contains(TKey key)
            //    {
            //        if (!_store.TryGetValue(key, out var entry)) return false;
            //        if (entry.IsExpired) { _store.Remove(key); return false; }
            //        return true;
            //    }

            //    public bool Remove(TKey key) => _store.Remove(key);

            //    public int Purge()
            //    {
            //        var expired = _store.Where(kv => kv.Value.IsExpired)
            //                            .Select(kv => kv.Key).ToList();
            //        foreach (var key in expired) _store.Remove(key);
            //        return expired.Count;
            //    }

            //    public int Count => _store.Count;
            //}

            //var cache = new Cache<string, string>(defaultTtl: TimeSpan.FromMinutes(5));

            //cache.Add("user:1", "Alice");
            //cache.Add("user:2", "Bob", TimeSpan.FromSeconds(1)); 

            //Console.WriteLine(cache.Contains("user:1")); 

            //if (cache.TryGet("user:1", out string name))
            //    Console.WriteLine(name);                   

            //cache.Remove("user:1");
            //Console.WriteLine(cache.Contains("user:1"));  

            //cache.Purge(); 


            #endregion

        }
    }
}




