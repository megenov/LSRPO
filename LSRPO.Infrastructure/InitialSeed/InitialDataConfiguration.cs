﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System.Text;

namespace LSRPO.Infrastructure.InitialSeed
{
    internal class InitialDataConfiguration<T> : IEntityTypeConfiguration<T> where T : class
    {
        private readonly string filePath;

        public InitialDataConfiguration(string _filePath)
        {
            filePath = _filePath;
        }

        public void Configure(EntityTypeBuilder<T> builder)
        {
            System.Text.EncodingProvider ppp = System.Text.CodePagesEncodingProvider.Instance;
            Encoding.RegisterProvider(ppp);

            string? jsonData = GetFromFile();

            if (jsonData != null)
            {
                var utfBytes = Encoding.Convert(Encoding.GetEncoding("ISO-8859-5"), Encoding.UTF8, Encoding.UTF8.GetBytes(jsonData));
                string encoded = Encoding.UTF8.GetString(utfBytes);
                List<T> data = JsonConvert.DeserializeObject<List<T>>(encoded);

                builder.HasData(data);
            }
        }

        private string? GetFromFile()
        {
            string? result = null;

            if (File.Exists(filePath))
            {
                result = File.ReadAllText(filePath);
            }

            return result;
        }
    }
}