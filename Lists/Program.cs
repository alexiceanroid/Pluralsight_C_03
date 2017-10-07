using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReadonlyPractice();
            // NonBlankStringListPractice();
            ObservableCollection<string> presidents = new ObservableCollection<string>
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush"
            };
            presidents.CollectionChanged += OnCollectionChanged;

            presidents.Add("Bill Clinton");
            presidents.Remove("Jimmy Carter");

            foreach (var president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        static void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            string desc = "";
            if (e.NewItems != null)
            {
                desc += "New items have been added: \n";
                foreach (var item in e.NewItems)
                {
                    desc += item.ToString() + "\n";
                }
            }


            if (e.OldItems != null)
            {
                desc += "The following items have been removed: \n";
                foreach (var item in e.OldItems)
                {
                    desc += item.ToString() + "\n";
                }
            }

            Console.WriteLine(desc);
        }

        static void ReadonlyPractice()
        {
            var presidents = new List<string>(12)
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush"
            };
            presidents.Add("Barack Obama");

            string firstElem = presidents[0];
            presidents.AddRange(new string[] { "first pres", "second pres" });
            var presidents_read = presidents.AsReadOnly();



            Console.WriteLine(presidents_read.GetHashCode());

            foreach (var pres in presidents_read)
            {
                Console.WriteLine(pres);
            }
        }
        static void NonBlankStringListPractice()
        {
            NonBlankStringList list = new NonBlankStringList();
            try
            {
                list.Add("   ");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            list[0] = "item 0 changed";
            list.Add("item 1");
            list.Insert(2, "item 2 inserted");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    class NonBlankStringList : Collection<string>
    {
        protected override void InsertItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("The item must be non-null and non-white space!");
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, string item)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("The item must be non-null and non-white space!");
            base.SetItem(index, item);
        }
    }
}
