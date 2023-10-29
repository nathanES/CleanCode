using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Composite
{
    public abstract class FileSystemElement
    {
        public abstract int GetCount();
        public FileSystemElement( string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
    public class DirectoryElement : FileSystemElement 
    {
        private List<FileSystemElement> _elements = new();
        public IEnumerable<FileSystemElement> Elements => _elements;
        public DirectoryElement(string name)
            :base(name) 
        {

        }
        public void AddElement(FileSystemElement element)
        {
            _elements.Add(element);
        }
        public void RemoveElement(string nom)
        {
            _elements.RemoveAll(e => e.Name.Equals(nom));
        }

        public override int GetCount()
            => Elements.Sum(x=> x.GetCount());
    }
    public class FileElement : FileSystemElement
    {
        public FileElement(string name)
            : base(name)
        {

        }

        public override int GetCount() => 1;
    }
}
