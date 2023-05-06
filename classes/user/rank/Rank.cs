using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraditeljDomaci.classes.user.rank
{
    /// <summary>
    /// Zvanje nastavnika | U realnom projektu ovo ce biti Profesor ili Asistent
    /// Ovo moze biti Enumerator, ali je ovako kompleksnije radi demonstracije Builder patterna
    /// </summary>
    public class Rank
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Rank(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nNaziv: {Name}\n";
        } 
    }
}
