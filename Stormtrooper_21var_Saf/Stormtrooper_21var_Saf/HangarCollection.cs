using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Stormtrooper_21var_Saf
{
    public class HangarCollection
    {
        public readonly Dictionary<string, Hangar<Vehicle>> HangarStages;
        public List<string> Keys => HangarStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';
        private readonly Logger logger;
        public HangarCollection(int pictureWidth, int pictureHeight)
        {
            HangarStages = new Dictionary<string, Hangar<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            logger = LogManager.GetCurrentClassLogger();
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
                    foreach (ITransport plane in level.Value)
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
            }
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                logger.Warn("Файл не существует");
                throw new FileNotFoundException();
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
                    logger.Warn("Неверный формат файла");
                    throw new FileFormatException("Неверный формат файла");
                }
                else
                {
                    parkingStages.Clear();
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
                            logger.Warn("Не удалось загрузить самолет на место");
                            throw new IndexOutOfRangeException("Не удалось загрузить самолет на место");
                        }
                    }
                    else if (lines.Split(separator)[0] == "Stormtrooper")
                    {
                        plane = new Stormtrooper(lines.Split(separator)[1]);
                        var result = HangarStages[key] + plane;
                        if (result < 0)
                        {
                            logger.Warn("Не удалось загрузить самолет на место");
                            throw new IndexOutOfRangeException("Не удалось загрузить самолет на место");
                        }
                    }
                }
            }
        }
    }
}
