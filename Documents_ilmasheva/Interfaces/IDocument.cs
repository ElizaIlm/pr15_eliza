using Documents_ilmasheva.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents_ilmasheva.Interfaces
{
    public interface IDocument
    {
        void Save(bool Update = false);
        List<Classes.DocumentContext> AllDocuments();
        void Delete();
    }
}
