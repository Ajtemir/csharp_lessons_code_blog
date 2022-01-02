﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

// binary
// soap to array more defend
// json [DataContract] from Nuget [DataMember]
// xml
// binary method serialize all property
namespace lesson_26_serialization_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = new List<Group>();
            var students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new Group(i, name:"Группа "+i));
            }

            for (int i = 0; i < 300; i++)
            {
                var student = new Student(Guid.NewGuid().ToString().Substring(0, 5), i % 100)
                {
                    Group = groups[i%9]
                };
                students.Add(student);

            }

            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, groups);
            }
            
            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<Group>;
                if (newGroups != null)
                {
                    foreach (var VARIABLE in newGroups)
                    {
                        Console.WriteLine(VARIABLE);
                    }
                }
            }

            var xmlFormatter = new XmlSerializer(typeof(List<Group>));
            




        }
    }
}