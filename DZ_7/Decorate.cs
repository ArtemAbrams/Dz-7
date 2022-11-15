using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    abstract class Tree
    {
        public string Locations { get; private set; }
        public Tree(string locations)
        {
            Locations = locations;
        }
        public abstract void Beatify();
    }
    class ChristmasTree : Tree 
    {
        public ChristmasTree(string location) : base (location)
        {
        }
        public override void Beatify()
        {
            Console.WriteLine($"Ну ялинка вже є в {Locations}:)");
        }

    }
    abstract class TreeDecorate : Tree
    {
        protected Tree tree;
        public TreeDecorate(string location, Tree tree): base(location)
        {
            this.tree = tree;
        }
    }
    class ToysDecorate : TreeDecorate
    {
        private string? decorations = null;
        public ToysDecorate(Tree tree) : base(tree.Locations, tree)
        { 
        }
        public void SetDecorations(string decoration)
        {
            decorations += decoration + " ";
        }
        public override void Beatify()
        {
            tree.Beatify();
            if (decorations == null)
                Console.WriteLine("Ялинку прикрасили снігом . . .");
            else
                Console.WriteLine("Ялинку прикрасили  " + decorations);
        }
    }
    class GarlandDecorate : TreeDecorate
    {
        public GarlandDecorate(Tree tree) : base(tree.Locations, tree)
        {}
        public override void Beatify()
        {
            tree.Beatify();
            Console.WriteLine("Ялиночку прикрасили гірляндами, ялинка світиться");
        }
    }
}
