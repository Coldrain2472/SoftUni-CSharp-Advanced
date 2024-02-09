﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Clothes = new List<Cloth>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Cloth> Clothes { get; set; }

        public void AddCloth(Cloth cloth)
        {
            if (Capacity > Clothes.Count)
            {
                Clothes.Add(cloth);
            }
        }

        public bool RemoveCloth(string color)
        {
            Cloth cloth = Clothes.FirstOrDefault(x => x.Color == color);
            if (Clothes.Remove(cloth))
            {
                return true;
            }

            return false;
        }

        public Cloth GetSmallestCloth()=> Clothes.OrderBy(x=>x.Size).FirstOrDefault();

        public Cloth GetCloth(string color)
        {
            Cloth cloth = Clothes.Find(x => x.Color == color);
            
            return cloth;
        }

        public int GetClothCount()
        {
            return Clothes.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (Cloth cloth in Clothes.OrderBy(x=>x.Size))
            {
                sb.AppendLine(cloth.ToString());
            }

            return sb.ToString().TrimEnd();
        }


    }
}
