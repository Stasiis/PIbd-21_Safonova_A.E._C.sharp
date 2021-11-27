﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stormtrooper_21var_Saf
{
    public class HangarCollection
    {
        public readonly Dictionary<string, Hangar<Vehicle>> HangarStages;
        public List<string> Keys => HangarStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            HangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddHangar(string name)
        {
            if (HangarStages.ContainsKey(name))
            {
                return;
            }
            HangarStages.Add(name, new Hangar<Vehicle>(pictureHeight, pictureWidth));
        }
        public void DelHangar(string name)
        {
            if (HangarStages.ContainsKey(name))
            {
                HangarStages.Remove(name);
            }
        }
        public Hangar<Vehicle> this[string ind]
        {
            get
            {
                if (HangarStages.ContainsKey(ind))
                {
                    return HangarStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"HangarCollection{Environment.NewLine}", fs);
                foreach (var level in HangarStages)
                {
                    fs.Write($"Hangar{separator}{level.Key}{Environment.NewLine}", fs);
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Plane")
                            {
                                fs.Write($"Plane{separator}", fs);
                            }
                            if (plane.GetType().Name == "Stormtrooper")
                            {
                                fs.Write($"Stormtrooper{separator}", fs);
                            }
                            fs.Write(plane + Environment.NewLine, fs);
                        }
                    }
                }
                return true;
            }
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            HangarStages.Clear();
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                String lines;
                Vehicle plane = null;
                string key = string.Empty;
                lines = sr.ReadLine();
                if (!lines.Contains("HangarCollection"))
                {
                    return false;
                }
                while ((lines = sr.ReadLine()) != null)
                {
                    if (lines.Contains("Hangar"))
                    {
                        key = lines.Split(separator)[1];
                        HangarStages.Add(key, new Hangar<Vehicle>(pictureHeight, pictureWidth));
                    }
                    else if (lines.Split(separator)[0] == "Plane")
                    {
                        plane = new Plane(lines.Split(separator)[1]);
                        var result = HangarStages[key] + plane;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else if (lines.Split(separator)[0] == "Stormtrooper")
                    {
                        plane = new Stormtrooper(lines.Split(separator)[1]);
                        var result = HangarStages[key] + plane;
                        if (result < 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return true;
        }
    }
}
