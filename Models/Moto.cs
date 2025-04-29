using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public double Kilometragem { get; set; }
        public decimal Litros { get; set; }
        public string Tags { get; set; }
        public string Onde { get; set; }
        public double KmAndado { get; set; }
        public double Media { get; set; }
        
    }
}