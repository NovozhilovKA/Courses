using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace BatlleShips.Game
{
    public static class Constants
    {
        public static List<Ship> SHIPS { get; }

        public static List<Ship> STARTING_SHIPS { get; }

        public static void InitShips()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                SHIPS.AddRange(CollectTypes<Ship, ShipAttribute>(asm));
            }
            foreach(var shipType in SHIPS)
            {
                for (int i = 0; i < shipType.numberOfShips; i++)
                {
                    STARTING_SHIPS.Add(shipType.Clone());
                }
            }
        }

        public static List<T> CollectTypes<T,TA>(Assembly asm)
            where TA: Attribute
        {
            var res = new List<T>();

            foreach(var type in asm.GetTypes())
            {
                var attr = type.GetCustomAttribute<TA>();
                if (attr != null)
                {
                    res.Add((T)Activator.CreateInstance(type));
                }
            }

            return res;
        }


        public static int MAP_SIZE = 10;
    }
}
