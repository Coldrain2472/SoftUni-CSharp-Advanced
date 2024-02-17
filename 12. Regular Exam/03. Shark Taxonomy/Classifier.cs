using System.Text;

namespace SharkTaxonomy
{
    public class Classifier
    {
        public Classifier(int capacity)
        {
            Capacity = capacity;
            Species = new List<Shark>();
        }

        public int Capacity { get; set; }
        public List<Shark> Species { get; set; }
        public int GetCount => Species.Count;

        public void AddShark(Shark shark)
        {
            if (Capacity > Species.Count && !Species.Any(x => x.Kind == shark.Kind))
            {
                Species.Add(shark);
            }
        }

        public bool RemoveShark(string kind)
        {
            Shark shark = Species.Find(x => x.Kind == kind);
            if (shark != null)
            {
                Species.Remove(shark);
                return true;
            }

            return false;
        }

        public string GetLargestShark()
        {

            Shark shark = Species.OrderByDescending(x => x.Length).First();
            return shark.ToString();
        }

        public double GetAverageLength()
        {
            return Species.Average(x => x.Length);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} sharks classified:");
            foreach (Shark shark in Species)
            {
                sb.AppendLine(shark.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
