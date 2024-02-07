﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialisation_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nikhita_palla\Documents\Github\Dotnet_Practice\06-02-2024\Serialisation\Serialisation_JSON\Json_file.json";

            using(FileStream fs=new FileStream(path,FileMode.OpenOrCreate))
            {
                Employee emp = new Employee(1, "Ramesh");

                String jsonString=JsonSerializer.Serialize(emp);
            }
        }
    }
}
